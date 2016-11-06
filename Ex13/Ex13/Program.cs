using System;
ㅕ냐ㅜㅎ
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    delegate void MyDelegte(int a);

    class Program
    {
        delegate int MyDelegate(int a, int b);

        static void Main(string[] args)
        {
            MyDelegate Callback;

            Market market = new Market();
            market.CustomerEvent += new MyDelegte(int a)
            {
                if (a == 30)
                Console.WriteLine("축하합니다! 30번째 고객 이벤트에 당첨 되었습니다.");

            };

            for (int nCustomNo = 0; nCustomNo < 100; nCustomNo += 10)
            {
                market.BuySomething(nCustomNo);
            }

            Callback = delegate(int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(Callback(3, 4));

            Callback = delegate(int a, int b)
            {
                return a - b;
            };

            Console.WriteLine(Callback(7, 5));
            Console.Read();
        }
    }

    class Market
    {
        public event MyDelegte CustomerEvent;

        public void BuySomething( int CustomerNo )
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }
}
