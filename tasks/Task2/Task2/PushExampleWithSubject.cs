using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    public static class PushExampleWithSubject
    {
        public static void Run(IItem[] items)
        {
            var subjects = new Subject<IItem>();

            subjects.Subscribe(x => Console.WriteLine($"Neuer Ball: {x.Description}"));
            subjects.Subscribe(x => Console.WriteLine($"Preis: {x.Price.Amount} {x.Price.Unit}"));

            var t = new Thread(() =>
            {
                foreach (var x in items)
                {
                    Thread.Sleep(250);
                    subjects.OnNext(x);
                }
            });
            t.Start();
        }
    }
}