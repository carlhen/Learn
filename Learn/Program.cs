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
            age = p.ConsoleNumberWithoutDecimals(loops, age);
            Console.WriteLine(age);
        end:
            Console.ReadLine();
        }

        int ConsoleNumberWithoutDecimals(int atempt, int age)
        {
            for (int i = 0; i < atempt; i++)
            {
                bool ageCheck;
                Console.WriteLine("Type a number without decimals");
                ageCheck = int.TryParse(Console.ReadLine(), out age);
                if (ageCheck == true)
                {
                    return age;
                    break;
                }
            }
            return 0;
            Console.Clear();
            Console.WriteLine("Do you even know what decimals is? I'm out of here.");
        }
    }
}
