# FastClicker

Windows icin basit ve hafif bir otomatik tiklama uygulamasi.

![Screenshot](Screenshot/sc1.png)
![Screenshot](Screenshot/sc2.png)

Sadece 26 KB boyutunda, kurulum gerektirmez. Indirin ve calistirin. Karmasik ayarlar veya gereksiz ozellikler yok, sadece ihtiyaciniz olan sade bir arayuz.

## Ozellikler

- Ayarlanabilir tiklama hizi (CPS)
- Sol, sag ve orta fare tusu destegi
- Basili tut veya ac/kapa modlari
- Ozellestirilebilir tetikleyici tusu
- Karanlik ve aydinlik tema secenegi
- Turkce ve Ingilizce dil destegi
- Pencere suruklenebilir

## Kullanim

1. CPS (saniyedeki tiklama sayisi) degerini girin
2. Tetikleyici tusunu secin (varsayilan F6)
3. Fare tusunu secin (Sol/Sag/Orta)
4. Modu secin (Basili Tut veya Ac/Kapa)
5. Tetikleyici tusuna basin

## Indirme

Derlenmeye gerek kalmadan dogrudan kullanmak icin:

[FastClicker.exe indir](Releases/FastClicker.exe)

## Gereksinimler

- Windows 7 veya ustu
- .NET Framework 4.8 (Windows 10 ve 11'de varsayilan olarak yuklu)

## Teknolojiler

- C# (.NET Framework 4.8)
- Windows Forms
- user32.dll (mouse_event, GetAsyncKeyState)

## Derleme

Projeyi kendiniz derlemek isterseniz:

```
git clone https://github.com/kullaniciadi/FastClicker.git
cd FastClicker
dotnet build -c Release
```

Derlenen dosya `bin\Release\net48\FastClicker.exe` konumunda olusur.

## Lisans

Bu proje MIT lisansi altinda yayinlanmistir.
