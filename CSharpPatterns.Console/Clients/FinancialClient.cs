using CSharpPattern.Facade.Entities;
using CSharpPattern.Facade.Facade;

namespace CSharpPatterns.AppConsole.Clients
{
    public class FinancialClient
    {
        public static void MainFinancial()
        {
            var name = "No-named";
            var identification = "2555444";
            var sex = "M";

            FinancialFacade financial = new FinancialFacade();

            financial.CalculateScoring(100000, 20000, 6);
            financial.RunExternalReports(identification, sex);
            financial.LoadPersonalData(new Person() { Name = name, Identification = identification, sex = sex }); ;
            financial.GenerateCredit();
        }
    }
}
