using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteração
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<10; i++)
            {
                //Console.WriteLine(i);
                if (i == 7)	

                {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }


            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine(i);
            }


            Console.Read();
        }
    }
}
