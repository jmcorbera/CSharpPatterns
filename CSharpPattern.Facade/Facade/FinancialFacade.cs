using CSharpPattern.Facade.Components;
using CSharpPattern.Facade.Entities;
using System;

namespace CSharpPattern.Facade.Facade
{
    public class FinancialFacade
    {
        private Scoring _scoring;
        private Report _report;
        private Data _data;
        private Credit _credit;

        private CreditData _creditData;
        private string _eeReport;

        public FinancialFacade()
        {
            _scoring = new Scoring();
            _report = new Report();
            _data = new Data();
            _credit = new Credit();
        }

        public void CalculateScoring(decimal income, decimal loan, int fees)
        {
            bool incomeChecked = _scoring.CheckIncome(income, loan);

            if (incomeChecked)
            {
                decimal _scoringCalculated = _scoring.GetScoring(loan);

                decimal _feeAmount = _scoring.CalculateFeeAmount(_scoringCalculated, fees);

                _creditData = new CreditData() { amount = _scoringCalculated, feeAmount = _feeAmount, fees = fees };
            }
            else
            {
                _scoring.ScoringRejected();
            }
        }

        public void RunExternalReports(string identification, string sex)
        {
            _eeReport = _report.GetExternalReport(identification, sex);

            if (_report.isRejected(_eeReport))
            { 
                _report.ReportRejected();
            }
        }

        public void LoadPersonalData(Person person)
        {
            if(_data.InsertPersonalData(person))
            {
                _data.DataFailed();
            }
        }

        public void GenerateCredit()
        {
            if(_credit.GenerateCredit(_creditData))
            {
                Console.WriteLine("Credit generated successfully!!");
            }
            else
            {
                _credit.CreditRejected();
            }          
        }
    }
}
