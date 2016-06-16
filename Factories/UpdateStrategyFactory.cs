using FizzBuzzStrategy.Interfaces;
using FizzBuzzStrategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzStrategy.Factories
{
    public class UpdateStrategyFactory : IUpdateStrategyFactory
    {
        public IUpdateStrategy Create(int inputNumber)
        {
            if (inputNumber % 15 == 0)
            {
                return new ThreeAndFiveStrategy();
            }
            else if (inputNumber % 5 == 0)
            {
                return new FiveStrategy();
            }
            else if (inputNumber % 3 == 0)
            {
                return new ThreeStrategy();
            }
            else
            {
                return new StandardStrategy();
            }
        }
    }
}
