using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_Assessment_1
{
    public class Testing
    {
        //Test Method that tests the shuffleCardPack method from Pack.cs
        public void shuffleTest()
        {
            Pack shuffleTest = new Pack(); //creates a new Pack.
            Pack.shuffleCardPack(2); //shuffles the Pack twice (change values to test different shuffles).
            shuffleTest.printPack(); //Prints the pack to console to see whether it has been shuffled or not.
        }
        //Method that purposely breaks the deal() method  in Pack.cs to test the exception.
        public void breakDeal() 
        {
            try
            {
                for (int i = 0; i <= 52; i++)
                {
                    Pack.deal(); //deals a card from the pack 53 times.
                }
            }
            catch (NullReferenceException e) 
            {
                Console.WriteLine("No more cards left in the pack."); //displays error message for exception thrown
            }
        }
        //Tests the deal() method in Pack.cs
        public void testDeal()
        {
            Pack testDeal = new Pack(); //creates a new Pack
            Card dealtCard = new Card(); //creates a new Card
            try
            {
                dealtCard = Pack.deal(); //sets the new Card to the dealt card value
                testDeal.printPack(); //prints the pack
                Console.WriteLine("the card that was dealt: " + dealtCard.Suit.ToString() + " " + dealtCard.Value.ToString()); //prints the dealt card
            }
            catch (NullReferenceException e) 
            {
                Console.WriteLine("No more cards left in the pack."); //displays error message for exception thrown
            }
        }
        //Tests the dealCard() Method in Pack.cs
        public void testMultiDeal() 
        {
            Pack multiDeal = new Pack();
            try
            {
                Pack.dealCard(52); //deals 5 cards (can change value by dealing 5 cards)
            }
            catch (ArgumentNullException e) 
            {
                Console.WriteLine("Amount must be greater than 0."); //displays error message for exception thrown
            }
            catch (ArgumentOutOfRangeException e) 
            {
                Console.WriteLine("Not enough cards for amount specified."); //displays error message for exception thrown
            }
        }
    }
}
