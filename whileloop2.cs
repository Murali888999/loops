using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class whileloop2
    {
        static void Main(string[] args)
        {
            int i = 1;
            
            while(i < 4)
            {
                int j = 1;
                while(j < 5)
                {
                    Console.WriteLine(i +","+ j);
                    j++;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
