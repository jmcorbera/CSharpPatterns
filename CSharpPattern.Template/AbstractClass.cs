using System;

namespace CSharpPattern.Template
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.ConcreteOperation1();
            this.ConcreteOperation2();
            this.RequiredOperations1();
            this.RequiredOperations2();

            this.Hook1();
        }

        protected void ConcreteOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected void ConcreteOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperations2();

        protected virtual void Hook1() { }

    }
}
