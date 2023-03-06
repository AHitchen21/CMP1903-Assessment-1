using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            pack = new List<Card>(); //creates a new list of cards called 'pack'
            //Initialise the card pack here
            for (int i = 1; i <= 4; i++) 
            {
                for (int j = 1; j <= 13; j++) //iterates through the suits and values of the cards.
                {
                    Card card = new Card(); //creates a new card.
                    card.Suit = i; //sets the suit to the value of i. 
                    card.Value = j; //sets the value of the card to the value of j.
                    pack.Add(card); //adds the newly created card to the pack.
                }
            }
        }
        //Shuffles the pack based on the type of shuffle
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (pack.Count <= 1) //checks if the pack is large enough to be shuffled
            {
                Console.WriteLine("Pack is too small to be shuffled"); //prints an error
                return false; //returns false to show that the shuffle did not work
            }
            if (typeOfShuffle == 1) //Fisher-Yates shuffle.
            {
                for (int i = pack.Count - 1; i >= 1; i--) //counts backwards through the list
                {
                    Card temp = new Card(); //creates a temp variable of a Card
                    var random = new Random(); 
                    int position = random.Next(0, i); //creates a random number between 0 and i (i being the current position in the list)
                    temp = pack[i]; //sets the temp variable to the current position
                    pack.RemoveAt(i); //removes the card
                    pack.Insert(i ,pack[position]); //Inserts the card at the random chosen position to the current position
                    pack.RemoveAt(position); //removes the card at the random position
                    pack.Insert(position,temp); //adds the Card in the temp variable to the random position (swapping the two cards in the current position and the random position)

                }
                return true; //returns true to show the pack was shuffled
            }
            else if (typeOfShuffle == 2) //riffle shuffle
            {
                int cardCountHalf = pack.Count / 2;
                List<Card> halfPack1 = new List<Card>(); //creates two new card lists that respresents 2 halves of the pack
                List<Card> halfPack2 = new List<Card>();
                for (int i = 0; i < (pack.Count / 2); i++) //iterates through the first half of the pack.
                {
                    halfPack1.Add(pack[i]); //adds the first half of the pack to halfPack1
                }
                for (int i = (pack.Count / 2) - 1; i < pack.Count; i++) //iterates through the second half of the pack.
                {
                    halfPack2.Add(pack[i]); //adds the second half of the pack to halfPack2
                }
                pack.Clear(); //clears the pack
                for (int i = 0; i < cardCountHalf; i++) //iterates through the 26 cards of both halves
                {
                    pack.Add(halfPack1[i]); //adds each half one by one back into the pack, shuffling the pack.
                    pack.Add(halfPack2[i]);
                }
                return true; //returns true to show it has been shuffled
            }
            else if (typeOfShuffle == 3) //no shuffle
            {
                return true; //returns true as it has been shuffled
            }
            else 
            {
                Console.WriteLine("'typeOfShuffle' needs to be 1, 2, or 3 to work."); //prints an error
                return false; //returns false a correct option was not chosen
            } 
        }
        //Method created outside of breif to print the pack for testing puroposes
        public void printPack() 
        {
            for (int i = 0; i < pack.Count; i++) 
            {
                Console.WriteLine(pack[i].Suit.ToString() + " " + pack[i].Value.ToString()); //iterates through the pack and prints all the cards
            }
        }
        //Deals one card
        public static Card deal()
        {
            if (pack == null) 
            {
                throw new NullReferenceException();
            }
            Card dealCard = pack[0]; //adds the dealt (top) card to a variable
            pack.RemoveAt(0); //removes the top card
            return dealCard; //returns the top card
        }
        //Deals the number of cards specified by 'amount'
        public static List<Card> dealCard(int amount)
        {
            if (amount <= 0) 
            {
                throw new ArgumentNullException(); //throws exception if amount is less than zero.
            }
            if (pack.Count < amount) 
            {
                throw new ArgumentOutOfRangeException(); //throws exception if amount of cards to be dealt is more than what is available
            }
            List<Card> dealtCards = new List<Card>(); //creates a new list of cards
            for (int i = 0; i < amount; i++) //iterates 'amount' times
            {
                dealtCards.Add(pack[0]); //adds top Card to dealtCards.
                pack.RemoveAt(0); //removes top card from pack.
            }
            return dealtCards; //returns dealtCards
        }
    }
}
