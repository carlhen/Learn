using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
   class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            int loops = 3;
            Program p = new Program();
            age = p.NumberWithoutDecimals(loops, age);
            Console.WriteLine(age);
            Console.ReadLine();
        }

        int ConsoleNumberWithoutDecimals(int atempt, int age)
        {
            Console.WriteLine("Type a number without decimals");
            for (int i = 0; i < atempt; i++)
            {
                bool ageCheck;
                ageCheck = int.TryParse(Console.ReadLine(), out age);
                if (ageCheck == true)
                {
                    return age;
                    break;
                }
                else
                    Console.WriteLine("Try again, and remmember: Do not type a number WITH decimals");
            }
            return 0;
        }
    }
}
