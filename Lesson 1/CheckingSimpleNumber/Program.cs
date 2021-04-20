using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recursion;

namespace CheckingSimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Enter the number");
             int n = Convert.ToInt32 (Console.ReadLine());
             if (CheckingSimpleNumber(n)) { Console.WriteLine("The number is simple"); }
             else { Console.WriteLine("The number is not simple"); };
             Console.ReadKey(); */

            var testCasePos1 = new TestCase()
            {
                n = 3,
                Expected1 = true ,
                ExpectedException = null
            };

            var testCasePos2 = new TestCase()
            {
                n = 4,
                Expected1 = false,
                ExpectedException = null
            };


            var testCasePos3 = new TestCase()
            {
                n = 10,
                Expected1 = false,
                ExpectedException = null
            };

            TestCase.Test(testCasePos1, CheckingSimpleNumber);
            Console.WriteLine();

            TestCase.Test(testCasePos2, CheckingSimpleNumber);
            Console.WriteLine();

            TestCase.Test(testCasePos3, CheckingSimpleNumber);            
            Console.WriteLine();

            Console.ReadLine();

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
