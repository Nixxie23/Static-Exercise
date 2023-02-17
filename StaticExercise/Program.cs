namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"32 degrees Fahrenheit is {TempConverter.FahrenheitToCelsius(32)} degrees celsius");
            Console.WriteLine($"58 degrees Fahrenheit is {TempConverter.FahrenheitToCelsius(58)} degrees celsius");
            Console.WriteLine($"0 degrees Celsius is {TempConverter.CelsiusToFahrenheit(0)} degrees Fahrenheit");
            Console.WriteLine($"58 degrees Celsius is {TempConverter.CelsiusToFahrenheit(58)} degrees Fahrenheit");
        }
    }
}



