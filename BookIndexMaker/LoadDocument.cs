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
    public partial class LoadDocument : Form
    {
        public bool GoodToGo;

        public string DocumentToLoad
        {
            get
            {
                return txtDocument.Text;
            }
        }

        public string ProjectFile
        {
            get
            {
                return txtProjectFile.Text;
            }
        }

        public bool WordTypeMapping
        {
            get
            {
                bool ret = false;

                if (checkBox1.Checked)
                {
                    ret = false;
                }
                else
                {
                    ret = true;
                }

                return ret;
            }
        
        }

        public bool SkipContainsNumbers
        {
            get
            {
                bool ret = false;
                
                if (chkSkipNumbers.Checked)
                {
                    ret = false;
                }
                else
                {
                    ret = true;
                }

                return ret;
            }
        }

        public LoadDocument()
        {
            InitializeComponent();
        }

        private void LoadDocument_Load(object sender, EventArgs e)
        {
            GoodToGo = false;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string last = "";
            string[] words = txtWordsToIgnore.Text.ToLower().Split(';');
            Array.Sort(words, StringComparer.InvariantCulture);
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x] != last)
                {
                    sb.Append(words[x].Trim());
                    if (x + 1 < words.Length) sb.Append("; ");
                }
                last = words[x];
            }
            txtWordsToIgnore.Text = sb.ToString();
        }

        private void btnLoadDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF (*.pdf)|*.pdf|Microsoft Word (*.doc, *.docx)|*.doc*";
            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                txtDocument.Text = ofd.FileName;
            }

            ofd.Dispose();

        }

        private void btnProjectFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Index Project (*.idxp)|*.idxp*";
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                string fn = sfd.FileName;
                if (System.IO.Path.GetExtension(fn) == "") fn = fn + ".idxp";
                txtProjectFile.Text = fn;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            GoodToGo = true;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoodToGo = false;
            this.Close();
        }
    }
}
