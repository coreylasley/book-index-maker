using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BookIndexMaker
{

    public partial class Main : Form
    {        

        IndexProject TheProject;

        string currentWord;
        int currentPage;
        int nextPage;
        int previousPage;

        string previousWord;

        string TheProjectFile;

        int EventUpdateThreshold;
        int EventCount;
                

        public Main()
        {
            TheProject = new IndexProject();
            TheProject.OnUpdate += TheProject_OnUpdate;

            // Because a ton of events will come through when processing, set this number
            // as the number of events that must fire for each UI update.
            EventUpdateThreshold = 5;
            EventCount = 0;

            InitializeComponent();
        }

        private void TheProject_OnUpdate(object sender, UpdateEventArgs e)
        {
            EventCount++;

            if (EventCount % EventUpdateThreshold == 0)
            {
                string m = e.message;
                switch (e.eventType)
                {
                    case IndexProject.EventUpdateTypes.ParsingFromPDF:
                        m = "Reading text from PDF " + e.message;
                        break;
                    case IndexProject.EventUpdateTypes.Indexing:
                        m = "Indexing " + e.message;
                        break;
                    case IndexProject.EventUpdateTypes.DictionarySearch:
                        m = "Scanning Dictionary for: " + e.message;
                        break;
                }

                lblProcessStatus.Text = m;

                if (statusStrip1.InvokeRequired)
                {
                    statusStrip1.Invoke((MethodInvoker)(() =>
                    {

                        lblProcessStatus.Text = m;
                        pbBar.Visible = true;
                        pbBar.Maximum = e.progressMax;
                        pbBar.Value = e.progressCurrent;
                    }));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableForm(false);
            DoButtonStatus();
        }

        
                

        private void btnProcess_Click(object sender, EventArgs e)
        {
        }


        private void cbCapitolWords_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbCapitolWords.Checked)
            //{
            //    StringBuilder stb = new StringBuilder();
            //    foreach (WordOnPage wop in orderByMost)
            //    {
            //        if (wop.Word.Substring(0, 1) == wop.Word.Substring(0, 1).ToUpper())
            //        {
            //            stb.AppendLine(wop.Word + " - " + wop.Page.Count.ToString());
            //        }
            //    }

            //    richTextBox1.Text = stb.ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoadDocument ld = new LoadDocument();
            ld.Show();


        //    label1.Text = "Loading Dictionary...";
        //    System.Windows.Forms.Application.DoEvents();

        //    DataSet ds = RunQuery("SELECT Word, Definition FROM tblWord");

        //    label1.Text = "Extracting Nouns...";
        //    System.Windows.Forms.Application.DoEvents();

        //    List<string> Abbr = new List<string>();

        //    dictionaryWords = new List<DictionaryWord>();
        //    foreach (DataRow dr in ds.Tables[0].Rows)
        //    {
        //        if (dr.ItemArray[1].ToString().Substring(0, 1) == "(")
        //        {
        //            string[] p = dr.ItemArray[1].ToString().Split(')');
        //            if (p.Length == 2)
        //            {
        //                p[0] = p[0] + ")";
        //                bool found = false;
        //                foreach (string abbr in Abbr)
        //                {
        //                    if (abbr == p[0])
        //                    {
        //                        found = true;
        //                        break;
        //                    }
        //                }

        //                if (!found)
        //                {
        //                    Abbr.Add(p[0]);                            
        //                }
        //            }
        //        }
        //        //dictionaryWords.Add(new DictionaryWord(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));                
        //    }

        //    List<string> newAbbr = Abbr.OrderBy(p => p.ToString()).ToList();
        //    foreach (string na in newAbbr)
        //    {
        //        txtContext.Text += na + "\r\n";
        //    }

        //    label1.Text = "Ready";
        }

        //public void SerializeBook(string filename, List<BookPage> objectToSerialize)
        //{
        //    Stream stream = File.Open(filename, FileMode.Create);
        //    BinaryFormatter bFormatter = new BinaryFormatter();
        //    bFormatter.Serialize(stream, objectToSerialize);
        //    stream.Close();

        //    //Application.DoEvents();
        //    //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(objectToSerialize.GetType());
        //    //StreamWriter writer = new StreamWriter(filename);
        //    //x.Serialize(writer, objectToSerialize);
        //    //writer.Close();
        //}

        

        private void dgvWords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Index Project (*.idxp)|*.idxp*";
            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                try
                {

                    EnableForm(false);
                    this.Cursor = Cursors.WaitCursor;
                    lblProcessStatus.Text = "Loading Project...";
                    
                    TheProject = IndexProject.DeSerialize(ofd.FileName);
                    TheProjectFile = ofd.FileName;
                    dgvWords.DataSource = TheProject.RawWordList;
                    
                    lblWarnings.Text = TheProject.Warnings.Count.ToString() + " Warnings";
                    dgvWords.Columns[3].Visible = false;
                    dgvWords.Columns[2].HeaderText = "Type";
                    dgvWords.Columns[4].HeaderText = "Page Count";
                    dgvWords.Columns[5].HeaderText = "Pages";
                                        
                    RefreshMainGridView();

                    this.Text = "Corey Lasley's Book Index Builder [" + System.IO.Path.GetFileName(TheProjectFile) + "]";
                    EnableForm(true);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Cursor = Cursors.Arrow;
            ofd.Dispose();

            lblProcessStatus.Text = "Ready";
                        
        }

        private void dgvWords_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWords.SelectedRows.Count > 1)
            {
                btnCombine.Enabled = true;
                btnCrossReference.Enabled = true;
            }
            else
            {
                btnCombine.Enabled = false;
                btnCrossReference.Enabled = false;
            }

            foreach (DataGridViewRow dgv in dgvWords.SelectedRows)
            {
                currentWord = dgv.Cells[1].Value.ToString().Trim();
                lblPagesTitle.Text = "Pages containing \"" + currentWord + "\":";

                List<PageObj> pgs = new List<PageObj>();

                if (!TheProject.IsFiltered)
                {
                    foreach (PageClass page in TheProject.RawWordList[dgv.Index].Page)
                    {
                        pgs.Add(new PageObj(page.Page.ToString()));
                    }
                }
                else
                {
                    foreach (PageClass page in TheProject.FilteredWordList[dgv.Index].Page)
                    {
                        pgs.Add(new PageObj(page.Page.ToString()));
                    }
                }

                dgvPages.DataSource = pgs;
                for (int x = 0; x < dgvPages.Rows.Count; x++)
                {
                    dgvPages.Rows[x].Cells[0].Value = TheProject.RawWordList[dgv.Index].Page[x].Include;
                }

                SelectPage();
            }
        }

        private void dgvPages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelectPage();
        }

        private void DoButtonStatus()
        {
            if (TheProject.PagesInBook.Count <= 0)
            {
                btnContextPage.Enabled = false;
                button4.Enabled = false;
                btnPreviousPage.Enabled = false;
            }
            else
            {
                btnContextPage.Enabled = true;
            }

            if (nextPage >= TheProject.PagesInBook.Count)
            {
                button4.Enabled = false;
            }
            else
            {
                if (TheProject.PagesInBook.Count > 0) button4.Enabled = true;
            }

            if (previousPage == 1 || TheProject.PagesInBook.Count <= 1)
            {
                btnPreviousPage.Enabled = false;
            }
            else
            {
                if (TheProject.PagesInBook.Count > 0) btnPreviousPage.Enabled = true;
            }

            
        }

        private void SelectNextPage()
        {
            foreach (DataGridViewRow dgv in dgvPages.SelectedRows)
            {
                int cv = Convert.ToInt32(dgv.Cells[2].Value);
                
                nextPage++;
                previousPage = nextPage;
                if (nextPage > TheProject.PagesInBook.Count) nextPage = TheProject.PagesInBook.Count;
                if (TheProject.PagesInBook.Count >= nextPage)
                {
                    lblContext.Text = "Page " + nextPage.ToString() + " (Page " + cv.ToString() + " is actual Context)";
                    string content = TheProject.PagesInBook[nextPage - 1].RawContent.Trim();
                    txtContext.Text = content;
                                   

                    txtContext.SelectionStart = 0;
                    txtContext.SelectionLength = txtContext.Text.Length;
                    txtContext.SelectionBackColor = Color.White;
                }
            }

            DoButtonStatus();
        }

        private void SelectPreviousPage()
        {
            foreach (DataGridViewRow dgv in dgvPages.SelectedRows)
            {
                int cv = Convert.ToInt32(dgv.Cells[2].Value);

                previousPage--;
                nextPage = previousPage;
                if (previousPage < 1) previousPage = 1;
                if (TheProject.PagesInBook.Count >= previousPage)
                {
                    lblContext.Text = "Page " + previousPage.ToString() + " (Page " + cv.ToString() + " is actual Context)";
                    string content = TheProject.PagesInBook[previousPage - 1].RawContent.Trim();
                    txtContext.Text = content;
                                        
                    txtContext.SelectionStart = 0;
                    txtContext.SelectionLength = txtContext.Text.Length;
                    txtContext.SelectionBackColor = Color.White;
                }
            }

            DoButtonStatus();
        }

        private void SelectPage()
        {
            
            //string word = dgvWords.Ce
            foreach (DataGridViewRow dgv in dgvPages.SelectedRows)
            {
                int cv = Convert.ToInt32(dgv.Cells[2].Value);
                currentPage = cv;
                nextPage = cv;
                previousPage = cv;
                lblContext.Text = "Page " + cv.ToString() + " Context:";
                string content = TheProject.PagesInBook[cv - 1].RawContent.Trim();
                txtContext.Text = content;

                int pos = 0;

                txtContext.SelectionStart = 0;
                txtContext.SelectionLength = txtContext.Text.Length;
                txtContext.SelectionBackColor = Color.White;

                while (pos >= 0)
                {
                    pos = content.ToLower().IndexOf(currentWord.ToLower(), pos);
                    if (pos >= 0)
                    {
                        bool IsPartOfWord = false;
                        //if (pos + currentWord.Length < content.Length)
                        //{
                        //    char c = Convert.ToChar(content.Substring(pos + currentWord.Length + 1,1));
                        //    if (char.IsLetter(c) || char.IsNumber(c))
                        //    {
                        //        IsPartOfWord = true;
                        //    }
                        //}

                        //if (pos > 0 && !IsPartOfWord)
                        //{
                        //    char c = Convert.ToChar(content.Substring(pos - 1, 1));
                        //    if (char.IsLetter(c) || char.IsNumber(c))
                        //    {
                        //        IsPartOfWord = true;
                        //    }
                        //}

                        if (!IsPartOfWord)
                        {
                            txtContext.SelectionStart = pos;
                            txtContext.SelectionLength = currentWord.Length;
                            txtContext.SelectionBackColor = Color.Yellow;

                            txtContext.SelectionStart = pos;
                            txtContext.SelectionLength = 0;
                            txtContext.Focus();
                        }
                        pos++;
                    }
                }
            }

            DoButtonStatus();
        }

        private void dgvWords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings();
            frmSettings.Filter = TheProject.Filter;
            frmSettings.ShowDialog();
            TheProject.Filter = frmSettings.Filter;
            TheProject.IsFiltered = true;
            ApplyFilter();
            frmSettings.Close();
            this.Show();


        }

        private void ApplyFilter()
        {
            bool include = true;
            TheProject.FilteredWordList = new List<WordOnPage>();
            foreach (WordOnPage wop in TheProject.RawWordList)
            {
                include = true;

                if (TheProject.Filter.CapitalsOnly)
                {
                    if (wop.Word.Length > 0 && wop.Word.Substring(0, 1) == wop.Word.Substring(0, 1).ToUpper())
                    {
                        include = true;
                    }
                    else
                    {
                        include = false;
                    }
                }

                if (TheProject.Filter.NumbersAll && include == true)
                {
                    if (IsNumber(wop.Word))
                    {
                        include = false;
                    }
                    else
                    {
                        include = true;
                    }
                }

                if (TheProject.Filter.NumbersAndLetters && include == true)
                {
                    bool bi = true;
                    for (int x = 0; x < wop.Word.Length; x++)
                    {
                        if (IsNumber(wop.Word.Substring(x, 1)))
                        {
                            bi = false;
                            break;
                        }
                    }

                    include = bi;
                }

                if (include)
                {
                    TheProject.FilteredWordList.Add(wop);
                }
            }

            dgvWords.DataSource = TheProject.FilteredWordList;
        }


        private bool IsNumber(string value)
        {
            Regex regex = new Regex(@"^\d$");
            if (regex.IsMatch(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ColorRow(DataGridView dgv, int Row, Color color)
        {
            for (int x = 0; x < dgv.Columns.Count; x++)
            {
                dgvWords.Rows[Row].Cells[x].Style.BackColor = color;
            }
        }

        private void ColorRow(DataGridView dgv, int Row, Color backcolor, Color forecolor)
        {
            for (int x = 0; x < dgv.Columns.Count; x++)
            {
                dgv.Rows[Row].Cells[x].Style.BackColor = backcolor;
                dgv.Rows[Row].Cells[x].Style.ForeColor = forecolor;
            }
        }

        private void dgvWords_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool isChecked = (Boolean)dgvWords[0, e.RowIndex].FormattedValue;
                if (isChecked)
                {
                    ColorRow(dgvWords, e.RowIndex, System.Drawing.Color.FromArgb(213, 233, 208), Color.Black);                    
                }
                else
                {
                    ColorRow(dgvWords, e.RowIndex, Color.White, Color.Black); 
                }
                
                IncludeTheWord(isChecked);
            }

        }

        private void cmsWordHighlight_Opening(object sender, CancelEventArgs e)
        {
            string st = txtContext.SelectedText.Trim();
            if (st != "")
            {
                mnuGoToSelectedWord.Text = "Go to \"" + st + "\"";
                if (previousWord != null && previousWord.Trim() != "")
                {
                    mnuGoBackToPreviousWord.Text = "Go back to \"" + previousWord + "\"";
                    mnuGoBackToPreviousWord.Visible = true;
                }
                else
                {
                    mnuGoBackToPreviousWord.Visible = false;
                }
            }
        }

        private void mnuGoToSelectedWord_Click(object sender, EventArgs e)
        {
            try
            {
                previousWord = dgvWords.SelectedRows[0].Cells[1].Value.ToString();

                string st = txtContext.SelectedText.Trim();
                if (st != "")
                {
                    for (int x = 0; x < dgvWords.Rows.Count; x++)
                    {
                        if (st.ToLower() == dgvWords.Rows[x].Cells[1].Value.ToString().ToLower())
                        {
                            dgvWords.Rows[x].Selected = true;
                            dgvWords.CurrentCell = dgvWords[2, x];

                            break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not located the specified word", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuGoBackToPreviousWord_Click(object sender, EventArgs e)
        {
            
            string st = previousWord;
            if (st != "")
            {
                for (int x = 0; x < dgvWords.Rows.Count; x++)
                {
                    if (st.ToLower() == dgvWords.Rows[x].Cells[1].Value.ToString().ToLower())
                    {
                        dgvWords.Rows[x].Selected = true;
                        dgvWords.CurrentCell = dgvWords[2, x];

                        break;
                    }
                }
            }

            previousWord = "";

        }

        private void dgvPages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                PageProperties pp = new PageProperties(TheProject.RawWordList, currentPage, currentWord);
                pp.ShowDialog();
                if (pp.ClickedOk)
                {
                    TheProject.RawWordList = pp.WordOnPages;
                }
            }
        }

        private void dgvPages_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool isChecked = (Boolean)dgvPages[0, e.RowIndex].FormattedValue;
                if (isChecked)
                {
                    ColorRow(dgvPages, e.RowIndex, System.Drawing.Color.FromArgb(213, 233, 208), Color.Black);
                }
                else
                {
                    ColorRow(dgvPages, e.RowIndex, Color.White, Color.Black);
                }

                IncludeThePage(isChecked);
            }
        }

        private void RefreshMainGridView()
        {
            int c = -1;
            foreach (WordOnPage wop in TheProject.RawWordList)
            {
                c++;
                if (wop.Include)
                {
                    DataGridViewCheckBoxCell cbc = (DataGridViewCheckBoxCell)dgvWords.Rows[c].Cells[0];
                    cbc.Value = true;
                    ColorRow(dgvWords, c, System.Drawing.Color.FromArgb(213, 233, 208), Color.Black);
                }                
            }
        }

        private void IncludeTheWord(bool include)
        {
            foreach (WordOnPage wop in TheProject.RawWordList)
            {
                if (currentWord != null)
                {
                    if (wop.Word.ToLower() == currentWord.ToLower())
                    {
                        wop.Include = include;
                        if (include)
                        {
                            int c = -1;
                            foreach (PageClass pc in wop.Page)
                            {
                                pc.Include = true;
                                if (pc.IndexAs == null) pc.IndexAs = wop.Word;
                                c++;
                                dgvPages.Rows[c].Cells[0].Value = true;
                            }

                        }
                        break;
                    }
                }
            }
        }

        private void IncludeThePage(bool include)
        {
            foreach (WordOnPage wop in TheProject.RawWordList)
            {
                if (wop.Word.ToLower() == currentWord.ToLower())
                {
                    foreach (PageClass pc in wop.Page)
                    {
                        if (pc.Page == currentPage)
                        {
                            pc.Include = include;
                            if (pc.IndexAs == null && include) pc.IndexAs = wop.Word;
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            lblProcessStatus.Text = "Saving Project...";
            this.Cursor = Cursors.WaitCursor;
            System.Windows.Forms.Application.DoEvents();
            try
            {
                TheProject.Serialize(TheProjectFile, TheProject);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Arrow;
            lblProcessStatus.Text = "Ready";
            
        }

        private void dgvWords_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvWords.CommitEdit(DataGridViewDataErrorContexts.Commit);            
        }

        private void btnGenerateIndex_Click(object sender, EventArgs e)
        {
            IndexDocument id = new IndexDocument();
            id.Show();
            id.GenerateIndex(TheProject.RawWordList);
        }

        private void mnuGotoWord_Click(object sender, EventArgs e)
        {
            GotoWord gtw = new GotoWord();
            gtw.Words = TheProject.GetAutoCompleteList();
            gtw.ShowDialog();
            if (gtw.SelectedWord != "")
            {
                for (int x = 0; x < dgvWords.RowCount; x++)
                {
                    if (dgvWords.Rows[x].Cells[1].Value.ToString().ToLower() == gtw.SelectedWord.ToLower())
                    {
                        dgvWords.Rows[x].Selected = true;
                        dgvWords.CurrentCell = dgvWords[2, x];
                        break;
                    }
                }
            }
        }

        private void lblWarnings_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private async void mnuNew_Click(object sender, EventArgs e)
        {
            LoadDocument ld = new LoadDocument();
            ld.ShowDialog();

            bool DoProcess = ld.GoodToGo;            

            string ext = System.IO.Path.GetExtension(ld.DocumentToLoad).Replace(".","").ToLower();

            if (DoProcess)
            {
                this.Cursor = Cursors.WaitCursor;
                EnableForm(false);
                
               //if (ext == "docx" || ext == "doc")
               //   await TheProject.ProcessIt(ld.DocumentToLoad, ld.ProjectFile, IndexProject.DocumentTypes.Word, ld.WordTypeMapping, !ld.SkipContainsNumbers);
               if (ext == "pdf")
                  await TheProject.ProcessIt(ld.DocumentToLoad, ld.ProjectFile, IndexProject.DocumentTypes.PDF, ld.WordTypeMapping, !ld.SkipContainsNumbers);
                                

                dgvWords.DataSource = TheProject.RawWordList;
                lblWarnings.Text = TheProject.Warnings.Count.ToString() + " Warnings";
                dgvWords.Columns[3].Visible = false;

                lblProcessStatus.Text = "Ready";
                pbBar.Visible = false;

                TheProjectFile = ld.ProjectFile;
                EnableForm(true);
                this.Text = "Corey Lasley's Book Index Builder [" + System.IO.Path.GetFileName(TheProjectFile) + "]";
                this.Cursor = Cursors.Arrow;
            }

                       
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndexDocument id = new IndexDocument();
            id.Show();
            id.GenerateIndex(TheProject.RawWordList);
        }

        private void EnableForm(bool enabled)
        {
            dgvWords.Enabled = enabled;
            dgvPages.Enabled = enabled;
            txtContext.Enabled = enabled;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectNextPage();
        }

        private void btnContextPage_Click(object sender, EventArgs e)
        {
            SelectPage();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            SelectPreviousPage();
        }
                

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings i = new Settings();
            i.ShowDialog();

            if (i.Result == DialogResult.OK)
            {
                Filters f = i.Filter;
            }

            i.Dispose();
        }
        
    }


}
