using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Fussball : IItem
    {

        public string m_description { get; set; }
        public Price m_price { get; set; }
        public int m_Size { get; set; }

        public Fussball()
        {
            m_description = "";
            m_price = new Price(0, Currency.EUR);
            m_Size = 4;
        }
        public Fussball(string description,decimal amount, Currency ccy)
        {
            m_description = description;
            m_price = new Price(amount, ccy);
            m_Size = 4;
        }

        #region IBall Implementation
        public string Description => m_description;
        public Price Price => m_price;

        public void SetAttributes(string description, decimal amount, Currency ccy, int size)
        {
            m_description = description;
            m_price = new Price(amount, ccy);
            m_Size = size;
            Console.WriteLine("Attribute überschrieben - Größe ist fixiert!");
        }
        #endregion
    }
}
