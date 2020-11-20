using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using Xunit;

namespace Nandel.SuperVerbosity.Tests.System.Collections.Generic
{
    public class CollectionExtensionsTests
    {
        [Theory]
        [InlineData("asd", "asd")]
        [InlineData(1, 1)]
        [InlineData(1L, 1L)]
        public void AddIfNotExists_OnMultipleAddOfSameItem_ShouldNotDuplicateTheItemInTheList(object item1, object item2)
        {
            var list = new List<object>();

            list.AddIfNotExists(item1);
            list.AddIfNotExists(item2);

            item1.Equals(item2).ShouldBeTrue();
            list.Count.ShouldBe(1);
        }
    }
}
