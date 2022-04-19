namespace CSharpPattern.Strategy
{
    public class Context
    {
        IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int value1, int value2)
        {
            return _strategy.DoAlgorithm(value1, value2);
        }
    }
}
