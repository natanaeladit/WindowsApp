using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Test
{
    public class TemperatureTest
    {
        [Fact]
        public void Celcius_Convertion()
        {
            double celsius = 13;
            TemperatureViewModel temperatureViewModel = new TemperatureViewModel()
            {
                Celsius = celsius,
            };
            temperatureViewModel.ConvertCommand.Execute(null);
            temperatureViewModel.Kelvin.Should().Be(celsius + 273.15);
            temperatureViewModel.Fahrenheit.Should().Be((celsius * 9.0 / 5.0) + 32);
        }
    }
}
