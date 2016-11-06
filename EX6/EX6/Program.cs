using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6
{
    class Program
    {
        static double Square(double arg)
        {
            return arg * arg;
        }

        static void Mean(double a, double b, double c, double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }

        static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void Plus(double dA, double dB, out double Result)
        {
            Result = dA + dB;
        }

        static void Main(string[] args)
        {

            double dmean = 0;
            int nA = 3;
            int nB = 4;
            int nResultA = 0;

            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("6Ex1 결과 : {0}", Square(arg));

            Mean(1, 2, 3, 4, 5, ref dmean);

            Console.WriteLine("6Ex2 결과 : {0}", dmean);

            Plus(nA, nB, out nResultA);

            Console.WriteLine("6Ex3 결과 : {0} + {1} = {2}", nA, nB, nResultA);

            double dx = 2.4;
            double dy = 3.1;
            double dResultB = 0;

            Plus(dx, dy, out dResultB);

            Console.WriteLine("6Ex3 결과 : {0} + {1} = {2}", dx, dy, dResultB);

            Console.Read();
        }


    }
}
