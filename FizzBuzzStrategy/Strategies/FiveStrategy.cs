using FizzBuzzStrategy.Interfaces;

namespace FizzBuzzStrategy.Strategies
{
    public class FiveStrategy : BaseStrategy, IUpdateStrategy
    {
        public FiveStrategy(int numberToUpdate) 
            : base(numberToUpdate)
        {
        }

        public override string UpdateValue()
        {
            return "Buzz";
        }
    }
}
