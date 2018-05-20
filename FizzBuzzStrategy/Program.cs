using FizzBuzzStrategy.Factories;
using System;

namespace FizzBuzzStrategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                var output = Convert(i);
                Console.WriteLine(i);
            }
        }

        public static string Convert(int number)
        {
            var factory = new UpdateStrategyFactory();
            var strategy = factory.Create(number);
            return strategy.UpdateValue();
        }
    }
}
