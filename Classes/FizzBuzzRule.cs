using FizzBuzz.Interface;

namespace FizzBuzz.Classes
{
    internal class FizzBuzzRule : INumberChecker
    {
        public string GetResultString()
        {
            return "FizzBuzz";
        }

        public bool IsValid(int number)
        {
            if (number % 15 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
