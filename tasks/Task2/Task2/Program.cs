using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Ball();

            Console.WriteLine("Size of ball is " + a.size);

            a.SetColor("black");

            Console.WriteLine("Color of ball is " + a.GetColor());

        }
    }
}
