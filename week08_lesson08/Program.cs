﻿using System;
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

            try
            {
                Console.WriteLine("Enter Numerator: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Numerator: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                //~~==~~==~~==~~ method ~~==~~==~~==~~

                Console.WriteLine("result: " + Divide(firstNumber, secondNumber));
            }
            catch(FormatException)
            {

                Console.WriteLine("ERROR: PLEASE ENTER AN INTEGER");
            }
            catch(OverflowException)
            {
                Console.WriteLine("ERROR: NUMBER IS TOO LONG ");
                Console.WriteLine("PLEASE ENTER AN INTEGER SMALLER THAN 2,147,483,647");
            }

        }
        private static float Divide(int numerator, int denominator)
        {
            try
            {
                float result = Convert.ToSingle(numerator) / Convert.ToSingle(denominator);
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
