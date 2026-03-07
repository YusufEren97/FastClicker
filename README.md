# FastClicker

[Türkçe](#turkce) | [English](#english)

<a id="english"></a>
## English

A simple and lightweight auto clicker application for Windows.

![Screenshot](Screenshot/sc1.png)
![Screenshot](Screenshot/sc2.png)

Only 27 KB in size, no installation required. Just download and run. No complex settings or unnecessary features, just the simple interface you need.

### Features

- Adjustable clicking speed (CPS)
- Left, Right, and Middle mouse button support
- Hold or Toggle modes
- Customizable trigger key
- Dark and Light theme options
- Turkish and English language support
- Draggable window

### Usage

1. Enter CPS (clicks per second) value
2. Select trigger key (default F6)
3. Select mouse button (Left/Right/Middle)
4. Select mode (Hold or Toggle)
5. Press trigger key

### Download

To use directly without compiling:

[Download FastClicker.exe](Releases/FastClicker.exe)

**Note:** You may see a Windows SmartScreen warning when downloading. This is due to the exe file being unsigned, which is normal for independent developer projects. Click "More info" and then "Run anyway" to run.

### Requirements

- Windows 7 or higher
- .NET Framework 4.8 (installed by default on Windows 10 and 11)

### Technologies

- C# (.NET Framework 4.8)
- Windows Forms
- user32.dll (mouse_event, GetAsyncKeyState)

### Build

If you want to compile the project yourself:

```bash
git clone https://github.com/YusufEren97/FastClicker.git
cd FastClicker
dotnet build -c Release
```

The compiled file will be created at `bin\Release\net48\FastClicker.exe`.

### License

This project is published under the MIT license.

---

<a id="turkce"></a>
## Türkçe

Windows için basit ve hafif bir otomatik tıklama uygulaması.



Sadece 27 KB boyutunda, kurulum gerektirmez. İndirin ve çalıştırın. Karmaşık ayarlar veya gereksiz özellikler yok, sadece ihtiyacınız olan sade bir arayüz.

### Özellikler

- Ayarlanabilir tıklama hızı (CPS)
- Sol, sağ ve orta fare tuşu desteği
- Basılı tut veya aç/kapa modları
- Özelleştirilebilir tetikleyici tuşu
- Karanlık ve aydınlık tema seçeneği
- Türkçe ve İngilizce dil desteği
- Pencere sürüklenebilir

### Kullanım

1. CPS (saniyedeki tıklama sayısı) değerini girin
2. Tetikleyici tuşunu seçin (varsayılan F6)
3. Fare tuşunu seçin (Sol/Sağ/Orta)
4. Modu seçin (Basılı Tut veya Aç/Kapa)
5. Tetikleyici tuşuna basın

### İndirme

Derlenmeye gerek kalmadan doğrudan kullanmak için:

[FastClicker.exe indir](Releases/FastClicker.exe)

**Not:** Dosyayı indirdiğinizde Windows SmartScreen uyarısı görebilirsiniz. Bu, exe dosyasının imzasız olmasından kaynaklanır ve tüm bağımsız geliştiricilerin projelerinde normaldir. Çalıştırmak için "Daha fazla bilgi" ve ardından "Yine de çalıştır" seçeneklerine tıklayın.

### Gereksinimler

- Windows 7 veya üstü
- .NET Framework 4.8 (Windows 10 ve 11'de varsayılan olarak yüklü)

### Teknolojiler

- C# (.NET Framework 4.8)
- Windows Forms
- user32.dll (mouse_event, GetAsyncKeyState)

### Derleme

Projeyi kendiniz derlemek isterseniz:

```bash
git clone https://github.com/YusufEren97/FastClicker.git
cd FastClicker
dotnet build -c Release
```

Derlenen dosya `bin\Release\net48\FastClicker.exe` konumunda oluşur.

### Lisans

Bu proje MIT lisansı altında yayınlanmıştır.
