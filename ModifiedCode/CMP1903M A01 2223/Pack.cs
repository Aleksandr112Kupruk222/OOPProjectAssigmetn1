using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
        static int j;
       
        public Pack()
        {
            j = 0;  
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

                Random rand = new Random();
                // Divide the pack into two halves
                int half = pack.Count / 2;
                List<Card> half1 = pack.GetRange(0, half);
                List<Card> half2 = pack.GetRange(half, half);
                // Create new list to hold shuffled cards
                List<Card> shuffled = new List<Card>();

                // Loop while both halves still have cards
                while (half1.Count > 0 && half2.Count > 0)
                {
                    // Randomly choose which half to draw from and add to shuffled list
                    if (rand.NextDouble() < 0.5)
                    {
                        shuffled.Add(half1[0]);
                        half1.RemoveAt(0);
                    }
                    else
                    {
                        shuffled.Add(half2[0]);
                        half2.RemoveAt(0);
                    }
                }

                // If either half still has cards, add them to shuffled list
                if (half1.Count > 0)
                {
                    shuffled.AddRange(half1);
                }

                if (half2.Count > 0)
                {
                    shuffled.AddRange(half2);
                }


                pack = shuffled;
                j += 1;
                // Recursively call this function up to 5 times
                if (j != 5)
                {
                    shuffleCardPack(2);
                }
                return true;
            }

            if (typeOfShuffle == 3)
            {
                Console.WriteLine("");
                return true;

            }
            
            return false;




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

