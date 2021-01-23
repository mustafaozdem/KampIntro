﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerServce = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap( vehicleCreditManager, fileLoggerServce);

            List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager, vehicleCreditManager };

            //applicationManager.CreditPreInfo(credits);

        }
    }
}
