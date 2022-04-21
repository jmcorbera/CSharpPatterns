using System;

namespace CSharpPattern.Decorate
{
    public class NotifierMail : Notifier
    {
        public override void Send(string message) 
        {
            Console.WriteLine("Sending original message via mail : " + message);
        }
    }
}
