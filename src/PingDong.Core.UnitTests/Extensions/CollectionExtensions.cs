using System.Collections.Generic;
using Xunit;

namespace PingDong.Linq
{
    public class CollectionExtensionsTests
    {
        [Fact]
        public void Null_ShouldReturn_True()
        {
            List<string> source = null;

            Assert.True(source.IsNullOrEmpty());
        }

        [Fact]
        public void Empty_ShouldReturn_True()
        {
            var source = new List<string>();

            Assert.True(source.IsNullOrEmpty());
        }

        [Fact]
        public void List_ShouldReturn_True()
        {
            var source = new List<string> { "Test" };

            Assert.False(source.IsNullOrEmpty());
        }
    }
}
