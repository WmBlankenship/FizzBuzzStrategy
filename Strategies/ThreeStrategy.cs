using FizzBuzzStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzStrategy.Strategies
{
    public class ThreeStrategy : IUpdateStrategy
    {
        public string UpdateValue(int inputNumber)
        {
            return "Fizz";
        }
    }
}
