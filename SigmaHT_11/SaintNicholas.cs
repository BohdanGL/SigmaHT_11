using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SigmaHT_11
{
    class SaintNicholas
    {
        private string[] boysToys;
        private string[] girlsToys;
        private string[] edibleGifts;
        private string[] wishes;

        private static SaintNicholas instance;

        public SaintNicholas(string boysToysFile, string girlsToysFile,
            string edibleGiftsFile, string wishesFile)
        {
            GetBoysToys(boysToysFile);
            GetGirlsToys(girlsToysFile);
            GetEdibleGifts(edibleGiftsFile);
            GetWishes(wishesFile);
        }

        public static SaintNicholas GetInstance(string boysToysFile, string girlsToysFile,
            string edibleGiftsFile, string wishesFile)
        {
            if (instance == null)
                instance = new SaintNicholas(boysToysFile, girlsToysFile,
            edibleGiftsFile, wishesFile);

            return instance;
        }

        private void GetBoysToys(string boysToysFile)
        {
            StreamReader streamReaderToys = new StreamReader(boysToysFile);

            boysToys = streamReaderToys.ReadToEnd().Replace("\r", String.Empty).Split('\n');

            streamReaderToys.Close();
        }
        private void GetGirlsToys(string girlsToysFile)
        {
            StreamReader streamReaderToys = new StreamReader(girlsToysFile);

            girlsToys = streamReaderToys.ReadToEnd().Replace("\r", String.Empty).Split('\n');

            streamReaderToys.Close();
        }
        private void GetEdibleGifts(string edibleGiftsFile)
        {
            StreamReader streamReaderToys = new StreamReader(edibleGiftsFile);

            edibleGifts = streamReaderToys.ReadToEnd().Replace("\r", String.Empty).Split('\n');

            streamReaderToys.Close();
        }
        private void GetWishes(string wishesFile)
        {
            StreamReader streamReaderToys = new StreamReader(wishesFile);

            wishes = streamReaderToys.ReadToEnd().Replace("\r", String.Empty).Split('\n');

            streamReaderToys.Close();
        }

        public void GetGifts(string boysToysFile, string girlsToysFile,
            string edibleGiftsFile, string wishesFile)
        {
            GetBoysToys(boysToysFile);
            GetGirlsToys(girlsToysFile);
            GetEdibleGifts(edibleGiftsFile);
            GetWishes(wishesFile);
        }


        public Gift GiveRandomGift(ChildRequest childRequest)
        {
            GiftBuilder giftBuilder;

            switch (childRequest.Sex)
            {
                case Sex.Male:
                    giftBuilder = new GiftBuilder(boysToys, edibleGifts, wishes);
                    break;
                case Sex.Female:
                    giftBuilder = new GiftBuilder(girlsToys, edibleGifts, wishes);
                    break;
                default:
                    giftBuilder = new GiftBuilder(boysToys, edibleGifts, wishes);
                    break;
            }

            return giftBuilder.BuildRandomGift(childRequest);
        }

        public Gift GiveSequentientGift(ChildRequest childRequest)
        {
            GiftBuilder giftBuilder;

            switch (childRequest.Sex)
            {
                case Sex.Male:
                    giftBuilder = new GiftBuilder(boysToys, edibleGifts, wishes);
                    break;
                case Sex.Female:
                    giftBuilder = new GiftBuilder(girlsToys, edibleGifts, wishes);
                    break;
                default:
                    giftBuilder = new GiftBuilder(boysToys, edibleGifts, wishes);
                    break;
            }

            return giftBuilder.BulidSequentientGift();
        }
    }
}
