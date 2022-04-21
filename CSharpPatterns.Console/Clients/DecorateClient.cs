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

            ClientDecorateCode(notifier, msg, true, true);
        }

        private static void ClientDecorateCode(Notifier notifier, string msg, bool smsEnabled, bool FaceBookEnabled)
        {
            Console.WriteLine("Client: I send several messages with decorator implementations :");

            if (smsEnabled)
                notifier = new SMSNotifier(notifier);

            if (FaceBookEnabled)
                notifier = new FaceBookNotifier(notifier);

            notifier.Send(msg);
        }
    }
}
