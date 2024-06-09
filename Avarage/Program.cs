public static class ArrayExtensions
{
    public static double Average(this int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum / array.Length;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");
    }
}
