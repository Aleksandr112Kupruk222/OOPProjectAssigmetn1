using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Card
    {

        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int s,int v) 
        {
            Suit = s;
            Value = v;
           
        }
        public void show() 
        {
            Console.WriteLine($"{Suit},{Value}");
        }
    }
}
