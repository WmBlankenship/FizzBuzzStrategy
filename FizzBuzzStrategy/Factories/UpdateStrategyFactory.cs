using FizzBuzzStrategy.Interfaces;
using FizzBuzzStrategy.Strategies;

namespace FizzBuzzStrategy.Factories
{
    public class UpdateStrategyFactory : IUpdateStrategyFactory
    {
        public IUpdateStrategy Create(int inputNumber)
        {
            if (inputNumber % 15 == 0)
            {
                return new ThreeAndFiveStrategy(inputNumber);
            }
            else if (inputNumber % 5 == 0)
            {
                return new FiveStrategy(inputNumber);
            }
            else if (inputNumber % 3 == 0)
            {
                return new ThreeStrategy(inputNumber);
            }
            else
            {
                return new StandardStrategy(inputNumber);
            }
        }
    }
}