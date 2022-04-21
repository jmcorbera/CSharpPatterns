using CSharpPatterns.AppConsole.Clients;
using System;

namespace CSharpPatterns.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateMethodClient.MainTemplateMethod();
            Console.ReadLine();
            Console.Clear();

            FinancialClient.MainFinancial();
            Console.ReadLine();
            Console.Clear();

            CommandClient.MainCommand();
            Console.ReadLine();
            Console.Clear();

            DecorateClient.MainDecorate();
            Console.ReadLine();
            Console.Clear();

            ChainOfResponsabilityClient.MainChainOfResponsability();
            Console.ReadLine();
            Console.Clear();

        }
    }
}
