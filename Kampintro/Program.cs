
//type safety - tip guvenligi
// do not repeat yourself

string Isim = "Yusuf Can Karaca";
Console.WriteLine(Isim);

double faizorani = 1.45;
bool SistemeGirisYapmismi = false;

double DolarDun = 7.25;
double DolarBugun = 7.35;

if (DolarDun < DolarBugun)
{
    Console.WriteLine("artis oku");
}
else if (DolarDun > DolarBugun)
{
    Console.WriteLine("azalis oku");
}
else
{
    Console.WriteLine("sabit oku");
}


if (SistemeGirisYapmismi == true)
{
    Console.WriteLine("kullanici ayarlari butonu");
}
else
{
    Console.WriteLine("giris yap butonu");
}