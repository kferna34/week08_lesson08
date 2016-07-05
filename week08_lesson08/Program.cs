using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08_lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Enter Numerator: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Numerator: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            //~~==~~==~~==~~ method ~~==~~==~~==~~

            Console.WriteLine("result: " + Divide(firstNumber, secondNumber));

        }
        private static int Divide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                return result;
            }
            catch (Exception exception)
            {

                Console.WriteLine("Error: " + exception.Message);
                return 0;
            }


        }
    }
}
