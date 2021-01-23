using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injectio
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Hesapla();
            loggerService.Log();       }

        public void CreditPreInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
