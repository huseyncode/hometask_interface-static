using System.Linq.Expressions;

public enum Months
{
    Yanvar=1,
    Fevral,
    Mart,
    Aprel,
    May,
    İyun,
    İyul,
    Avqust,
    Sentyabr,
    Oktyabr,
    Noyabr,
    Dekabr 
}

class Program
{
    static void Main(string[] args)
    {
        int month = Convert.ToInt32(Console.ReadLine());


        switch (month)
        {
            case (int)Months.Dekabr:
                Console.WriteLine($"{Months.Dekabr} qış ayidir");
                break;
            case (int)Months.Yanvar:
                Console.WriteLine($"{Months.Yanvar} qış ayidir");
                break;
            case (int)Months.Fevral:
                Console.WriteLine($"{Months.Fevral} qış ayidir");
                break;
            case (int)Months.Mart:
                Console.WriteLine($"{Months.Mart} bahar ayidir");
                break;
            case (int)Months.Aprel:
                Console.WriteLine($"{Months.Aprel} bahar ayidir");
                break;
            case (int)Months.May:
                Console.WriteLine($"{Months.May} bahar ayidir");
                break;
            case (int)Months.İyun:
                Console.WriteLine($"{Months.İyun} yay ayidir");
                break;
            case (int)Months.İyul:
                Console.WriteLine($"{Months.İyul} yay ayidir");
                break;
            case (int)Months.Avqust:
                Console.WriteLine($"{Months.Avqust} yay ayidir");
                break;
            case (int)Months.Sentyabr:
                Console.WriteLine($"{Months.Sentyabr} payız ayidir");
                break;
            case (int)Months.Oktyabr:
                Console.WriteLine($"{Months.Oktyabr} payız ayidir");
                break;
            case (int)Months.Noyabr:
                Console.WriteLine($"{Months.Noyabr} payız ayidir");
                break;
            default:
                Console.WriteLine("False");
                break;
        }
    }

        
}
