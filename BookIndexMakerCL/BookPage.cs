using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookIndexMaker
{

    [Serializable]
    public class BookPage
    {
        public string Content { get; set; }
        public string RawContent { get; set; }
        public List<string> Words { get; set; }

        public BookPage()
        {
            Content = "";
            Words = new List<string>();
        }

        public BookPage(string content)
        {
            RawContent = content;
            Words = new List<string>();
            string cleanWords = RemoveCommonWords(content);
            Content = cleanWords;

            string[] words = cleanWords.Split(' ');
            foreach (string word in words)
            {
                if (word.Trim() != "")
                {
                    Words.Add(word.Trim());
                }
            }
        }

        private string RemoveCommonWords(string sentance)
        {
            sentance = " " + sentance + " ";
            sentance = sentance.Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " ").Replace("\t", " ").Replace("'s", "").Replace("’s", "").Replace("‘s", "");
            sentance = sentance.Replace(".", "").Replace("?", "").Replace("!", "").Replace("\"", "").Replace("'", "").Replace(",", "").Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "").Replace("\\", " ").Replace("/", " ");
            sentance = sentance.Replace("", "").Replace("","").Replace("", "").Replace("", "").Replace("“", "").Replace("”", "").Replace(";", "").Replace(":", "").Replace("‘", "").Replace("’", "");
            sentance = sentance.Replace("", "").Replace("–", "").Replace("—", "").Replace("&o", "").Replace("&c", "").Replace("&", "").Replace("", " ").Replace("¼", "").Replace("½", "");

            for (int x = 0; x < 5; x++)
            {
                sentance = sentance.Replace("  ", " ");
            }


            string cwordslist = "i;it;a;am;all;my;the;to;too;and;an;in;out;but;this;that;could;not;like;they;had;has;come;came;their;in;is;there;then;than;for;or;his;her;him;son;father;mother;daughter;cousin;uncle;grandfather;grandmother;;more;very;into;known;being;where;in;about;died;born;death;life;would;after;may;also;later;she;two;one;three;when;be;because;been;years;time;where;were;which;from;to;too;it;The;by;He;with;at;as;on;of;was;went;other;are;early;late;around;time;name;named;left;right;lived;them;up;all;some;many;very;however;family;children;;married;he;have;who;according;actually;after;age;ago;along;also;always;among;an;and;another;any;appear;apparently;appears;as;at;away;became;before;began;between;both;can;decided";
            string[] cwords = cwordslist.Split(';');

            foreach (string w in cwords)
            {
                sentance = sentance.Replace(" " + w + " ", " ");
            }

            foreach (string w in cwords)
            {
                string n = w.Substring(0, 1).ToUpper() + w.Substring(1, w.Length - 1);
                sentance = sentance.Replace(" " + w + " ", " ");
            }

            return sentance;
        }
    }
}
