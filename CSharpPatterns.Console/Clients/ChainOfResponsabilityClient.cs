using CSharpPattern.ChainOfResponsability;
using System;
using System.Collections.Generic;
namespace CSharpPatterns.AppConsole.Clients
{
    public class ChainOfResponsabilityClient
    {
        public static void MainChainOfResponsability()
        {
            Approver director = new Director();
            Approver manager = new Manager();
            Approver seller = new Seller();

            seller.SetSuccessor(manager);
            manager.SetSuccessor(director);

            Purchase p = new Purchase() { Number = 2034, Amount = 350.00, Purpose = "Supplies" };
            seller.ProcessRequest(p);

            p = new Purchase { Number = 2035, Amount = 26500.50, Purpose = "ultra Supplies" };
            seller.ProcessRequest(p);

            p = new Purchase { Number = 2036, Amount = 220000.00, Purpose = "ultra mega Supplies" };
            seller.ProcessRequest(p);
        }
    }
}
