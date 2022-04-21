using System;

namespace CSharpPattern.ChainOfResponsability
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.00)
            {
                Console.WriteLine("{0} --> sale approved ticket # {1}", this.GetType().Name, purchase.Number);
            }
            else 
            {
                Console.WriteLine("app --> ticket # {0} requires financial scoring!", purchase.Number);
            }
        }
    }
}
