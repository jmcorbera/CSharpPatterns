using CSharpPattern.Decorate;
using CSharpPattern.Decorate.Decorators;
using System;

namespace CSharpPatterns.AppConsole.Clients
{
    public class DecorateClient
    {
        public static void MainDecorate()
        {
            string msg = "Hello World";

            NotifierMail notifier = new NotifierMail();
            Console.WriteLine("Client: I send a simple message with original implementation :");
            notifier.Send(msg);

            Console.WriteLine("Client: I send several messages with decorator implementations :");

            SMSNotifier smsNotifier = new SMSNotifier(notifier);
            FaceBookNotifier faceBookNotifier = new FaceBookNotifier(smsNotifier);

            faceBookNotifier.Send(msg);
        }
    }
}
