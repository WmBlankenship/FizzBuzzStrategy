using FizzBuzzStrategy.Factories;
using FizzBuzzStrategy.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzStrategy.Tests
{
    [TestClass]
    public class FizzBuzzShould
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void Return_String_Representation_Of_Input_Int(int number)
        {
            var factory = new UpdateStrategyFactory();
            var strategy = factory.Create(number);

            var conversionService = new NumberConversionService(strategy);
            var output = conversionService.Convert();

            Assert.AreEqual(number.ToString(), output);
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(18)]
        public void Return_Fizz_For_Number_Divisible_By_Three(int number)
        {
            var factory = new UpdateStrategyFactory();
            var strategy = factory.Create(number);

            var conversionService = new NumberConversionService(strategy);
            var output = conversionService.Convert();

            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(20)]
        public void Return_Buzz_For_Number_Divisible_By_Five(int number)
        {
            var factory = new UpdateStrategyFactory();
            var strategy = factory.Create(number);

            var conversionService = new NumberConversionService(strategy);
            var output = conversionService.Convert();

            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(45)]
        public void Return_FizzBuzz_For_Number_Divisible_By_Three_And_Five(int number)
        {
            var factory = new UpdateStrategyFactory();
            var strategy = factory.Create(number);

            var conversionService = new NumberConversionService(strategy);
            var output = conversionService.Convert();

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}