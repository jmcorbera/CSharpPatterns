using CSharpPattern.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns.AppConsole.Clients
{
    public class TemplateMethodClient
    {
        public static void MainTemplateMethod()
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            ClientCode(new ConcreteClass2());
        }

        private static void ClientCode(AbstractClass abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }

    }

}
