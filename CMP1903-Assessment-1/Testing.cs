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
            pack.printPack();
        }
    }
}
