namespace CSharpPattern.Strategy
{
    public class StrategySub : IStrategy
    {
        public int DoAlgorithm(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}
