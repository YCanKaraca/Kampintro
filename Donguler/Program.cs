//array - dizi

string[] isimler = new string[]
{"Yusuf Can Karaca","Yasemin Karaca","Baris Karaca"};

for (int i = 0; i < isimler.Length; i++)
{
    Console.WriteLine(isimler[i]);
}
Console.WriteLine("For bitti");
foreach (string isim in isimler)
{
    Console.WriteLine(isim);
};
Console.WriteLine("Foreach bitti");
