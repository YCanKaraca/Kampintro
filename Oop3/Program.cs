using System.Collections.Generic;
using Oop3;

IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediBaseManager tasitKrediManager = new TasitKrediManager();
IKrediBaseManager konutKrediManager = new KonutKrediManager();

ILoggerService dataLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, new DataBaseLoggerService());

List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyacKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

// !!!!NOT!!!!!   interfaceleri birbirinin alternatifi olan ama kod icerikleri farkli olan durumlar icin kullaniriz.