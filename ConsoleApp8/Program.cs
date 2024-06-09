using Calculator;

namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int a = 10;
        int b = 2;

        Console.WriteLine($"Add: {calculator.Add(a, b)}");
        Console.WriteLine($"Subtract: {calculator.Subtract(a, b)}");
        Console.WriteLine($"Multiply: {calculator.Multiply(a, b)}");
        Console.WriteLine($"Divide: {calculator.Divide(a, b)}");
    }
}
