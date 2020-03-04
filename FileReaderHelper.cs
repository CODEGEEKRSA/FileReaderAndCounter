using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace FileReaderAndCounter
{
    // This is my File Helper class to read text Files.
    public static class FileReaderHelper
	{
        /// <summary>  
        /// Reading text from text files  
        /// </summary>  
        /// <returns>Text</returns>  
        public static string GetTextFromText(string fileAndPath)  
		{
            string text = string.Empty;
            try
            {
		        text = File.ReadAllText(fileAndPath); 
            }
            catch (Exception TextFromTextException)
            {
                MessageBox.Show("Text file read error occurred! \n\r" + TextFromTextException.Message,
                                "Text file read.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return text;
        }

        /// <summary>  
        /// Count words in text lines from text files  
        /// </summary>  
        /// <returns>Int Count</returns> 
        public static int GetWordCountFromTextFile(string textToWordCount)
		{
			string line;  
			int count = 0;
            try
            {
			    StreamReader file = new StreamReader(textToWordCount);			
			    while ((line = file.ReadLine()) != null)
			    {
                    System.String[] words= line.Split(' ');  
				    count += words.Length;  
			    }  			  
			    file.Close(); 
            }
            catch (Exception TextWordCountFromTextFileException)
            {
                MessageBox.Show("Text word count error occurred! \n\r" + TextWordCountFromTextFileException.Message,
                                "Text word count .",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
			return count;
        }

		/// <summary>  
		/// Split lines and count words occurrences from text  
		/// </summary>  
		/// <returns>Dictionary <String,int></returns> 
        public static Dictionary<string, int> SplitAndCountOccurences(string TextToCountOccurences)
		{
			Dictionary<string, int> frequencies = null;
            try
            {
                string Text = TextToCountOccurences.ToLower();
			    frequencies = new Dictionary<string, int>();
			    string[] words = Regex.Split(Text, "\\W+");
			    foreach (string word in words)
			    {
				    if (frequencies.ContainsKey(word))
				    {
					    frequencies[word] += 1;
				    }
				    else
				    {
					    frequencies[word] = 1;
				    }
			    }

			    foreach (KeyValuePair<string, int> entry in frequencies)
			    {
				    string word = entry.Key;
				    int frequency = entry.Value;
			    }
            }
            catch (Exception TextSplitAndCountOccurencesException)
            {
                MessageBox.Show("Split and count occurrences error occurred! \n\r" + TextSplitAndCountOccurencesException.Message,
                                "Split and count occurrences.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
			return frequencies;
		}
	}
}