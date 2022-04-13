using System;

namespace CSharpPattern.Facade.Components
{
    public class Scoring
    {
        public bool CheckIncome(decimal income, decimal loan) { return loan < (income * Convert.ToDecimal(0.5)); }

        public decimal GetScoring(decimal loan) { return loan;  }

        public decimal CalculateFeeAmount(decimal amount, int fees) { return amount / fees; }

        public void ScoringRejected() { Console.WriteLine("Insufficient score for the loan."); }
        
    }
}
