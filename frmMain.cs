using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReaderAndCounter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // read text file for processing
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            DateTime end;

            // reset all list boxes
            lboxWordsAndOccurenceCountGreaterThanSix.Items.Clear();
            lboxWordsAndOccurenceCount.Items.Clear();
            lBoxDuration.Items.Clear();

            DateTime start = DateTime.Now;
            lBoxDuration.Items.Add("Start Time: " + start.ToLongTimeString());

            // check if there is an input before processing starts
            if (!string.IsNullOrEmpty(txtFileNameAndPathToRead.Text) || !string.IsNullOrWhiteSpace(txtFileNameAndPathToRead.Text))
            {
                rtboxFile.Text = FileReaderHelper.GetTextFromText(txtFileNameAndPathToRead.Text);
                rtBoxCount.Text = "Lines in File : " + rtboxFile.Lines.Count();
                rtBoxCount.Text += "\nWords in File : " + FileReaderHelper.GetWordCountFromTextFile(txtFileNameAndPathToRead.Text);
                var resultOccurenceCount = FileReaderHelper.SplitAndCountOccurences(rtboxFile.Text);

                //now loop and get occurrence count order by descending and return top 50
                var items = (from word in resultOccurenceCount
                             orderby word.Value descending
                             select word).Take(50);

                foreach (KeyValuePair<string, int> entry in items)
                {
                    lboxWordsAndOccurenceCount.Items.Add($"{entry.Key} occurred {entry.Value} times.");
                }

                /////now loop and get occurrence count of words > 6 characters and return top 50
                var itemsOccurenceCount = (from word in resultOccurenceCount
                                            where word.Key.Length > 6
                                            orderby word.Value descending
                                            select word).Take(50);

                foreach (KeyValuePair<string, int> entry in itemsOccurenceCount)
                {
                    lboxWordsAndOccurenceCountGreaterThanSix.Items.Add($"{entry.Key} occurred {entry.Value} times.");
                }
            }
            else
            {
                MessageBox.Show("Please select a file to process and count!", 
                                "File Selection required to process.",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            end = DateTime.Now;
            lBoxDuration.Items.Add("End Time: " + end.ToLongTimeString());
            lBoxDuration.Items.Add($"Overall Process Time: {(Convert.ToDateTime(end) - Convert.ToDateTime(start)).TotalSeconds.ToString()} seconds");
            MessageBox.Show($"Processing and counts completed! \n\r {(Convert.ToDateTime(end) - Convert.ToDateTime(start)).TotalSeconds.ToString()} seconds",
                            "File Selection required to process.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // select file to process for line, word count and occurrences.
        private void btnSelectFile_Click(object sender, EventArgs e)
        {           
            fdlgFileToRead.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Files";
            fdlgFileToRead.Filter = "txt files (*.txt)|*.txt";
            fdlgFileToRead.FileName = "";
            DialogResult f = fdlgFileToRead.ShowDialog();           
            if (f == DialogResult.OK)
            {
                txtFileNameAndPathToRead.Text = fdlgFileToRead.FileName;
                btnReadFile.Enabled = true;
            }
        }
    }
}