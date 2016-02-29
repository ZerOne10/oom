using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IBall
    {
        string Color { get; }
        int Preis { get; }
        int Size { get; }

        void SetAttributes(string color, int preis, int size);
        
    }
}
