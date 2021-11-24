using CSharpPattern.Facade.Components;
using CSharpPattern.Facade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPattern.Facade.Facade
{
    public class Financial
    {
        private CalculateScoring scoring;
        private CreditReport report;
        private LoadData data;
        private GenerateCredit credit;

        public Financial()
        {
            scoring = new CalculateScoring();
            report = new CreditReport();
            data = new LoadData();
            credit = new GenerateCredit();
        }

        public void CalculateScoring(int incomings)
        {
            // Do something
        }

        public void ExternalReports(string identification, string sex)
        {
            // Do something
        }

        public void LoadPersonalData(Interested person)
        {
            // Do something
        }

        public void GenerateCredit()
        {
            // Do something
        }

    }
}
