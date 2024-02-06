

using FizzBuzz.Classes;
using FizzBuzz.Interface;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void NumberDivisibleBy3_Not5_ReturnsFizz(int number)
        {
            INumberChecker checker = (INumberChecker) new FizzRule();
            bool IsValid = checker.IsValid(number);
            Assert.True(IsValid);

            var actualResult = checker.GetResultString();
            Assert.Equal("Fizz", actualResult);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void NumberDivisibleBy5_Not3_ReturnsBuzz(int number)
        {
            INumberChecker checker = (INumberChecker)new BuzzRule();
            bool IsValid = checker.IsValid(number);
            Assert.True(IsValid);

            var actualResult = checker.GetResultString();
            Assert.Equal("Buzz", actualResult);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void NumberDivisibleBy3_And5_ReturnsFizzBuzz(int number)
        {
            INumberChecker checker = (INumberChecker)new FizzBuzzRule();
            bool IsValid = checker.IsValid(number);
            Assert.True(IsValid);

            var actualResult = checker.GetResultString();
            Assert.Equal("FizzBuzz", actualResult);
        }
    }
}
