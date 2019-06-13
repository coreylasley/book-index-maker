using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookIndexMaker
{
    [Serializable]
    public class PageClass
    {
        public List<string> SubEntries;

        public string IndexAs { get; set; }

        public string Category { get; set; }
        public int Page { get; set; }
        
        public bool Include { get; set; }
        

        public PageClass()
        {
            SubEntries = new List<string>();
            Page = 0;
        }

        public PageClass(int page)
        {
            SubEntries = new List<string>();
            Page = page;
        }
    }
}
