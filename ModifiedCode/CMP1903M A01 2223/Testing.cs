using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        public Testing() 
        {
            int val;
            int choice;
            int amount;
            bool isShuffeled;


            Pack pack = new Pack();
            Validation validation = new Validation();

            Console.WriteLine($"Deck of cards has been created. \nHow would you like to shuffel it? \n1.Fisher-Yates Shuffle \n2.Riffle Shuffle\n3.No shuffel");
            val = validation.IntValidation(3);

            isShuffeled = Pack.shuffleCardPack(val);
            if (isShuffeled == true)
            {
                Console.WriteLine("1.Deal one card.\n2.Deal specified amount of cards");
                choice = validation.IntValidation(2);

                if (choice == 1)
                {
                    Card card = Pack.deal();
                    card.show();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Please state the amount of cards to deal");
                    amount = validation.IntValidation(52);
                    List<Card> Cardslist = Pack.dealCard(amount);
                    foreach (Card cardS in Cardslist)
                    {
                        cardS.show();
                    }
                }
            }
            else
            {
                //dont see how it will get here 
                Console.WriteLine("Deck could not be shuffeled");
            }
        }    

    }
}
