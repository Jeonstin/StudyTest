using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    interface INameCard
    {
        int age
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
    }

    class NameCard  : INameCard
    {
        public int age
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameCard myCard = new NameCard()
            { age = 24, Name = "상현"};

            Console.WriteLine("9EX1 나이 : {0}", myCard.age);
            Console.WriteLine("9EX2 이름 : {0}", myCard.Name);

            
            var nameCard = new { Name = "박상현", age = 17 };
            Console.WriteLine("이름 : {0}, 나이 {1}", nameCard.Name, nameCard.age);

            var Complex = new { Real = 3, Imaginary = -12 };
            Console.WriteLine("Real : {0}, Imageinary : {1}", Complex.Real, Complex.Imaginary);

            Console.Read();

        }
    }
}

