using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new IItem[]
            {
                new Fussball("Adidas Z100", 30, Currency.EUR),
                new Fussball("Nike Tiempo 2", 40, Currency.EUR),
                new Fussball("Adidas E200", 45, Currency.EUR),
                new Fussball("Puma AD100", 35, Currency.EUR),
                new Ball("Ball1"),
                new Ball("Teurer Ball", 1000, Currency.EUR),
                new Ball("Normaler Ball", 10, Currency.EUR),
            };

            foreach (var x in items)
            {
                Thread.Sleep(250);
                Console.WriteLine("Price of {0} is {1} {2}", x.Description, x.Price.Unit, x.Price.Amount);
            }

            SerializationExample.Run(items);
            PushExampleWithSubject.Run(items);

        }
    }
}
