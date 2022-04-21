using System;

namespace CSharpPattern.ChainOfResponsability
{
    public class Manager : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 20000.0)
            {
                Console.WriteLine("{0} --> sale approved ticket # {1}", this.GetType().Name, purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}