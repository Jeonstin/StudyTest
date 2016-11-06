using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void nMulti(int[][] nA, int[][] nB, int[][] nResult)
        {

            nResult[0][0] = nA[0][0] * nB[0][0] + nA[0][1] * nB[1][0];
            nResult[0][1] = nA[0][0] * nB[0][1] + nA[0][1] * nB[1][1];
            nResult[1][0] = nA[1][0] * nB[0][0] + nA[1][1] * nB[1][0];
            nResult[1][1] = nA[1][0] * nB[0][1] + nA[1][1] * nB[1][0];

        }

        static void Main(string[] args)
        {
            int[][] nA = new int[2][];

            nA[0] = new int[2] { 3, 2 };
            nA[1] = new int[2] { 1, 4 };

            int[][] nB = new int[2][];
            nB[0] = new int[2] { 9, 2 };
            nB[1] = new int[2] { 1, 7 };

            int[][] nResult = new int[2][];
            nResult[0] = new int[2];
            nResult[1] = new int[2];

            nMulti(nA, nB, nResult);

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                { 
                    Console.WriteLine("Ex10-2 : 행렬 값 : {0}", nResult[i][j]);
                }
            }
            
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.WriteLine("Ex10-3 : {0}", stack.Pop());

            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);


            while(que.Count > 0)
            {
                Console.WriteLine("Ex10-4 : {0}", que.Dequeue());
            }

            Hashtable ht = new Hashtable();

            ht["회사"] = "MicroSoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("Ex10-5 = 회사 : {0}", ht["회사"]);
            Console.WriteLine("Ex10-5 = URL : {0}", ht["URL"]);

            Console.Read();

        }
    }
}
