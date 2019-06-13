namespace BookIndexMaker
{
    partial class Settings
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExcludeWords = new System.Windows.Forms.RichTextBox();
            this.chkLettersAndNumbers = new System.Windows.Forms.CheckBox();
            this.chkNumeric = new System.Windows.Forms.CheckBox();
            this.chkCapitalLetter = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIncludeWords = new System.Windows.Forms.RichTextBox();
            this.chkDictionaryExclusion = new System.Windows.Forms.CheckedListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(346, 396);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(535, 385);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtExcludeWords);
            this.tabPage1.Controls.Add(this.chkLettersAndNumbers);
            this.tabPage1.Controls.Add(this.chkNumeric);
            this.tabPage1.Controls.Add(this.chkCapitalLetter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(527, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Inclusions/Exclusions ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Always exclude the following words:";
            // 
            // txtExcludeWords
            // 
            this.txtExcludeWords.Location = new System.Drawing.Point(11, 128);
            this.txtExcludeWords.Name = "txtExcludeWords";
            this.txtExcludeWords.Size = new System.Drawing.Size(502, 185);
            this.txtExcludeWords.TabIndex = 3;
            this.txtExcludeWords.Text = "";
            // 
            // chkLettersAndNumbers
            // 
            this.chkLettersAndNumbers.AutoSize = true;
            this.chkLettersAndNumbers.Location = new System.Drawing.Point(15, 64);
            this.chkLettersAndNumbers.Name = "chkLettersAndNumbers";
            this.chkLettersAndNumbers.Size = new System.Drawing.Size(273, 17);
            this.chkLettersAndNumbers.TabIndex = 2;
            this.chkLettersAndNumbers.Text = "Exclude words that contain both letters and numbers";
            this.chkLettersAndNumbers.UseVisualStyleBackColor = true;
            this.chkLettersAndNumbers.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Location = new System.Drawing.Point(15, 41);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(203, 17);
            this.chkNumeric.TabIndex = 1;
            this.chkNumeric.Text = "Exclude words that are 100% numeric";
            this.chkNumeric.UseVisualStyleBackColor = true;
            // 
            // chkCapitalLetter
            // 
            this.chkCapitalLetter.AutoSize = true;
            this.chkCapitalLetter.Location = new System.Drawing.Point(15, 18);
            this.chkCapitalLetter.Name = "chkCapitalLetter";
            this.chkCapitalLetter.Size = new System.Drawing.Size(249, 17);
            this.chkCapitalLetter.TabIndex = 0;
            this.chkCapitalLetter.Text = "Include only words that start with a capital letter";
            this.chkCapitalLetter.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtIncludeWords);
            this.tabPage2.Controls.Add(this.chkDictionaryExclusion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(527, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dictionary Inclusions/Exclusions ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exclude words that are:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exceptions (specific words to include):";
            // 
            // txtIncludeWords
            // 
            this.txtIncludeWords.Location = new System.Drawing.Point(213, 31);
            this.txtIncludeWords.Name = "txtIncludeWords";
            this.txtIncludeWords.Size = new System.Drawing.Size(300, 289);
            this.txtIncludeWords.TabIndex = 1;
            this.txtIncludeWords.Text = "";
            // 
            // chkDictionaryExclusion
            // 
            this.chkDictionaryExclusion.CheckOnClick = true;
            this.chkDictionaryExclusion.FormattingEnabled = true;
            this.chkDictionaryExclusion.Items.AddRange(new object[] {
            "Nouns (n.)",
            "Verbs (Standard) (v. / vb.)",
            "Verbs Transitive (v. t.)",
            "Verbs Intransitive (v. i.)",
            "Adjectives (a. / adj.)",
            "Adverbs (adv.)",
            "Pronouns (pn.)",
            "Prepositions (prep.)",
            "Imperatives (imp.)",
            "Conjunctions (conj.)",
            "Present Participles (p. pr.)",
            "Past Participles (p.p.)",
            "Superlatives (superl.)",
            "Subjunctives (subj.)",
            "Interjections (interj.)",
            "Comparatives (compar.)",
            "Datives (dat.)",
            "Definites (def.)"});
            this.chkDictionaryExclusion.Location = new System.Drawing.Point(12, 31);
            this.chkDictionaryExclusion.Name = "chkDictionaryExclusion";
            this.chkDictionaryExclusion.Size = new System.Drawing.Size(194, 289);
            this.chkDictionaryExclusion.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.button6.Location = new System.Drawing.Point(83, 325);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 22);
            this.button6.TabIndex = 25;
            this.button6.Text = "De-Select All";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.button5.Location = new System.Drawing.Point(12, 325);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 22);
            this.button5.TabIndex = 24;
            this.button5.Text = "Select All";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filters";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtIncludeWords;
        private System.Windows.Forms.CheckedListBox chkDictionaryExclusion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkLettersAndNumbers;
        private System.Windows.Forms.CheckBox chkNumeric;
        private System.Windows.Forms.CheckBox chkCapitalLetter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtExcludeWords;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}