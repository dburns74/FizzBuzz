
using FizzBuzz.Interface;

namespace FizzBuzz.Classes
{
    public class FizzRule : INumberChecker
    {
        public string GetResultString()
        {
            return "Fizz";
        }

        public bool IsValid(int number)
        {
            if ((number % 3 == 0) && (number % 5 != 0))
            {
                return true;
            }
           return false;
        }
    }
}
