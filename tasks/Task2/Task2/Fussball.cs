using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Fussball : IBall
    {

        public string m_Color { get; set; }
        public int m_Preis { get; set; }
        public int m_Size { get; set; }

        public Fussball()
        {
            m_Preis = 1;
            m_Size = 4;
        }
        public Fussball(int preis)
        {
            m_Preis = preis;
            m_Size = 4;
        }

        #region IBall Implementation
        public string Color => m_Color;
        public int Preis => m_Preis;
        public int Size => m_Size;

        public void SetAttributes(string color, int preis, int size)
        {
            m_Color = color;
            m_Preis = preis;
            m_Size = 4;
            Console.WriteLine("Attribute überschrieben - Größe ist fixiert!");
        }
        #endregion
    }
}
