using FizzBuzzStrategy.Interfaces;

namespace FizzBuzzStrategy.Strategies
{
    public class ThreeAndFiveStrategy : BaseStrategy, IUpdateStrategy
    {
        public ThreeAndFiveStrategy(int numberToUpdate)
            : base(numberToUpdate)
        {
        }

        public override string UpdateValue()
        {
            return "FizzBuzz";
        }
    }
}