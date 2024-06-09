internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        int faranheit = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter temperature in Celsius: ");
        int celcius=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(TemperatureConverter.FahrenheitToCelsius(faranheit));
        Console.WriteLine(TemperatureConverter.CelsiusToFahrenheit(celcius));
    }

    


}