using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);
        [Fact]
        public void GetReturnsShite()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Pile of shite",returnValue.Value);
        }

        [Fact]
        public void Test1()
        {


        }


    }
}
