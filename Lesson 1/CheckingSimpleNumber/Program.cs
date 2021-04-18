using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingSimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32 (Console.ReadLine());
            if (CheckingSimpleNumber(n)) { Console.WriteLine("The number is simple"); }
            else { Console.WriteLine("The number is not simple"); };
            Console.ReadKey();


        }

        static bool CheckingSimpleNumber(int n)
        {
            int d = 0,
                i = 2;
            while (i < n)
            {
                if (n%i == 0) { d++; };
                i++;
            }
            return (d == 0);
        }
    }
}
