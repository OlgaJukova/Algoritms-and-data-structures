using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Console.WriteLine("Enter the number");
               int n = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Recursion: F("+n+")="+FibRec(n));
               Console.WriteLine("Cycle: F(" + n + ")=" + FibCycle(n));
               Console.ReadKey();*/

            /*  Console.WriteLine("Enter the number");
              int n = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Recursion: F(" + n + ")=" + FibRec(n));
              Console.ReadKey(); */

            var testCasePos1 = new TestCase()
            {
                n=3,
                Expected = 2,
                ExpectedException = null
            };

            var testCasePos2 = new TestCase()
            {
                n = 0,
                Expected = 0,
                ExpectedException = null
            };


            var testCasePos3 = new TestCase()
            {
                n = 10,
                Expected = 55,
                ExpectedException = null
            };

            Test(testCasePos1, FibRec);
            Test(testCasePos1, FibCycle);
            Console.WriteLine(  );

            Test(testCasePos2, FibRec);
            Test(testCasePos2, FibCycle);
            Console.WriteLine();

            Test(testCasePos3, FibRec);
            Test(testCasePos3, FibCycle);
            Console.WriteLine();


            Console.ReadLine();
            

        }


        static int FibRec(int n)
        {
            if (n < 0 || n > 20)
            {                
                throw new ArgumentException("Number must be positive");                       
            };

            int f;
            if (n == 0) { f = 0; }
            else if (n == 1) { f = 1; }
            else { f = FibRec(n - 1) + FibRec(n - 2); };
            return f;

        }

        static int FibCycle(int n)
        {
            if (n < 0 || n > 20)
            {
                throw new ArgumentException("Number must be positive");
            };

            int[] mas = new int[n+1];
            if (n == 0) { return  0; }
            else if (n == 1) { return 1; }
            else 
            {
                mas[0] = 0;
                mas[1] = 1;
                for (int i=2; i<n+1; i++)
                {
                    mas[i] = mas[i - 1] + mas[i - 2];
                }
                return mas[n];
            };
        }

        public class TestCase
        {
            public int n { get; set; }
           
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void Test(TestCase testCase, Func<int, int> function)
        {
            try
            {
                var value = function(testCase.n);

                if (value == testCase.Expected)
                {
                    Console.WriteLine("Test passed");
                }
                else
                {
                    Console.WriteLine("Tast faileds");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    
                    Console.WriteLine("Test passed");
                }
                else
                {
                    Console.WriteLine("Tast faileds");
                } 
            }
        }





    }
}
