// See https://aka.ms/new-console-template for more information
using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Yusuf Can";
musteri1.Soyadi = "Karaca";
musteri1.TcNo = "2343243244";


// Tuzel musteri

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketIsmi = "kodlama.io";
musteri2.VergiNo = "3432432423";

Musteri musteri3 = new GercekMusteri(); //referans no bellekte
Musteri musteri4 = new TuzelMusteri();  //Musteri classi ebeveyn

CustomerManager customerManager = new CustomerManager(); 
customerManager.Add(musteri1);
customerManager.Add(musteri2);
customerManager.Add(musteri3);
customerManager.Add(musteri4);
