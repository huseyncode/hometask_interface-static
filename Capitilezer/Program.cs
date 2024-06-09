class Program
{
    static void Main(string[] args)
    {
        string str = "hello, world!";
        string capitalized = str.Capitalize();
        Console.WriteLine($"Original string: {str}");
        Console.WriteLine($"Capitalized string: {capitalized}");
    }
}
public static class StringExtensions
{
    public static string Capitalize(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }

        char[] charArray = str.ToCharArray();
        charArray[0] = char.ToUpper(charArray[0]);
        return new string(charArray);
    }
}
