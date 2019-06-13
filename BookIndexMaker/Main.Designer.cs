namespace BookIndexMaker
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtContext = new System.Windows.Forms.RichTextBox();
            this.cmsWordHighlight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGoToSelectedWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoBackToPreviousWord = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.Include = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvPages = new System.Windows.Forms.DataGridView();
            this.IncludePage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEditPage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProcessStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWarnings = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGotoWord = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPagesTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContext = new System.Windows.Forms.Label();
            this.btnCrossReference = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.btnCombine = new System.Windows.Forms.Button();
            this.btnContextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGenerateIndex = new System.Windows.Forms.Button();
            this.cmsPageReferences = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCopyReferenceData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPasteReferenceData = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cmsWordHighlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPages)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cmsPageReferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(738, 51);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(132, 32);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Visible = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtContext
            // 
            this.txtContext.ContextMenuStrip = this.cmsWordHighlight;
            this.txtContext.Location = new System.Drawing.Point(12, 393);
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(720, 207);
            this.txtContext.TabIndex = 3;
            this.txtContext.Text = "";
            // 
            // cmsWordHighlight
            // 
            this.cmsWordHighlight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGoToSelectedWord,
            this.mnuGoBackToPreviousWord});
            this.cmsWordHighlight.Name = "cmsWordHighlight";
            this.cmsWordHighlight.Size = new System.Drawing.Size(219, 48);
            this.cmsWordHighlight.Opening += new System.ComponentModel.CancelEventHandler(this.cmsWordHighlight_Opening);
            // 
            // mnuGoToSelectedWord
            // 
            this.mnuGoToSelectedWord.Name = "mnuGoToSelectedWord";
            this.mnuGoToSelectedWord.Size = new System.Drawing.Size(218, 22);
            this.mnuGoToSelectedWord.Text = "Go to selected word...";
            this.mnuGoToSelectedWord.Click += new System.EventHandler(this.mnuGoToSelectedWord_Click);
            // 
            // mnuGoBackToPreviousWord
            // 
            this.mnuGoBackToPreviousWord.Name = "mnuGoBackToPreviousWord";
            this.mnuGoBackToPreviousWord.Size = new System.Drawing.Size(218, 22);
            this.mnuGoBackToPreviousWord.Text = "Go back to previous word...";
            this.mnuGoBackToPreviousWord.Click += new System.EventHandler(this.mnuGoBackToPreviousWord_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Dictionary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvWords
            // 
            this.dgvWords.AllowUserToAddRows = false;
            this.dgvWords.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvWords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Include});
            this.dgvWords.Location = new System.Drawing.Point(12, 51);
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.RowHeadersVisible = false;
            this.dgvWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWords.Size = new System.Drawing.Size(546, 274);
            this.dgvWords.TabIndex = 7;
            this.dgvWords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_CellContentClick);
            this.dgvWords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_CellDoubleClick);
            this.dgvWords.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_CellValueChanged);
            this.dgvWords.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvWords_CurrentCellDirtyStateChanged);
            this.dgvWords.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_RowEnter);
            // 
            // Include
            // 
            this.Include.HeaderText = "";
            this.Include.Name = "Include";
            this.Include.Width = 25;
            // 
            // dgvPages
            // 
            this.dgvPages.AllowUserToAddRows = false;
            this.dgvPages.AllowUserToDeleteRows = false;
            this.dgvPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPages.ColumnHeadersVisible = false;
            this.dgvPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncludePage,
            this.clmEditPage});
            this.dgvPages.Location = new System.Drawing.Point(564, 51);
            this.dgvPages.Name = "dgvPages";
            this.dgvPages.RowHeadersVisible = false;
            this.dgvPages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPages.Size = new System.Drawing.Size(168, 274);
            this.dgvPages.TabIndex = 8;
            this.dgvPages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPages_CellContentClick);
            this.dgvPages.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPages_CellValueChanged);
            this.dgvPages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPages_RowEnter);
            // 
            // IncludePage
            // 
            this.IncludePage.HeaderText = "";
            this.IncludePage.Name = "IncludePage";
            this.IncludePage.Width = 25;
            // 
            // clmEditPage
            // 
            this.clmEditPage.HeaderText = "";
            this.clmEditPage.Name = "clmEditPage";
            this.clmEditPage.Text = "...";
            this.clmEditPage.UseColumnTextForButtonValue = true;
            this.clmEditPage.Width = 25;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbBar,
            this.lblProcessStatus,
            this.lblWarnings});
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(743, 30);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbBar
            // 
            this.pbBar.Name = "pbBar";
            this.pbBar.Size = new System.Drawing.Size(100, 24);
            // 
            // lblProcessStatus
            // 
            this.lblProcessStatus.AutoSize = false;
            this.lblProcessStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblProcessStatus.Name = "lblProcessStatus";
            this.lblProcessStatus.Padding = new System.Windows.Forms.Padding(3);
            this.lblProcessStatus.Size = new System.Drawing.Size(249, 25);
            this.lblProcessStatus.Text = "Ready";
            this.lblProcessStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWarnings
            // 
            this.lblWarnings.AutoSize = false;
            this.lblWarnings.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblWarnings.DoubleClickEnabled = true;
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Padding = new System.Windows.Forms.Padding(3);
            this.lblWarnings.Size = new System.Drawing.Size(100, 25);
            this.lblWarnings.Text = "0 Warnings";
            this.lblWarnings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWarnings.DoubleClick += new System.EventHandler(this.lblWarnings_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.openToolStripMenuItem,
            this.mnuSave,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(155, 22);
            this.mnuNew.Text = "New...";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(155, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(155, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateIndex,
            this.toolStripMenuItem2,
            this.mnuGotoWord,
            this.filtersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuGenerateIndex
            // 
            this.mnuGenerateIndex.Name = "mnuGenerateIndex";
            this.mnuGenerateIndex.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuGenerateIndex.Size = new System.Drawing.Size(189, 22);
            this.mnuGenerateIndex.Text = "Generate Index";
            this.mnuGenerateIndex.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 6);
            // 
            // mnuGotoWord
            // 
            this.mnuGotoWord.Name = "mnuGotoWord";
            this.mnuGotoWord.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuGotoWord.Size = new System.Drawing.Size(189, 22);
            this.mnuGotoWord.Text = "Goto Word...";
            this.mnuGotoWord.Click += new System.EventHandler(this.mnuGotoWord_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.filtersToolStripMenuItem.Text = "Filters...";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuAbout.Text = "About...";
            // 
            // lblPagesTitle
            // 
            this.lblPagesTitle.AutoSize = true;
            this.lblPagesTitle.Location = new System.Drawing.Point(561, 35);
            this.lblPagesTitle.Name = "lblPagesTitle";
            this.lblPagesTitle.Size = new System.Drawing.Size(35, 13);
            this.lblPagesTitle.TabIndex = 11;
            this.lblPagesTitle.Text = "Page:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Word List:";
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Location = new System.Drawing.Point(9, 377);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(74, 13);
            this.lblContext.TabIndex = 13;
            this.lblContext.Text = "Page Context:";
            // 
            // btnCrossReference
            // 
            this.btnCrossReference.Location = new System.Drawing.Point(10, 327);
            this.btnCrossReference.Name = "btnCrossReference";
            this.btnCrossReference.Size = new System.Drawing.Size(131, 32);
            this.btnCrossReference.TabIndex = 14;
            this.btnCrossReference.Text = "Cross Reference...";
            this.btnCrossReference.UseVisualStyleBackColor = true;
            // 
            // btnFilters
            // 
            this.btnFilters.Location = new System.Drawing.Point(738, 85);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(132, 32);
            this.btnFilters.TabIndex = 15;
            this.btnFilters.Text = "Filters...";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Visible = false;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // btnCombine
            // 
            this.btnCombine.Enabled = false;
            this.btnCombine.Location = new System.Drawing.Point(143, 327);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(131, 32);
            this.btnCombine.TabIndex = 16;
            this.btnCombine.Text = "Combine...";
            this.btnCombine.UseVisualStyleBackColor = true;
            // 
            // btnContextPage
            // 
            this.btnContextPage.Location = new System.Drawing.Point(12, 602);
            this.btnContextPage.Name = "btnContextPage";
            this.btnContextPage.Size = new System.Drawing.Size(131, 32);
            this.btnContextPage.TabIndex = 17;
            this.btnContextPage.Text = "Context Page";
            this.btnContextPage.UseVisualStyleBackColor = true;
            this.btnContextPage.Click += new System.EventHandler(this.btnContextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(145, 602);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(131, 32);
            this.btnPreviousPage.TabIndex = 18;
            this.btnPreviousPage.Text = "< Previous Page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 602);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 32);
            this.button4.TabIndex = 19;
            this.button4.Text = "Next Page >";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGenerateIndex
            // 
            this.btnGenerateIndex.Location = new System.Drawing.Point(738, 119);
            this.btnGenerateIndex.Name = "btnGenerateIndex";
            this.btnGenerateIndex.Size = new System.Drawing.Size(132, 32);
            this.btnGenerateIndex.TabIndex = 20;
            this.btnGenerateIndex.Text = "Generate Index";
            this.btnGenerateIndex.UseVisualStyleBackColor = true;
            this.btnGenerateIndex.Visible = false;
            this.btnGenerateIndex.Click += new System.EventHandler(this.btnGenerateIndex_Click);
            // 
            // cmsPageReferences
            // 
            this.cmsPageReferences.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopyReferenceData,
            this.mnuPasteReferenceData});
            this.cmsPageReferences.Name = "cmsPageReferences";
            this.cmsPageReferences.Size = new System.Drawing.Size(185, 48);
            // 
            // mnuCopyReferenceData
            // 
            this.mnuCopyReferenceData.Name = "mnuCopyReferenceData";
            this.mnuCopyReferenceData.Size = new System.Drawing.Size(184, 22);
            this.mnuCopyReferenceData.Text = "Copy Reference Data";
            // 
            // mnuPasteReferenceData
            // 
            this.mnuPasteReferenceData.Name = "mnuPasteReferenceData";
            this.mnuPasteReferenceData.Size = new System.Drawing.Size(184, 22);
            this.mnuPasteReferenceData.Text = "Paste Reference Data";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.button5.Location = new System.Drawing.Point(562, 327);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 22);
            this.button5.TabIndex = 22;
            this.button5.Text = "Select All";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.button6.Location = new System.Drawing.Point(633, 327);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 22);
            this.button6.TabIndex = 23;
            this.button6.Text = "De-Select All";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 681);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnContextPage);
            this.Controls.Add(this.btnCombine);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.lblPagesTitle);
            this.Controls.Add(this.btnGenerateIndex);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCrossReference);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvPages);
            this.Controls.Add(this.dgvWords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtContext);
            this.Controls.Add(this.btnProcess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corey Lasley\'s Book Index Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsWordHighlight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPages)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsPageReferences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RichTextBox txtContext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.DataGridView dgvPages;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblProcessStatus;
        private System.Windows.Forms.ToolStripProgressBar pbBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateIndex;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblPagesTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Include;
        private System.Windows.Forms.Button btnCrossReference;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.ContextMenuStrip cmsWordHighlight;
        private System.Windows.Forms.ToolStripMenuItem mnuGoToSelectedWord;
        private System.Windows.Forms.ToolStripMenuItem mnuGoBackToPreviousWord;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IncludePage;
        private System.Windows.Forms.DataGridViewButtonColumn clmEditPage;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.Button btnContextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGenerateIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuGotoWord;
        private System.Windows.Forms.ContextMenuStrip cmsPageReferences;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyReferenceData;
        private System.Windows.Forms.ToolStripMenuItem mnuPasteReferenceData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripStatusLabel lblWarnings;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}

