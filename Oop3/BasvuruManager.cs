using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    internal class BasvuruManager
    {   //Method injection   bide ctor injection var ona bak ve abstract classlar odev
        public void BasvuruYap(IKrediBaseManager kredimanager, ILoggerService logger)
        {
            //Basvuran bilgilerini degerlendirme
            //
            kredimanager.Hesapla();
            logger.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler )
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
