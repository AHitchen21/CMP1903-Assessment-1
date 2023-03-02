using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Pack pack = new Pack();
            pack.shuffleCardPack(1);
            pack.shuffleCardPack(1);
            pack.shuffleCardPack(1);
            pack.shuffleCardPack(1);
            pack.shuffleCardPack(1);
            pack.shuffleCardPack(1);

            Console.ReadLine();
        }
    }
}
