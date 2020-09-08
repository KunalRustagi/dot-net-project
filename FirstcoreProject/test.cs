using System;
using Xunit;
using FirstLib;

namespace FirstcoreProject{
    public class test{
        [Fact]
        public void TestName()
        {
            var obj = new Addition();
            Assert.Equal(obj.display(),"ok");
        }
    }
}