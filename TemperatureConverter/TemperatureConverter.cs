using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal  static class TemperatureConverter
    {
        public static double FahrenheitToCelsius(int faranheit)
        {
        return (faranheit - 32) * 5 / 9;


    }
    public static double CelsiusToFahrenheit(int celsius)
    {
        return (celsius * 9) / 5 + 32;
    }

}

