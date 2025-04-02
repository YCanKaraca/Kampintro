

Kurs kurs1 = new Kurs();
kurs1.KursEgitmeni = "Yusuf Can";
kurs1.IzlenmeOrani = 68;
kurs1.KursAdi = "C#";

Kurs kurs2 = new Kurs();
kurs2.KursEgitmeni = "Ahmet";
kurs2.IzlenmeOrani = 66;
kurs2.KursAdi = "Java";
//Console.WriteLine(kurs1.KursEgitmeni + " : " + kurs1.IzlenmeOrani);

Kurs[] KursDizisi = new Kurs[] {kurs1, kurs2};

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
