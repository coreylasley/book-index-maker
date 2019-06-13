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
    public partial class PageProperties : Form
    {
        public List<WordOnPage> WordOnPages;
        public bool ClickedOk;

        public int Page
        {
            get
            {
                return Convert.ToInt32(txtPage.Text);
            }
            set
            {
                txtPage.Text = value.ToString();
            }
        }

        public string Word
        {
            get
            {
                return txtWord.Text;
            }
            set
            {
                txtWord.Text = value;
            }
        }
             

        public PageProperties()
        {
            InitializeComponent();
        }

        public PageProperties(List<WordOnPage> bookPages, int page, string word)
        {
            InitializeComponent();
            WordOnPages = bookPages;
            Page = page;
            Word = word;
            LoadData();
        }

        private List<string> AddToList(List<string> lst, string addWhat)
        {
            if (addWhat != null)
            {
                if (addWhat.Trim() != "")
                {
                    bool found = false;

                    foreach (string str in lst)
                    {
                        if (str.ToLower() == addWhat.ToLower())
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        lst.Add(addWhat);
                    }
                }
            }

            return lst;
        }

        public void LoadData()
        {
            //bool foundIt = false;
            lstIndexes.Items.Clear();

            // Used to store the word option list (for potential "Index As" words)
            List<string> indexAsList = new List<string>();
            
            // Clear the options comboBox
            cboIndexAs.Items.Clear();

            // Add the word to the options
            indexAsList = AddToList(indexAsList, Word);

            // Loop through each WordOnPage object....
            foreach (WordOnPage wop in WordOnPages)
            {
                // If the Word matches...
                if (wop.Word.ToLower() == Word.ToLower())
                {
                    // Loop through each Page referencing the Word
                    foreach (PageClass pc in wop.Page)
                    {
                        // If the Page matches...
                        if (pc.Page == Page)
                        {
                            // Loop through the Sub Entry words...
                            foreach (string str in pc.SubEntries)
                            {                                
                                // Add the word to the List Box
                                lstIndexes.Items.Add(str);

                                // Also add the word to our options (for a possible "Index As") list
                                indexAsList = AddToList(indexAsList, str);
                            }

                            // Set the text of the Index As text box to the word that was saved
                            cboIndexAs.Text = pc.IndexAs;

                            break;
                        }
                        else // If the Page does NOT match
                        {
                            // We want to add the index words as options to pick from

                            // Add the "Index As" word from the other page
                            indexAsList = AddToList(indexAsList, pc.IndexAs);
                            // Also add all the Sub Entry words
                            foreach (string str in pc.SubEntries)
                            {                                
                                indexAsList = AddToList(indexAsList, str);
                            }
                        }
                    }
                    break;
                }
            }

            // If no word was saved for the "Index As"...
            if (cboIndexAs.Text.Trim() == "")
            {
                // Use the actual word
                cboIndexAs.Text = Word;
            }
            else
            {
                // If a word was saved, add it to our list of options
                indexAsList = AddToList(indexAsList, cboIndexAs.Text);
            }

            // Fill the options comboBox
            foreach (string s in indexAsList.OrderBy(p => p.ToString()).ToList())
            {
                cboIndexAs.Items.Add(s);
            }

            // Prepare to show the other words indexed on this page
            List<string> alsoOnPage = new List<string>();
            
            // Loop through each WordOnPage object....
            foreach (WordOnPage wop in WordOnPages)
            {
                // Loop through each Page in the Word...
                foreach (PageClass page in wop.Page)
                {
                    // If the Page Matches
                    if (page.Page == Page)
                    {
                        // If the Index As word on this page does not match our working work, then add it 
                        if (page.IndexAs != null) if (cboIndexAs.Text.ToLower() != page.IndexAs.ToLower()) alsoOnPage = AddToList(alsoOnPage, page.IndexAs);
                        // Loop through the sub entries...
                        foreach (string se in page.SubEntries)
                        {
                            // Do the same thing
                            if (cboIndexAs.Text.ToLower() != se.ToLower()) alsoOnPage = AddToList(alsoOnPage, se);
                        }
                    }
                }
            }

            lstOtherIndexes.Items.Clear();

            // Fill the other references on Page
            foreach (string s in alsoOnPage.OrderBy(p => p.ToString()).ToList())
            {
                lstOtherIndexes.Items.Add(s);                
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ClickedOk = true;

            foreach (WordOnPage wop in WordOnPages)
            {
                if (wop.Word.ToLower() == Word.ToLower())
                {
                    foreach (PageClass pc in wop.Page)
                    {
                        if (pc.Page == Page)
                        {
                            pc.Category = cboCategory.Text.Trim();
                            pc.IndexAs = cboIndexAs.Text.Trim();
                            pc.SubEntries.Clear();
                            for (int x = 0; x < lstIndexes.Items.Count; x++)
                            {
                                pc.SubEntries.Add(lstIndexes.Items[x].ToString());
                            }

                            break;
                        }
                    }
                    break;
                }
            }


            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClickedOk = false;
            this.Hide();
        }

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            string word = cboIndexAs.Text.Trim();
            bool found = false;
            for (int x = 0; x < lstIndexes.Items.Count; x++)
            {
                if (lstIndexes.Items[x].ToString().ToLower() == word.ToLower())
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                lstIndexes.Items.Add(word);
                cboIndexAs.Text = "";
            }
        }

        private void PageProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
