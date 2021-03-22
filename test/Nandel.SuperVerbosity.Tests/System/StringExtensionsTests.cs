using Xunit;

namespace Nandel.SuperVerbosity.Tests.System
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("word")]
        [InlineData(null)]
        public void IsNullOrEmpty(string value)
        {
            Assert.Equal(value.IsNullOrEmpty(), string.IsNullOrEmpty(value));
        }

        [Fact]
        public void IsNullOrEmpty_Empty()
        {
            Assert.Equal(string.IsNullOrEmpty(string.Empty), string.IsNullOrEmpty(string.Empty));
        }

        [Theory]
        [InlineData("word")]
        [InlineData(null)]
        public void IsNullOrWhiteSpace(string value)
        {
            Assert.Equal(value.IsNullOrWhiteSpace(), string.IsNullOrWhiteSpace(value));
        }

        [Fact]
        public void IsNullOrWhiteSpace_Empty()
        {
            Assert.Equal(string.IsNullOrWhiteSpace(string.Empty), string.IsNullOrWhiteSpace(string.Empty));
        }
    }
}
