

using FizzBuzz.Interface;

namespace FizzBuzz.Classes
{
    internal class BuzzRule : INumberChecker
    {
        public string GetResultString()
        {
            return "Buzz";
        }

        public bool IsValid(int number)
        {
            if ((number % 5 == 0) && (number % 3 != 0))
            {
                return true;
            }
            return false;
        }
    }
}
