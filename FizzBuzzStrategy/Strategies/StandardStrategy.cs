using FizzBuzzStrategy.Interfaces;

namespace FizzBuzzStrategy.Strategies
{
    public class StandardStrategy : BaseStrategy, IUpdateStrategy
    {
        public StandardStrategy(int numberToUpdate) 
            : base(numberToUpdate)
        {
        }

        public override string UpdateValue()
        {
            return this._numberToUpdate.ToString();
        }
    }
}