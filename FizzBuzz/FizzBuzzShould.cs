using NFluent;
using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(12, "Fizz")]
        [InlineData(15, "FizzBuzz")]
        public void Convert_Integer_To_String(int input, string expected)
        {
            Check.That(new FizzBuzz().Convert(input)).IsEqualTo(expected);
        }
    }
}
