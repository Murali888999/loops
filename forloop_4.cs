using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class forloop_4
    {
        static void Main(string[] args)
        {
            for(int i =1;i<4;i++)
            {
                for(int j=1;j<4;j++)
                {
                    if(i == 3 && j == 4)
                    {                  
                        break;
                    }
                    Console.WriteLine(i + "," + j);
                }
                Console.ReadKey();
            }

        }
    }
}
