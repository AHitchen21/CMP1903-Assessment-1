using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_Assessment_1
{
    public class Testing
    {
        public void shuffleTest() 
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(1);
            Pack.shuffleCardPack(2);
            Pack.shuffleCardPack(3);
            pack.printPack();
        }
        public void breakDeal() 
        {
            for (int i = 0; i <=52; i++) 
            {
                Pack.deal();
            }
        }
        public void testDeal() 
        {
            Pack pack = new Pack();
            Pack.deal();
            pack.printPack();

        }
        public void testMultiDeal() 
        {
            Pack pack = new Pack();
            for (int i = 0; i <= 10; i++)
            {
                Pack.dealCard(5);
            }
        }
    }
}
