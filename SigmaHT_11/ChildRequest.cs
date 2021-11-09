using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_11
{
    enum Sex { Male, Female }

    class ChildRequest
    {
        public string Name { get; private set; }
        public Sex Sex { get; private set; }
        public uint GoodDeedsCount { get; private set; }
        public uint BadDeedsCount { get; private set; }

        public ChildRequest(string name, Sex sex, uint goodDeedsCount, uint badDeedsCount)
        {
            Name = name;
            Sex = sex;
            GoodDeedsCount = goodDeedsCount;
            BadDeedsCount = badDeedsCount;
        }
    }
}
