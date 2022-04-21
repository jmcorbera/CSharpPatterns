using System;

namespace CSharpPattern.Decorate.Decorators
{
    public class FaceBookNotifier : NotifierDecorator
    {

        public FaceBookNotifier(Notifier notifier) : base(notifier) {}

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Sending original message via Decorate FaceBook  : " + message);
        }
    }
}
