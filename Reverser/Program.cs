class Program
{
    static void Main(string[] args)
    {
        string str = "Hello, World!";
        string reversed = str.Reverse();
        Console.WriteLine($"Original string: {str}");
        Console.WriteLine($"Reversed string: {reversed}");
    }
}
public static class StringExtensions
{
    public static string Reverse(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
