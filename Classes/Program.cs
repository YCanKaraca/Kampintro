

Kurs kurs1 = new Kurs();
kurs1.KursEgitmeni = "Yusuf Can";
kurs1.IzlenmeOrani = 68;
kurs1.KursAdi = "C#";

Kurs kurs2 = new Kurs();
kurs2.KursEgitmeni = "Ahmet";
kurs2.IzlenmeOrani = 66;
kurs2.KursAdi = "Java";

Kurs kurs3 = new Kurs();
kurs3.KursEgitmeni = "Mehmet";
kurs3.IzlenmeOrani = 15;
kurs3.KursAdi = "C++";
//Console.WriteLine(kurs1.KursEgitmeni + " : " + kurs1.IzlenmeOrani);

Kurs[] KursDizisi = new Kurs[] {kurs1, kurs2, kurs3};

foreach (var isim in KursDizisi)
{
    Console.WriteLine(isim.KursEgitmeni + " : " + isim.IzlenmeOrani);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string KursEgitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}
