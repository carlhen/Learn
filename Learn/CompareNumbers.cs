using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class CompareNumbers
    {
        static void Main(string[] args)
        {
            Program p = new Program();//constructor; makes a new object of type Program
            int result;
            int num1;
            int num2;
            Console.WriteLine("input num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input num2");
            num2 = int.Parse(Console.ReadLine());
            
            

            
            //CH, how to call the method below? You write some code!
        }

        /// <summary>
        /// Compares two numbers
        /// </summary>
        /// <param name="num1">Number to be compared</param>
        /// <param name="num2">Number to be compared</param>
        /// <returns>The max of two numbers</returns>
        int FindMax(int num1, int num2)
        {
            /* local variable declaration */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }
    }
}
