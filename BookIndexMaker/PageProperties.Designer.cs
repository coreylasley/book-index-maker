namespace BookIndexMaker
{
    partial class PageProperties
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstOtherIndexes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboIndexAs = new System.Windows.Forms.ComboBox();
            this.lstIndexes = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddAnother = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Other Indexed Words on this Page (reference):";
            // 
            // lstOtherIndexes
            // 
            this.lstOtherIndexes.FormattingEnabled = true;
            this.lstOtherIndexes.Location = new System.Drawing.Point(15, 282);
            this.lstOtherIndexes.Name = "lstOtherIndexes";
            this.lstOtherIndexes.Size = new System.Drawing.Size(302, 121);
            this.lstOtherIndexes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Page:";
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(18, 30);
            this.txtPage.Name = "txtPage";
            this.txtPage.ReadOnly = true;
            this.txtPage.Size = new System.Drawing.Size(84, 20);
            this.txtPage.TabIndex = 3;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(107, 30);
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(210, 20);
            this.txtWord.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Word:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Index this Word as:";
            // 
            // cboIndexAs
            // 
            this.cboIndexAs.FormattingEnabled = true;
            this.cboIndexAs.Location = new System.Drawing.Point(15, 120);
            this.cboIndexAs.Name = "cboIndexAs";
            this.cboIndexAs.Size = new System.Drawing.Size(209, 21);
            this.cboIndexAs.TabIndex = 8;
            // 
            // lstIndexes
            // 
            this.lstIndexes.FormattingEnabled = true;
            this.lstIndexes.Location = new System.Drawing.Point(18, 167);
            this.lstIndexes.Name = "lstIndexes";
            this.lstIndexes.Size = new System.Drawing.Size(302, 82);
            this.lstIndexes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "This Word will also be Indexed as the following:";
            // 
            // btnAddAnother
            // 
            this.btnAddAnother.Location = new System.Drawing.Point(230, 120);
            this.btnAddAnother.Name = "btnAddAnother";
            this.btnAddAnother.Size = new System.Drawing.Size(84, 21);
            this.btnAddAnother.TabIndex = 11;
            this.btnAddAnother.Text = "Add Another";
            this.btnAddAnother.UseVisualStyleBackColor = true;
            this.btnAddAnother.Click += new System.EventHandler(this.btnAddAnother_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(161, 421);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 29);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(15, 74);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(209, 21);
            this.cboCategory.TabIndex = 15;
            this.cboCategory.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Index Under (Parent/Category):";
            this.label6.Visible = false;
            // 
            // PageProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 466);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAddAnother);
            this.Controls.Add(this.lstIndexes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboIndexAs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstOtherIndexes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PageProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Word Reference on Page";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PageProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOtherIndexes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboIndexAs;
        private System.Windows.Forms.ListBox lstIndexes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddAnother;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label6;
    }
}