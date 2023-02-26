using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            pack = new List<Card>();
            //Initialise the card pack here
            for (int i = 1; i <= 4; i++) 
            {
                for (int j = 1; j <= 13; j++) 
                {
                    Card card = new Card();
                    card.Suit = i;
                    card.Value = j;
                    pack.Add(card);
                }
            }
            Console.WriteLine();
        }
        public void printPack() 
        {
            for (int i = 0; i <= 51; i++) 
            {
                Console.WriteLine(pack[i].Suit.ToString() + " " + pack[i].Value.ToString());
            }
            Console.WriteLine(pack.Count());
        }

        public void shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                for (int i = 51; i >= 1; i--) 
                {
                    Card temp = new Card();
                    var random = new Random();
                    int position = random.Next(0, i);
                    temp = pack[i];
                    pack.RemoveAt(i);
                    pack.Insert(i ,pack[position]);
                    pack.RemoveAt(position);
                    pack.Insert(position,temp);

                } 
            }
        }
        /*
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }*/
    }
}
