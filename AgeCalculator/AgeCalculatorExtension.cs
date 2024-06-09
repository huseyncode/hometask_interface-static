using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class AgeCalculatorExtension
{
    public static void CalculateAge (int birthYear,int Age)
    {
       
        Age = DateTime.Now.Year - birthYear;
        Console.WriteLine(Age);

    }
}
