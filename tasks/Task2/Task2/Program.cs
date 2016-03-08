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

            var currency = Currency.USD;
            foreach (var x in items)
            {
                Console.WriteLine($"{x.Description.Truncate(50),-50} {x.Price.ConvertTo(currency).Amount,8:0.00} {currency}");
            }

            SerializationExample.Run(items);

        }
    }
}
