using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FastClicker
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)] static extern uint SendInput(uint n, INPUT[] inputs, int size);
        [DllImport("user32.dll")] static extern short GetAsyncKeyState(int k);
        [DllImport("user32.dll")] static extern bool ReleaseCapture();
        [DllImport("user32.dll")] static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] static extern IntPtr GetMessageExtraInfo();

        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx, dy, mouseData, dwFlags, time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        }

        const uint INPUT_MOUSE = 0;
        const int MOUSEEVENTF_LEFTDOWN = 0x0002, MOUSEEVENTF_LEFTUP = 0x0004;
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008, MOUSEEVENTF_RIGHTUP = 0x0010;
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020, MOUSEEVENTF_MIDDLEUP = 0x0040;

        bool _run, _set, _tr = true, _dark = true;
        int _key = 117;
        long _count;

        public MainForm()
        {
            InitializeComponent();
            header.MouseDown += Header_MouseDown;
            lblTitle.MouseDown += Header_MouseDown;
            timer.Start();
        }

        void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 2, 0);
            }
        }

        void btnLang_Click(object sender, EventArgs e)
        {
            _tr = !_tr;
            btnLang.Text = _tr ? "TR" : "EN";
            lblStatus.Text = _tr ? "DURUM: " : "STATUS: ";
            lblClicksLabel.Text = _tr ? "TIKLAMA" : "CLICKS";
            lblCps.Text = _tr ? "Hız (CPS)" : "Speed (CPS)";
            lblTrigger.Text = _tr ? "Tetikleyici" : "Trigger";
            lblButton.Text = _tr ? "Tuş" : "Button";
            lblMode.Text = _tr ? "Mod" : "Mode";
            rbLeft.Text = _tr ? "Sol" : "Left";
            rbRight.Text = _tr ? "Sağ" : "Right";
            rbMiddle.Text = _tr ? "Orta" : "Middle";
            rbHold.Text = _tr ? "Basılı Tut" : "Hold";
            rbToggle.Text = _tr ? "Aç/Kapa" : "Toggle";
            UpdateStatus();
        }

        void btnTheme_Click(object sender, EventArgs e)
        {
            _dark = !_dark;
            btnTheme.Text = _dark ? "🌙" : "☀️";
            ApplyTheme();
        }

        void ApplyTheme()
        {
            Color bg = _dark ? Color.FromArgb(30, 30, 30) : Color.FromArgb(245, 245, 245);
            Color panel = _dark ? Color.FromArgb(37, 37, 38) : Color.FromArgb(235, 235, 235);
            Color btn = _dark ? Color.FromArgb(45, 45, 48) : Color.FromArgb(220, 220, 220);
            Color text = _dark ? Color.FromArgb(200, 200, 200) : Color.FromArgb(50, 50, 50);
            Color title = _dark ? Color.White : Color.Black;

            BackColor = bg;
            header.BackColor = bg;
            statusPanel.BackColor = panel;
            lblTitle.ForeColor = title;
            lblClicks.ForeColor = title;
            lblStatus.ForeColor = text;
            lblClicksLabel.ForeColor = _dark ? Color.FromArgb(136, 136, 136) : Color.FromArgb(100, 100, 100);
            lblCps.ForeColor = text;
            lblTrigger.ForeColor = text;
            lblButton.ForeColor = text;
            lblMode.ForeColor = text;
            rbLeft.ForeColor = text;
            rbRight.ForeColor = text;
            rbMiddle.ForeColor = text;
            rbHold.ForeColor = text;
            rbToggle.ForeColor = text;
            txtCps.BackColor = panel;
            txtCps.ForeColor = title;
            btnTrigger.BackColor = btn;
            btnTrigger.ForeColor = title;
            btnLang.BackColor = btn;
            btnLang.ForeColor = title;
            btnMin.BackColor = btn;
            btnMin.ForeColor = title;
            btnTheme.BackColor = btn;
            btnTheme.ForeColor = title;
        }

        void btnMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        void btnClose_Click(object sender, EventArgs e) => Application.Exit();
        void txtCps_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        void btnTrigger_Click(object sender, EventArgs e)
        {
            _set = true;
            btnTrigger.Text = "...";
            new Thread(() => {
                while (GetAsyncKeyState(1) != 0) Thread.Sleep(10);
                while (_set) {
                    for (int i = 1; i < 255; i++)
                        if ((GetAsyncKeyState(i) & 0x8000) != 0) {
                            _key = i;
                            Invoke((Action)(() => btnTrigger.Text = ((Keys)i).ToString()));
                            _set = false;
                            return;
                        }
                    Thread.Sleep(10);
                }
            }).Start();
        }

        void UpdateStatus()
        {
            lblStatusVal.Text = _run ? (_tr ? "ÇALIŞIYOR" : "RUNNING") : (_tr ? "BOŞTA" : "IDLE");
            lblStatusVal.ForeColor = _run ? Color.LimeGreen : Color.FromArgb(0, 122, 204);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblClicks.Text = _count.ToString();
            UpdateStatus();

            if (_set || _run) return;
            if ((GetAsyncKeyState(_key) & 0x8000) == 0) return;

            bool hold = rbHold.Checked;
            int delay = int.TryParse(txtCps.Text, out int c) && c > 0 ? 1000 / c : 100;
            int flagDown = rbRight.Checked ? MOUSEEVENTF_RIGHTDOWN : rbMiddle.Checked ? MOUSEEVENTF_MIDDLEDOWN : MOUSEEVENTF_LEFTDOWN;
            int flagUp = rbRight.Checked ? MOUSEEVENTF_RIGHTUP : rbMiddle.Checked ? MOUSEEVENTF_MIDDLEUP : MOUSEEVENTF_LEFTUP;

            _run = true;
            if (!hold) while ((GetAsyncKeyState(_key) & 0x8000) != 0) { Application.DoEvents(); Thread.Sleep(10); }

            new Thread(() => {
                int sz = Marshal.SizeOf(typeof(INPUT));
                while (_run) {
                    if (hold && (GetAsyncKeyState(_key) & 0x8000) == 0) break;
                    if (!hold && (GetAsyncKeyState(_key) & 0x8000) != 0) {
                        while ((GetAsyncKeyState(_key) & 0x8000) != 0) Thread.Sleep(10);
                        break;
                    }
                    var extra = GetMessageExtraInfo();
                    var down = new INPUT { type = INPUT_MOUSE, mi = new MOUSEINPUT { dwFlags = flagDown, dwExtraInfo = extra } };
                    var up = new INPUT { type = INPUT_MOUSE, mi = new MOUSEINPUT { dwFlags = flagUp, dwExtraInfo = extra } };
                    
                    int clickDuration = Math.Min(25, Math.Max(1, delay / 2));
                    int restDelay = Math.Max(0, delay - clickDuration);

                    SendInput(1, new[] { down }, sz);
                    Thread.Sleep(clickDuration);
                    SendInput(1, new[] { up }, sz);
                    Interlocked.Increment(ref _count);
                    if (restDelay > 0) Thread.Sleep(restDelay);
                }
                _run = false;
            }).Start();
        }
    }
}
