using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_11
{
    class Program
    {
        static void Main(string[] args)
        {
            SaintNicholas saintNicholas = SaintNicholas.GetInstance(@"C:\Users\User\source\repos\SigmaHT_11\SigmaHT_11\BoysToys.txt",
                @"C:\Users\User\source\repos\SigmaHT_11\SigmaHT_11\GirlsToys.txt",
                @"C:\Users\User\source\repos\SigmaHT_11\SigmaHT_11\EdibleGifts.txt",
                @"C:\Users\User\source\repos\SigmaHT_11\SigmaHT_11\Wishes.txt");

            ChildRequest firstChildRequest = new ChildRequest("Mark", Sex.Male, 10, 5);

            Gift fisrtGift = saintNicholas.GiveSequentientGift(firstChildRequest);

            ChildRequest secondChildRequest = new ChildRequest("Masha", Sex.Female, 5, 10);

            Gift secondGift = saintNicholas.GiveRandomGift(secondChildRequest);

            ChildRequest thirdChildRequest = new ChildRequest("Max", Sex.Male, 7, 2);

            Gift thirdGift = saintNicholas.GiveRandomGift(thirdChildRequest);
        }
    }
}
