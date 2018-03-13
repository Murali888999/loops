using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class forloop7
    {
        static void Main(string[] args)
        {
        ineligible:
            Console.WriteLine("you are not eligible for vote!!!!!");

            Console.WriteLine("enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("you are eligible for vote");
            }
            Console.ReadKey();
        }

    }
}