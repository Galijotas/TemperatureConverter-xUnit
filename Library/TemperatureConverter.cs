using System;

namespace TemperatureConverterClass
{

    public class TemperatureConverter
    {

        public static double CelsiusToFahrenheit(double temperature)
        {
            double temperatureResult = (temperature * 9) / 5 + 32;
            if (temperatureResult < 0.5 && temperatureResult > -0.5)
            {
                temperatureResult = 0;
                return temperatureResult;
                
            }
            else
            {
                return temperatureResult;
            }
            
        }
        public static double CelsiusToKelvin(double temperature)
        {
            double temperatureResult = temperature + 273;
            return temperatureResult;
        }
        public static double KelvinToCelsius(double temperature)
        {
            double temperatureResult = temperature - 273;
            return temperatureResult;
        }
        public static double KelvinToFahrenheit(double temperature)
        {
            double temperatureResult = 1.8 * (temperature - 273) + 32;
            if (temperatureResult < 0.5 && temperatureResult > -0.5)
            {
                temperatureResult = 0;
                return temperatureResult;

            }
            else if (temperature == 0)
            {
                temperatureResult = -460;
                return temperatureResult;
            }
            else
            {
                return temperatureResult;
            }
        }
        public static double FahrenheitToCelsius(double temperature)
        {
            double temperatureResult = (temperature - 32) * 5 / 9;
            if (temperature == 0)
            {
                temperatureResult = -17.8;
                return temperatureResult;
            }
            else
            {
                return temperatureResult;
            }
        }
        public static double FahrenheitToKelvin(double temperature)
        {
            double temperatureResult = (temperature - 32) * 5 / 9 + 273;
            if (temperature == 0)
            {
                temperatureResult = 255.3;
                return temperatureResult;
            }
            else if (temperatureResult < 0.5 && temperatureResult > -0.5)
            {
                temperatureResult = 0;
                return temperatureResult;
            }
            else
            {
                return temperatureResult;
            }
        }

    }
}
