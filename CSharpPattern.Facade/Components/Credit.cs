using CSharpPattern.Facade.Entities;
using System;

namespace CSharpPattern.Facade.Components
{
    public class Credit
    {
        public bool GenerateCredit(CreditData creditData) { return creditData != null; }

        public void CreditRejected() { Console.WriteLine("Fail to generate the credit."); }
    }
}
