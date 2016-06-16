using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzStrategy
{
    public class FizzBuzzShould
    {
        [Fact]
        public void Return_String_Representation_Of_Input_Int()
        {
            var program = new Program();

            var output1 = program.Convert(1);
            var output2 = program.Convert(2);
            
            Assert.Equal("1", output1);
            Assert.Equal("2", output2);
        }

        [Fact]
        public void Return_Fizz_For_Number_Divisible_By_Three()
        {
            var program = new Program();
            var output = program.Convert(3);
            Assert.Equal("Fizz", output);
        }

        [Fact]
        public void Return_Buzz_For_Number_Divisible_By_Five()
        {
            var program = new Program();
            var output = program.Convert(5);
            Assert.Equal("Buzz", output);
        }

        [Fact]
        public void Return_FizzBuzz_For_Number_Divisible_By_Three_And_Five()
        {
            var program = new Program();
            var output = program.Convert(15);
            Assert.Equal("FizzBuzz", output);
        }
    }
}
