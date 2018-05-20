using FizzBuzzStrategy.Factories;
using FizzBuzzStrategy.Services;
using System;

namespace FizzBuzzStrategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                var factory = new UpdateStrategyFactory();
                var strategy = factory.Create(i);

                var conversionService = new NumberConversionService(strategy);
                var output = conversionService.Convert();

                Console.WriteLine(i);
            }
        }
    }
}
