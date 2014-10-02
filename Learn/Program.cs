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
            Console.WriteLine("Type a number without decimals");
            string ageIn = Console.ReadLine();
            age = p.NumberWithoutDecimals(ageIn, loops, age);
            Console.WriteLine(age);
            Console.ReadLine();
        }
        int NumberWithoutDecimals(string agetemp,int atempt, int age)
        {
            for (int i = 0; i < atempt; i++)
			{
			    bool ageCheck = false;
                ageCheck = int.TryParse(agetemp, out age);
                if (ageCheck == true)
                {
                    return age;
                    break; 
                }
                else
                    Console.WriteLine("Try again, and remmember: Do not type a number WITH decimals"); 
			}
        }
    }
}
