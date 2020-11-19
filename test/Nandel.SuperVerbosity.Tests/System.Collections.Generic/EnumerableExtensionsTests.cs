using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;

namespace Nandel.SuperVerbosity.Tests.System.Collections.Generic
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void IsEmpty_OnNewList_ReturnTrue()
        {
            new List<int>().IsEmpty().ShouldBeTrue();
        }

        [Fact]
        public void IsEmpty_OnNull_ThrowArgumentNullException()
        {
            Should.Throw<ArgumentNullException>(() => (null as IEnumerable<int>).IsEmpty());
        }

        [Fact]
        public void IsEmpty_ListWithItens_ReturnFalse()
        {
            new List<string> { "A random item" }.IsEmpty().ShouldBeFalse();
        }

        [Fact]
        public void IsNullOrEmpty_OnNewList_ReturnTrue()
        {
            new List<int>().IsNullOrEmpty().ShouldBeTrue();
        }

        [Fact]
        public void IsNullOrEmpty_OnNull_ReturnTrue()
        {
            (null as IEnumerable<int>).IsNullOrEmpty().ShouldBeTrue();
        }

        [Fact]
        public void IsNullOrEmpty_ListWithAnyItems_ReturnFalse()
        {
            new List<string> { "A random item" }.IsNullOrEmpty().ShouldBeFalse();
        }
    }
}
