using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double convertedToCelsius = (fahrenheit - 32) * 5/9;
            return convertedToCelsius;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            double convertedToFahrenheit = (celsius * 9 / 5) + 32;
            return convertedToFahrenheit;
        }
    }
}

//Now create a static class called TempConverter. The class should have at least 2 methods,
//one called FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit
//which will also require a double as a parameter and return a double.
//To convert temperatures in degrees Fahrenheit to Celsius, subtract 32 and multiply
//by .5556 (or 5/9). To convert temperatures in degrees Celsius to Fahrenheit, multiply by 1.8 (or 9/5) and add 32.
//Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!