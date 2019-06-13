using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookIndexMaker
{
    [Serializable]
    public class WordOnPage
    {
        public List<PageClass> Page;
        public DictionaryWord.WordTypes WordTypeEnum;
        public List<string> CombinedWords;

        public string Word { get; set; }

        public string WordType { get; set; }

        public bool Include { get; set; }

        public int PageCount
        {
            get { return Page.Count; }
        }

        public string Pages
        {
            get
            {
                StringBuilder list = new StringBuilder();
                int c = 0;
                foreach (PageClass x in Page)
                {
                    c++;
                    list.Append(x.Page.ToString());
                    if (c < Page.Count) list.Append(", ");
                }

                return list.ToString();
            }
        }

        public static WordOnPage Combine(WordOnPage wop1, WordOnPage wop2, string IndexAs)
        {
            WordOnPage wop = new WordOnPage();

            wop.CombinedWords = new List<string>();

            wop.CombinedWords.Add(wop1.Word);
            foreach (string str in wop1.CombinedWords)
            {
                wop.CombinedWords.Add(str);
            }

            return wop;
        }
    }
}
