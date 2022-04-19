namespace CSharpPattern.Strategy
{
    public class StrategyAdd : IStrategy
    {
        public int DoAlgorithm(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
