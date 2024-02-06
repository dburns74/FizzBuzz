

using FizzBuzz.Classes;
using FizzBuzz.Interface;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(6)]
        public void NumberDivisibleBy3_Not5_ReturnsFizz(int number)
        {
            INumberChecker checker = (INumberChecker) new FizzRule();
            bool IsValid = checker.IsValid(number);
            Assert.True(IsValid);

            var actualResult = checker.GetResultString();
            Assert.Equal("Fizz", actualResult);
        }
    }
}
