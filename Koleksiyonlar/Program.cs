﻿using System.Collections.Generic;

//string[] isimler = new string[]
//{
//    "Engin","Murat","Kerem","Halil"
//};
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);
//isimler = new string[5];
//isimler[4] = "Yusuf Can";
//Console.WriteLine(isimler[4]);
//Console.WriteLine(isimler[0]);





List<string> isimler2 = new List<string>()
{
    "Engin","Murat","Kerem","Halil"
};
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("Yusuf Can");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);
