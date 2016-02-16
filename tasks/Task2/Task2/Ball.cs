using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ball
    {
        public int preis;
        public int size;
        private string color;

        public Ball()
        {
            preis = 1;
            size = 5;
        }
        public Ball(int preis)
        {
            this.preis = preis;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }

    }
}
