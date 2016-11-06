using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] nArray = new int[10];
                

                for(int i = 0; i < 11; i++)
                {
                    nArray[i] = i;
                    Console.WriteLine(i);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.Read();
        }
    }
}
