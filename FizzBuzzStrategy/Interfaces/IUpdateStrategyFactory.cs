namespace FizzBuzzStrategy.Interfaces
{
    public interface IUpdateStrategyFactory
    {
        IUpdateStrategy Create(int inputNumber);
    }
}
