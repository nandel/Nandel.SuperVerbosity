using Shouldly;
using System;
using Xunit;

namespace Nandel.SuperVerbosity.Tests.System
{
    public class IntExtensionsTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(379)]
        public void IsOdd_ReturnTrue(int input)
        {
            input.IsOdd().ShouldBeTrue();
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(378)]
        public void IsOdd_ReturnFalse(int input)
        {
            input.IsOdd().ShouldBeFalse();
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(378)]
        public void IsEven_ReturnTrue(int input)
        {
            input.IsEven().ShouldBeTrue();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(379)]
        public void IsEven_ReturnFalse(int input)
        {
            input.IsEven().ShouldBeFalse();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(5927)]
        [InlineData(42709)]
        public void IsPrime_ReturnTrue(int input)
        {
            input.IsPrime().ShouldBeTrue();
        }

        [Theory]
        [InlineData(1)] // https://primes.utm.edu/notes/faq/one.html
        [InlineData(10)]
        public void IsPrime_ReturnFalse(int input)
        {
            input.IsPrime().ShouldBeFalse();
        }
    }
}
