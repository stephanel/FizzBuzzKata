using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        const string Fizz = "Fizz";
        const string Buzz = "Buzz";

        public string Convert(int number)
        {
            string result = GetFizzWhenModuloThreeEqualsZeroOrEmpty(number)
                + GetBuzzWhenModuloFiveEqualsZeroOrEmpty(number);

            if(string.IsNullOrWhiteSpace(result))
            {
                result = number.ToString();
            }

            return result;
        }

        private string GetFizzWhenModuloThreeEqualsZeroOrEmpty(int number)
        {
            return number % 3 == 0 ? Fizz : string.Empty;
        }

        private string GetBuzzWhenModuloFiveEqualsZeroOrEmpty(int number)
        {
            return number % 5 == 0 ? Buzz : string.Empty;
        }
    }
}
