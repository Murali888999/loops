using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class forloop_3
    {
        static void Main(string[] args)
        {
            for(int i =1; i < 10; i++)
            {
                Console.WriteLine(i);
                if ( i == 6)
                {
                    break;
                }
               
            }
            Console.ReadKey();
        }
    }
}
