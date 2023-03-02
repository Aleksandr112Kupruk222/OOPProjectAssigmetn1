using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Pack
    {
        static Random _random = new Random();
        static List<Card> pack =  new List<Card>();
       
        public Pack()
        {
            //Initialise the card pack here
            for (int i = 1; i <= 4; i++) 
            {
                for (int x = 1; x < 14; x++)
                {
                    pack.Add(new Card(i,x));
                    
                }   
            }
           

        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                int n = pack.Count;
                for (int i = 0; i < (n - 1); i++)
                {
                    int r = i + _random.Next(n - i);
                    var t = pack[r];
                    pack[r] = pack[i];
                    pack[i] = t;
                }
                return true;
                //Show();
              
            }

            if (typeOfShuffle == 2)
            {
                int half = pack.Count / 2;
                List<Card> half1 = pack.GetRange(0, half);
                List<Card> half2 = pack.GetRange(half, half);

                List<Card> shuffled = new List<Card>();


                while (half1.Count > 0 && half2.Count > 0)
                {
                    int numCards = _random.Next(1, 4);
                    numCards = Math.Min(numCards, Math.Min(half1.Count, half2.Count));

                    for (int i = 0; i < numCards; i++)
                    {
                        shuffled.Add(half1[0]);
                        half1.RemoveAt(0);
                    }

                    for (int i = 0; i < numCards; i++)
                    {
                        shuffled.Add(half2[0]);
                        half2.RemoveAt(0);
                    }
                }

                if (half1.Count > 0)
                {
                    shuffled.AddRange(half1);
                }

                if (half2.Count > 0)
                {
                    shuffled.AddRange(half2);
                }

                pack = shuffled;
                return true;
                //Show();
            }

            if (typeOfShuffle == 3)
            {
                Console.WriteLine("");
                return true;

            }
            
            return false;




        }
        static void Show() 
        {
            foreach (Card card in pack)
            {
                card.show();
            }
        }
        public static Card deal()
        {
            //deals one card
            return pack[0];

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(pack[i]);

            }
            return cards;

            

        }




    }
}

