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
            var items = new IBall[]
            {
                new Ball(10),
                new Ball(20),
                new Ball(30),
                new Ball(40),
                new Fussball(10),
                new Fussball(20),
                new Fussball(30),
                new Fussball(40)
            };
            Random rnd = new Random();

            foreach (var i in items)
            {
                i.SetAttributes("Rot", rnd.Next(1,100), 5);
            }

        }
    }
}
