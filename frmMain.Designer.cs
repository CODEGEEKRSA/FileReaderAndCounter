namespace FileReaderAndCounter
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.fdlgFileToRead = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblFileDescriptionOfPath = new System.Windows.Forms.Label();
            this.txtFileNameAndPathToRead = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lBoxDuration = new System.Windows.Forms.ListBox();
            this.rtBoxCount = new System.Windows.Forms.RichTextBox();
            this.rtboxFile = new System.Windows.Forms.RichTextBox();
            this.pnlOccurenceCount = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxWordsAndOccurenceCountGreaterThanSix = new System.Windows.Forms.ListBox();
            this.lboxWordsAndOccurenceCount = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlOccurenceCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // fdlgFileToRead
            // 
            this.fdlgFileToRead.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectFile);
            this.panel1.Controls.Add(this.lblFileDescriptionOfPath);
            this.panel1.Controls.Add(this.txtFileNameAndPathToRead);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(545, 6);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(25, 23);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblFileDescriptionOfPath
            // 
            this.lblFileDescriptionOfPath.AutoSize = true;
            this.lblFileDescriptionOfPath.Location = new System.Drawing.Point(1, 10);
            this.lblFileDescriptionOfPath.Name = "lblFileDescriptionOfPath";
            this.lblFileDescriptionOfPath.Size = new System.Drawing.Size(124, 13);
            this.lblFileDescriptionOfPath.TabIndex = 5;
            this.lblFileDescriptionOfPath.Text = "File To Read And Count:";
            // 
            // txtFileNameAndPathToRead
            // 
            this.txtFileNameAndPathToRead.Location = new System.Drawing.Point(126, 8);
            this.txtFileNameAndPathToRead.Name = "txtFileNameAndPathToRead";
            this.txtFileNameAndPathToRead.Size = new System.Drawing.Size(413, 20);
            this.txtFileNameAndPathToRead.TabIndex = 4;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Enabled = false;
            this.btnReadFile.Location = new System.Drawing.Point(439, 12);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(123, 49);
            this.btnReadFile.TabIndex = 3;
            this.btnReadFile.Text = "Read and Process File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lBoxDuration);
            this.panel2.Controls.Add(this.rtBoxCount);
            this.panel2.Controls.Add(this.btnReadFile);
            this.panel2.Location = new System.Drawing.Point(5, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 76);
            this.panel2.TabIndex = 3;
            // 
            // lBoxDuration
            // 
            this.lBoxDuration.FormattingEnabled = true;
            this.lBoxDuration.Location = new System.Drawing.Point(170, 0);
            this.lBoxDuration.Name = "lBoxDuration";
            this.lBoxDuration.Size = new System.Drawing.Size(259, 69);
            this.lBoxDuration.TabIndex = 5;
            // 
            // rtBoxCount
            // 
            this.rtBoxCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtBoxCount.Location = new System.Drawing.Point(2, 3);
            this.rtBoxCount.Name = "rtBoxCount";
            this.rtBoxCount.Size = new System.Drawing.Size(162, 66);
            this.rtBoxCount.TabIndex = 4;
            this.rtBoxCount.Text = "";
            // 
            // rtboxFile
            // 
            this.rtboxFile.Location = new System.Drawing.Point(3, 126);
            this.rtboxFile.Name = "rtboxFile";
            this.rtboxFile.Size = new System.Drawing.Size(576, 322);
            this.rtboxFile.TabIndex = 4;
            this.rtboxFile.Text = "";
            // 
            // pnlOccurenceCount
            // 
            this.pnlOccurenceCount.Controls.Add(this.label2);
            this.pnlOccurenceCount.Controls.Add(this.label1);
            this.pnlOccurenceCount.Controls.Add(this.lboxWordsAndOccurenceCountGreaterThanSix);
            this.pnlOccurenceCount.Controls.Add(this.lboxWordsAndOccurenceCount);
            this.pnlOccurenceCount.Location = new System.Drawing.Point(585, 4);
            this.pnlOccurenceCount.Name = "pnlOccurenceCount";
            this.pnlOccurenceCount.Size = new System.Drawing.Size(380, 444);
            this.pnlOccurenceCount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Top 50 Words with length > 6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top 50 Words";
            // 
            // lboxWordsAndOccurenceCountGreaterThanSix
            // 
            this.lboxWordsAndOccurenceCountGreaterThanSix.FormattingEnabled = true;
            this.lboxWordsAndOccurenceCountGreaterThanSix.Location = new System.Drawing.Point(186, 19);
            this.lboxWordsAndOccurenceCountGreaterThanSix.Name = "lboxWordsAndOccurenceCountGreaterThanSix";
            this.lboxWordsAndOccurenceCountGreaterThanSix.ScrollAlwaysVisible = true;
            this.lboxWordsAndOccurenceCountGreaterThanSix.Size = new System.Drawing.Size(177, 420);
            this.lboxWordsAndOccurenceCountGreaterThanSix.TabIndex = 2;
            // 
            // lboxWordsAndOccurenceCount
            // 
            this.lboxWordsAndOccurenceCount.FormattingEnabled = true;
            this.lboxWordsAndOccurenceCount.Location = new System.Drawing.Point(3, 19);
            this.lboxWordsAndOccurenceCount.Name = "lboxWordsAndOccurenceCount";
            this.lboxWordsAndOccurenceCount.ScrollAlwaysVisible = true;
            this.lboxWordsAndOccurenceCount.Size = new System.Drawing.Size(177, 420);
            this.lboxWordsAndOccurenceCount.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.pnlOccurenceCount);
            this.Controls.Add(this.rtboxFile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Comcorp Assesment:";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlOccurenceCount.ResumeLayout(false);
            this.pnlOccurenceCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fdlgFileToRead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFileDescriptionOfPath;
        private System.Windows.Forms.TextBox txtFileNameAndPathToRead;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.RichTextBox rtboxFile;
        private System.Windows.Forms.RichTextBox rtBoxCount;
        private System.Windows.Forms.Panel pnlOccurenceCount;
        private System.Windows.Forms.ListBox lboxWordsAndOccurenceCount;
        private System.Windows.Forms.ListBox lBoxDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxWordsAndOccurenceCountGreaterThanSix;
    }
}

