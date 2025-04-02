using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elmasi";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakir Karpuzu";

Urun[] urunler = new Urun[] {urun1,urun2};

//Type safe - Tip Guvenligi
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------------");
} 
Console.WriteLine("-------------------------Metotlar----------------------");
//Instance
//encapulation
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);


sepetManager.Ekle2("armut", "yesil armut", 12, 10);
sepetManager.Ekle2("elma","yesil elma",12,9);
sepetManager.Ekle2("karpuz","diyarbakir karpuzu",12,8);
