using System;

namespace CSharpPattern.Decorate.Decorators
{
    public class SMSNotifier : NotifierDecorator
    {
        public SMSNotifier(Notifier notifier): base(notifier) {}

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Sending original message via Decorate SMS : " + message);
        }
    }
}
