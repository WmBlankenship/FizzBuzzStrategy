using FizzBuzzStrategy.Interfaces;

namespace FizzBuzzStrategy.Services
{
    public class NumberConversionService : INumberConversionService
    {
        private IUpdateStrategy _updateStrategy;

        public NumberConversionService(IUpdateStrategy updateStrategy)
        {
            _updateStrategy = updateStrategy;
        }

        public string Convert()
        {
            return _updateStrategy.UpdateValue();
        }
    }
}
