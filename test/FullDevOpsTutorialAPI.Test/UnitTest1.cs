using System;
using Xunit;
using FullDevOpsTutorialAPI.Controllers;

namespace FullDevOpsTutorialAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Jeremy Lai", returnValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
