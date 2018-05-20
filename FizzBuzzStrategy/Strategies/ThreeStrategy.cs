using FizzBuzzStrategy.Interfaces;

namespace FizzBuzzStrategy.Strategies
{
    public class ThreeStrategy : BaseStrategy, IUpdateStrategy
    {
        public ThreeStrategy(int numberToUpdate)
            : base(numberToUpdate)
        {
        }

        public override string UpdateValue()
        {
            return "Fizz";
        }
    }
}