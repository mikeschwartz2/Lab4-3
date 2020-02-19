using System;
using Xunit;
using Lab4_3;

namespace PrimeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        [InlineData(8, 19)]
        [InlineData(9, 23)]
        [InlineData(10, 29)]
        public void PrimeTest(int a, int expected)
        {
            int result = PrimeNumbers.GetPrime(a);
            Assert.Equal(expected, result);
        }
    }
}
