using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing : Validation
    {
        public Testing()
        {
            // Declare variables
            int val;
            int choice;
            int amount;
            bool isShuffled;

            // Create new Pack and Validation objects
            Pack pack = new Pack();
            

            // Prompt user to select shuffle method
            val = IntValidation("Deck of cards has been created. \nHow would you like to shuffle it? \n1.Fisher-Yates Shuffle \n2.Riffle Shuffle\n3.No shuffle", 0, 3);

            // Shuffle deck based on user's choice
            isShuffled = Pack.shuffleCardPack(val);

            // If deck was successfully shuffled, prompt user to deal one or a specified number of cards
            if (isShuffled == true)
            {
                choice = IntValidation("1.Deal one card.\n2.Deal specified amount of cards", 0, 2);

                // If user chooses to deal one card, deal one card and show it to the user
                if (choice == 1)
                {
                    Card card = Pack.deal();
                    card.show();
                }
                // If user chooses to deal a specified number of cards, prompt user to enter the number of cards and deal that number of cards, showing each card to the user
                else if (choice == 2)
                {
                    amount = IntValidation("Please state the amount of cards to deal", 0, 52);
                    List<Card> Cardslist = Pack.dealCard(amount);
                    foreach (Card cardS in Cardslist)
                    {
                        cardS.show();
                    }
                }
            }
            // If deck could not be shuffled, display error message
            else
            {
                Console.WriteLine("Deck could not be shuffled");
            }
        }
    }
}
