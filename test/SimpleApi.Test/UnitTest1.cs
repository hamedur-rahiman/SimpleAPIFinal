using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleApi.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();



        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = controller.Get(1);

            Assert.Equal("HR", returnValue.Value);
        }


        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {

        }

    }
}
