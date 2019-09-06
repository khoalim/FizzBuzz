using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_for_1()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(1);

            Assert.Equal("1", result);

        }
    }
}
