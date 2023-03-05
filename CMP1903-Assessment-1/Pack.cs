using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_Assessment_1
{
    public class Pack
    {
        static List<Card> pack;

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
        }

        public static bool shuffleCardPack(int typeOfShuffle)
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
                return true;
            }
            else if (typeOfShuffle == 2) 
            {
                List<Card> halfPack1 = new List<Card>();
                List<Card> halfPack2 = new List<Card>();
                for (int i = 0; i <= 25; i++) 
                {
                    halfPack1.Add(pack[i]);
                }
                for (int i = 26; i <= 51; i++)
                {
                    halfPack2.Add(pack[i]);
                }
                pack.Clear();
                for (int i = 0; i <= 25; i++) 
                {
                    pack.Add(halfPack1[i]);
                    pack.Add(halfPack2[i]);
                }
                return true;
            }
            else if (typeOfShuffle == 3)
            {
                return true; 
            }
            else { return false; }

        }
        public void printPack() 
        {
            for (int i = 0; i <= pack.Count - 1; i++) 
            {
                Console.WriteLine(pack[i].Suit.ToString() + " " + pack[i].Value.ToString());
            }
        }
        public static Card deal()
        {
            //Deals one card
            try 
            {
                Card dealCard = pack[0];
                pack.RemoveAt(0);
                return dealCard;
            }
            catch (System.NullReferenceException e) 
            {
                throw new NullReferenceException("No more cards to deal");
            }
        }
        /*
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }*/
    }
}
