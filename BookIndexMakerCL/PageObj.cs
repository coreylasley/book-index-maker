using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookIndexMaker
{
    public class PageObj
    {
        public string Page { get; set; }

        public PageObj()
        {
        }

        public PageObj(string value)
        {
            Page = value;
        }
    }
}
