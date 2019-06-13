namespace BookIndexMaker
{
    partial class LoadDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadDocument));
            this.txtWordsToIgnore = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.btnLoadDocument = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProjectFile = new System.Windows.Forms.Button();
            this.txtProjectFile = new System.Windows.Forms.TextBox();
            this.chkSkipNumbers = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtWordsToIgnore
            // 
            this.txtWordsToIgnore.Location = new System.Drawing.Point(16, 142);
            this.txtWordsToIgnore.Multiline = true;
            this.txtWordsToIgnore.Name = "txtWordsToIgnore";
            this.txtWordsToIgnore.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWordsToIgnore.Size = new System.Drawing.Size(477, 144);
            this.txtWordsToIgnore.TabIndex = 0;
            this.txtWordsToIgnore.Text = resources.GetString("txtWordsToIgnore.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(16, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(475, 39);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Skip Word Type Mapping (for now.) Note: Word Type Mapping must be performed befor" +
                "e certian types of words can be filtered.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ignore the following words:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(83, 289);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 26);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(16, 29);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(435, 20);
            this.txtDocument.TabIndex = 4;
            // 
            // btnLoadDocument
            // 
            this.btnLoadDocument.Location = new System.Drawing.Point(456, 29);
            this.btnLoadDocument.Name = "btnLoadDocument";
            this.btnLoadDocument.Size = new System.Drawing.Size(35, 20);
            this.btnLoadDocument.TabIndex = 5;
            this.btnLoadDocument.Text = "...";
            this.btnLoadDocument.UseVisualStyleBackColor = true;
            this.btnLoadDocument.Click += new System.EventHandler(this.btnLoadDocument_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File to Index:";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(16, 289);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(64, 26);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(284, 405);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 34);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(392, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Save Project File As:";
            // 
            // btnProjectFile
            // 
            this.btnProjectFile.Location = new System.Drawing.Point(456, 356);
            this.btnProjectFile.Name = "btnProjectFile";
            this.btnProjectFile.Size = new System.Drawing.Size(35, 20);
            this.btnProjectFile.TabIndex = 11;
            this.btnProjectFile.Text = "...";
            this.btnProjectFile.UseVisualStyleBackColor = true;
            this.btnProjectFile.Click += new System.EventHandler(this.btnProjectFile_Click);
            // 
            // txtProjectFile
            // 
            this.txtProjectFile.Location = new System.Drawing.Point(16, 356);
            this.txtProjectFile.Name = "txtProjectFile";
            this.txtProjectFile.Size = new System.Drawing.Size(435, 20);
            this.txtProjectFile.TabIndex = 10;
            // 
            // chkSkipNumbers
            // 
            this.chkSkipNumbers.AutoSize = true;
            this.chkSkipNumbers.Location = new System.Drawing.Point(16, 61);
            this.chkSkipNumbers.Name = "chkSkipNumbers";
            this.chkSkipNumbers.Size = new System.Drawing.Size(230, 17);
            this.chkSkipNumbers.TabIndex = 13;
            this.chkSkipNumbers.Text = "Skip Words Containing Numeric Characters";
            this.chkSkipNumbers.UseVisualStyleBackColor = true;
            // 
            // LoadDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 458);
            this.Controls.Add(this.chkSkipNumbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProjectFile);
            this.Controls.Add(this.txtProjectFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadDocument);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtWordsToIgnore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoadDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Project";
            this.Load += new System.EventHandler(this.LoadDocument_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordsToIgnore;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Button btnLoadDocument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProjectFile;
        private System.Windows.Forms.TextBox txtProjectFile;
        private System.Windows.Forms.CheckBox chkSkipNumbers;
    }
}