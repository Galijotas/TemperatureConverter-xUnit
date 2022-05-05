using System;
using Xunit;
using TemperatureConverterClass;

namespace TemperatureConverterTests
{
    public class TemperatureConverterTests
    {
        [Theory]
        [InlineData(0,32)]
        [InlineData(-17.78, 0)]
        public void Celsius_ConvertToFahrenheit(double temperature, double expected)
        {
            double actual = TemperatureConverter.CelsiusToFahrenheit(temperature);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 273)]
        [InlineData(-273, 0)]
        public void Celsius_ConvertToKelvin(double temperature, double expected)
        {
            double actual = TemperatureConverter.CelsiusToKelvin(temperature);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(273, 0)]
        [InlineData(0, -273)]
        public void Kelvin_ConvertToCelsius(double temperature, double expected)
        {
            double actual = TemperatureConverter.KelvinToCelsius(temperature);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, -460)]
        [InlineData(255.3, 0)]
        public void Kelvin_ConvertToFahrenheit(double temperature, double expected)
        {
            double actual = TemperatureConverter.KelvinToFahrenheit(temperature);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, -17.8)]
        [InlineData(32, 0)]
        public void Fahrenheit_ConvertToCelcius(double temperature, double expected)
        {
            double actual = TemperatureConverter.FahrenheitToCelsius(temperature);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-460, 0)]
        [InlineData(0, 255.3)]
        public void Fahrenheit_ConvertToKelvin(double temperature, double expected)
        {
            double actual = TemperatureConverter.FahrenheitToKelvin(temperature);
            Assert.Equal(expected, actual);
        }

    }
}
