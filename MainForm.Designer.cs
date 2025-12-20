namespace FastClicker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.header = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLang = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlMode = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusVal = new System.Windows.Forms.Label();
            this.lblClicksLabel = new System.Windows.Forms.Label();
            this.lblClicks = new System.Windows.Forms.Label();
            this.lblCps = new System.Windows.Forms.Label();
            this.txtCps = new System.Windows.Forms.TextBox();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.lblButton = new System.Windows.Forms.Label();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.lblMode = new System.Windows.Forms.Label();
            this.rbHold = new System.Windows.Forms.RadioButton();
            this.rbToggle = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.header.Controls.Add(this.lblTitle);
            this.header.Controls.Add(this.btnLang);
            this.header.Controls.Add(this.btnMin);
            this.header.Controls.Add(this.btnTheme);
            this.header.Controls.Add(this.btnClose);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(220, 35);
            this.header.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FastClicker";
            // 
            // btnLang
            // 
            this.btnLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLang.FlatAppearance.BorderSize = 0;
            this.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLang.ForeColor = System.Drawing.Color.White;
            this.btnLang.Location = new System.Drawing.Point(128, 5);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(35, 25);
            this.btnLang.TabIndex = 1;
            this.btnLang.Text = "TR";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.Location = new System.Drawing.Point(100, 5);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(25, 25);
            this.btnTheme.TabIndex = 4;
            this.btnTheme.Text = "🌙";
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(168, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 25);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "—";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(192, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.statusPanel.Controls.Add(this.lblStatus);
            this.statusPanel.Controls.Add(this.lblStatusVal);
            this.statusPanel.Controls.Add(this.lblClicksLabel);
            this.statusPanel.Controls.Add(this.lblClicks);
            this.statusPanel.Location = new System.Drawing.Point(10, 45);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(200, 100);
            this.statusPanel.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblStatus.Location = new System.Drawing.Point(0, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "DURUM: ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusVal
            // 
            this.lblStatusVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblStatusVal.Location = new System.Drawing.Point(100, 12);
            this.lblStatusVal.Name = "lblStatusVal";
            this.lblStatusVal.Size = new System.Drawing.Size(90, 20);
            this.lblStatusVal.TabIndex = 1;
            this.lblStatusVal.Text = "BOŞTA";
            this.lblStatusVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClicksLabel
            // 
            this.lblClicksLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblClicksLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblClicksLabel.Location = new System.Drawing.Point(0, 40);
            this.lblClicksLabel.Name = "lblClicksLabel";
            this.lblClicksLabel.Size = new System.Drawing.Size(200, 18);
            this.lblClicksLabel.TabIndex = 2;
            this.lblClicksLabel.Text = "TIKLAMA";
            this.lblClicksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClicks
            // 
            this.lblClicks.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblClicks.ForeColor = System.Drawing.Color.White;
            this.lblClicks.Location = new System.Drawing.Point(0, 58);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(200, 35);
            this.lblClicks.TabIndex = 3;
            this.lblClicks.Text = "0";
            this.lblClicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCps
            // 
            this.lblCps.AutoSize = true;
            this.lblCps.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCps.Location = new System.Drawing.Point(15, 160);
            this.lblCps.Name = "lblCps";
            this.lblCps.Size = new System.Drawing.Size(64, 19);
            this.lblCps.TabIndex = 2;
            this.lblCps.Text = "Hız (CPS)";
            // 
            // txtCps
            // 
            this.txtCps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtCps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCps.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCps.ForeColor = System.Drawing.Color.White;
            this.txtCps.Location = new System.Drawing.Point(140, 158);
            this.txtCps.Name = "txtCps";
            this.txtCps.ShortcutsEnabled = false;
            this.txtCps.Size = new System.Drawing.Size(60, 25);
            this.txtCps.TabIndex = 3;
            this.txtCps.Text = "10";
            this.txtCps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCps_KeyPress);
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTrigger.Location = new System.Drawing.Point(15, 200);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(66, 19);
            this.lblTrigger.TabIndex = 4;
            this.lblTrigger.Text = "Tetikleyici";
            // 
            // btnTrigger
            // 
            this.btnTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrigger.FlatAppearance.BorderSize = 0;
            this.btnTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrigger.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrigger.ForeColor = System.Drawing.Color.White;
            this.btnTrigger.Location = new System.Drawing.Point(140, 198);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(60, 26);
            this.btnTrigger.TabIndex = 5;
            this.btnTrigger.Text = "F6";
            this.btnTrigger.UseVisualStyleBackColor = false;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblButton.Location = new System.Drawing.Point(15, 245);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(30, 19);
            this.lblButton.TabIndex = 6;
            this.lblButton.Text = "Tuş";
            // 
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.rbLeft);
            this.pnlButton.Controls.Add(this.rbRight);
            this.pnlButton.Controls.Add(this.rbMiddle);
            this.pnlButton.Location = new System.Drawing.Point(140, 245);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(80, 70);
            this.pnlButton.TabIndex = 7;
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Checked = true;
            this.rbLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbLeft.Location = new System.Drawing.Point(0, 0);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(41, 19);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Sol";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbRight.Location = new System.Drawing.Point(0, 22);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(44, 19);
            this.rbRight.TabIndex = 1;
            this.rbRight.Text = "Sağ";
            // 
            // rbMiddle
            // 
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbMiddle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbMiddle.Location = new System.Drawing.Point(0, 44);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(48, 19);
            this.rbMiddle.TabIndex = 2;
            this.rbMiddle.Text = "Orta";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblMode.Location = new System.Drawing.Point(15, 355);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(38, 19);
            this.lblMode.TabIndex = 10;
            this.lblMode.Text = "Mod";
            // 
            // 
            // pnlMode
            // 
            this.pnlMode.BackColor = System.Drawing.Color.Transparent;
            this.pnlMode.Controls.Add(this.rbHold);
            this.pnlMode.Controls.Add(this.rbToggle);
            this.pnlMode.Location = new System.Drawing.Point(140, 355);
            this.pnlMode.Name = "pnlMode";
            this.pnlMode.Size = new System.Drawing.Size(80, 50);
            this.pnlMode.TabIndex = 11;
            // 
            // rbHold
            // 
            this.rbHold.AutoSize = true;
            this.rbHold.Checked = true;
            this.rbHold.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbHold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbHold.Location = new System.Drawing.Point(0, 0);
            this.rbHold.Name = "rbHold";
            this.rbHold.Size = new System.Drawing.Size(73, 19);
            this.rbHold.TabIndex = 0;
            this.rbHold.TabStop = true;
            this.rbHold.Text = "Basılı Tut";
            // 
            // rbToggle
            // 
            this.rbToggle.AutoSize = true;
            this.rbToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbToggle.Location = new System.Drawing.Point(0, 22);
            this.rbToggle.Name = "rbToggle";
            this.rbToggle.Size = new System.Drawing.Size(70, 19);
            this.rbToggle.TabIndex = 1;
            this.rbToggle.Text = "Aç/Kapa";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(220, 456);
            this.Controls.Add(this.header);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.lblCps);
            this.Controls.Add(this.txtCps);
            this.Controls.Add(this.lblTrigger);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.pnlMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            using (var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("FastClicker.Resources.mouse.ico"))
                if (stream != null) this.Icon = new System.Drawing.Icon(stream);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastClicker";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlMode.ResumeLayout(false);
            this.pnlMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusVal;
        private System.Windows.Forms.Label lblClicksLabel;
        private System.Windows.Forms.Label lblClicks;
        private System.Windows.Forms.Label lblCps;
        private System.Windows.Forms.TextBox txtCps;
        private System.Windows.Forms.Label lblTrigger;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.RadioButton rbHold;
        private System.Windows.Forms.RadioButton rbToggle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlMode;
    }
}
