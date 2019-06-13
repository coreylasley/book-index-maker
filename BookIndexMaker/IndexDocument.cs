using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookIndexMaker
{
    public partial class IndexDocument : Form
    {
        public IndexDocument()
        {
            InitializeComponent();
        }

        private void IndexDocument_Load(object sender, EventArgs e)
        {

        }

        public void GenerateIndex(List<WordOnPage> wops)
        {
            FinalWordCollection fwc = new FinalWordCollection();
            foreach (WordOnPage wop in wops)
            {
                if (wop.Include)
                {
                    foreach (PageClass pc in wop.Page)
                    {
                        if (pc.Include)
                        {
                            if (pc.IndexAs != null) fwc.AddWord(pc.IndexAs, pc.Page);
                            foreach (string se in pc.SubEntries)
                            {
                                fwc.AddWord(se, pc.Page);
                            }
                        }
                    }
                }
            }

            List<FinalWord> nfwc = fwc.GetWordsOrdered();

            StringBuilder sb = new StringBuilder();

            string lastLetter = "";
            foreach (FinalWord fw in nfwc)
            {
                if (fw.Word.Length > 0)
                {
                    string letter = fw.Word.Substring(0, 1).ToUpper();

                    if (letter != lastLetter) sb.AppendLine("\r\n" + letter);
                    sb.AppendLine(fw.Word + ", " + fw.GetPageList());

                    lastLetter = letter;
                }
            }

            txtIndex.Text = sb.ToString();

        }

        private void mnuCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtIndex.Text);
        }
    }

    public class FinalWordCollection
    {
        public List<FinalWord> Words;

        public FinalWordCollection()
        {
            Words = new List<FinalWord>();
        }

        public List<FinalWord> GetWordsOrdered()
        {
            return Words.OrderBy(p => p.Word).ToList();
        }

        public void AddWord(string word)
        {
            bool found = false;

            foreach (FinalWord fw in Words)
            {
                if (fw.Word.ToLower().Trim() == word.ToLower().Trim())
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Words.Add(new FinalWord(word));
            }

        }

        public void AddWord(string word, int page)
        {
            bool found = false;

            foreach (FinalWord fw in Words)
            {
                if (fw.Word.ToLower().Trim() == word.ToLower().Trim())
                {
                    fw.AddPage(page);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                FinalWord w = new FinalWord(word);
                w.AddPage(page);
                Words.Add(w);
            }
        }
    }

    public class FinalWord
    {
        public string Word;
        public List<int> Pages;

        public FinalWord()
        {
            Word = "";
            Pages = new List<int>();
        }

        public FinalWord(string word)
        {
            Word = word;
            Pages = new List<int>();
        }

        public void AddPage(int page)
        {
            bool found = false;

            foreach(int p in Pages)
            {
                if (page == p)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Pages.Add(page);
            }
        }

        public string GetPageList()
        {
            StringBuilder sb = new StringBuilder();

            List<int> oPages = Pages.OrderBy(p => p).ToList();
            int lastPage = 0;
            int min = 0;
            int max = 0;
            for (int c = 0; c < oPages.Count; c++)
            {
                if (c + 1 < oPages.Count)
                {
                    if (oPages[c + 1] == oPages[c] + 1)
                    {
                        if (min == 0)
                        {
                            min = oPages[c];
                            max = oPages[c + 1];
                        }
                        else
                        {
                            max = oPages[c + 1];
                        }
                    }
                    else
                    {
                        if (min > 0 && max > 0)
                        {
                            sb.Append(min.ToString() + "-" + max.ToString());
                            min = 0;
                            max = 0;
                        }
                        else
                        {
                            sb.Append(oPages[c].ToString());
                        }
                    }
                }
                else
                {
                    if (min > 0 && max > 0)
                    {
                        sb.Append(min.ToString() + "-" + max.ToString());
                        min = 0;
                        max = 0;
                    }
                    else
                    {
                        sb.Append(oPages[c].ToString());
                    }
                }

                //sb.Append(oPages[c].ToString());
                if (c + 1 < oPages.Count)
                {
                    if (min == 0)
                    {
                        sb.Append(", ");
                    }
                }

                lastPage = oPages[c];
            }
            
            return sb.ToString().Trim();
        }
    }
}
