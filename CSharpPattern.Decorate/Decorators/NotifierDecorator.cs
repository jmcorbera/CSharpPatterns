namespace CSharpPattern.Decorate.Decorators
{
    public abstract class NotifierDecorator : Notifier
    {
        protected Notifier _notifier;

        public NotifierDecorator(Notifier notifier)
        {
            _notifier = notifier;
        }

        public override void Send(string message)
        {
            if(_notifier != null)
                _notifier.Send(message);
        }
    }
}
