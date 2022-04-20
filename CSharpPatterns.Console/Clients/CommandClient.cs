using CSharpPattern.Command;

namespace CSharpPatterns.AppConsole.Clients
{
    public class CommandClient
    {

        public static void MainCommand()
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}
