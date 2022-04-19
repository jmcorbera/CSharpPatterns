using System;

namespace CSharpPattern.Template
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation 1");
        }

        protected override void RequiredOperations2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation 2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
        }
    }
}
