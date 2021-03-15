using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager exportCreditManager = new ExportCreditManager();
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { fileLoggerService, databaseLoggerService };
            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(exportCreditManager, loggerServices);

            List<ICreditManager> credits = new List<ICreditManager>() {exportCreditManager, mortgageCreditManager };

            //applyManager.CrediPreInformation(credits);
        }
    }
}
