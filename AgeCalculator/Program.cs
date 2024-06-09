class Program
{
    public static int Age { get; private set; }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter birth year");
        var birthYear= Convert.ToInt32(Console.ReadLine());
        AgeCalculatorExtension.CalculateAge( birthYear,Age);
    }
}