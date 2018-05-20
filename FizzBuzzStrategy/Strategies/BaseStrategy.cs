using FizzBuzzStrategy.Interfaces;

namespace FizzBuzzStrategy.Strategies
{
    public abstract class BaseStrategy : IUpdateStrategy
    {
        protected int _numberToUpdate;

        public BaseStrategy(int numberToUpdate)
        {
            this._numberToUpdate = numberToUpdate;
        }

        public abstract string UpdateValue();
    }
}
