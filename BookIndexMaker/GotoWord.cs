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
    public partial class GotoWord : Form
    {
        public AutoCompleteStringCollection Words;
        public string SelectedWord;

        public GotoWord()
        {
            InitializeComponent();
        }

        private void GotoWord_Load(object sender, EventArgs e)
        {
            cboWord.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboWord.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboWord.AutoCompleteCustomSource = Words;
            
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            SelectedWord = cboWord.Text;
            this.Hide();
        }
    }
}
