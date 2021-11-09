using System;
using System.IO;

namespace SigmaHT_11
{
    class GiftBuilder
    {
        private string[] toys;
        private string[] edibleGifts;
        private string[] wishes;

        static private int toyCurrIndex = 0;
        static private int edibleGiftCurrIndex = 0;
        static private int wishCurrIndex = 0;

        public GiftBuilder(string[] toys, string[] edibleGifts, string[] wishes)
        {
            this.toys = toys;
            this.edibleGifts = edibleGifts;
            this.wishes = wishes;
        }

        public Gift BuildRandomGift(ChildRequest childRequest)
        {
            Random random = new Random();

            int toyRandomIndex = random.Next(toys.Length);
            int edibleGiftRandomIndex = random.Next(edibleGifts.Length);
            int wishRandomIndex = random.Next(wishes.Length);

            if (childRequest.BadDeedsCount > childRequest.GoodDeedsCount)
                return new Gift("Rizka", edibleGifts[edibleGiftRandomIndex], "Be more polite!");

            return new Gift(toys[toyRandomIndex], edibleGifts[edibleGiftRandomIndex], wishes[wishRandomIndex]);
        }

        public Gift BulidSequentientGift()
        {
            if (toyCurrIndex > toys.Length - 1)
                toyCurrIndex = 0;
            if (edibleGiftCurrIndex > edibleGifts.Length - 1)
                edibleGiftCurrIndex = 0;
            if (wishCurrIndex > wishes.Length - 1)
                wishCurrIndex = 0;

            return new Gift(toys[toyCurrIndex++], edibleGifts[edibleGiftCurrIndex++], wishes[wishCurrIndex++]);
        }
    }
}
