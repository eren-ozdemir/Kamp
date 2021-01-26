using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void Basvuru(List<IKrediManager> krediManagers, List<ILoggerService> loggerServices)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
