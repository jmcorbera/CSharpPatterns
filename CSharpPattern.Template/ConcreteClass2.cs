using System;

namespace CSharpPattern.Template
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation 1");
        }

        protected override void RequiredOperations2()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation 2");
        }

        protected override void Hook1() 
        {
            Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
        }
    }
}
