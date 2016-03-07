using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ball : IItem
    {

        public string m_description { get; set; }
        public Price m_price { get; set; }

        public Ball()
        {
            m_description = "";
            m_price = new Price(1, Currency.EUR);
        }
        public Ball(string description)
        {
            m_description = description;
            m_price = new Price(1, Currency.EUR);
        }
        public Ball(string description, decimal amount, Currency ccy)
        {
            m_description = description;
            m_price = new Price(amount, ccy);
        }

        #region IBall Implementation
        public string Description => m_description;
        public Price Price => m_price;

        public void SetAttributes(string description, decimal amount, Currency ccy)
        {
            m_description = description;
            m_price = new Price(amount, ccy);
            Console.WriteLine("Attribute überschrieben!");
        }
        #endregion
    }
}
