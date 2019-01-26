using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    /// <summary>
    /// 
    /// Assumptions:
    /// When finding a sequnce of DNA, only the first index of a valid DNA strand should be returned
    /// When finding the longest common strand of DNA between two strings, a new line separates the two input strands
    /// When finding the longest common strand of DNA between two strings, the two strings are valid DNA strands
    /// 
    /// </summary>


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompliment_Click(object sender, EventArgs e)
        {
            // Create the compliment of the given strand
            string compliment = "";
            foreach (char c in txtInput.Text)
            {
                switch (c)
                {
                    case 'A':
                        compliment += "01"; // T = 01
                        break;
                    case 'T':
                        compliment += "00"; // A = 00
                        break;
                    case 'G':
                        compliment += "11"; // C = 11
                        break;
                    case 'C':
                        compliment += "10"; // G = 10
                        break;
                    default:
                        compliment += "Invalid Character"; // something went horribly wrong
                        break;
                }
            }

            // Decode the DNA to ASCII
            // Break the compliment string into substrings of 4 characters
            List<string> splitStr = new List<string>();

            while (compliment.Length > 0)
            {
                splitStr.Add(compliment.Substring(0, 8));
                compliment = compliment.Substring(8);
            }

            string finalResult = "";
            // Convert the binary string to ASCII
            foreach (string str in splitStr)
            {
                int result = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    result += Convert.ToInt32(str.Substring(i, 1));
                    result *= 2;
                }
                result /= 2;
                finalResult += (char)result;
            }
            txtOutput.Text = finalResult;
        }

        private void btnConvertDNA_Click(object sender, EventArgs e)
        {
            // Convert to DNA
            txtOutput.Text = ConvertDNA();
        }

        private void btnConvertRNA_Click(object sender, EventArgs e)
        {
            // Convert to DNA
            string result = ConvertDNA();

            // Replace T with U for RNA
            result = result.Replace("T", "U");

            txtOutput.Text = result;
        }

        private void btnFindCommon_Click(object sender, EventArgs e)
        {
            /*
             * Algorithm:
             * Input strings L1 with length m and L2 with length n
             * Two Cases:
             * The last characters match or they do not match
             * If the last characters match:
             *      Increment the length of LCS by 1 and process L1[m-1] and L2[n-1]
             * If they do not match:
             * 	    Find the max of L1[m-1]L2[n] and L1[m]L2[n-1]
             * Build the subsequence string using the length matrix starting at the bottom right corner
             * If the characters match
             * 	    It is part of the longest subsequence and move diagonally up and left
             * If they do not match
             * 	    Check if the cell to the left or up greater and move to the cell that is greater
             * 	    If they are equal, just move left
             * Reverse the resulting string and output the final result
             */

            // Split the input into two DNA strands and define variables to hold the two strings and the lengths of both
            string[] strands = txtInput.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string strand1 = strands[0];
            string strand2 = strands[1];
            int strand1Length = strand1.Length;
            int strand2Length = strand2.Length;
            int[,] length = new int[strand1Length + 1, strand2Length + 1];

            // Fill the length matrix with the lengths of the longest sebsequence of each character
            for (int i = 0; i <= strand1Length; i++)
            {
                for (int j = 0; j <= strand2Length; j++)
                {
                    if (i == 0 || j == 0) length[i, j] = 0;
                    else if (strand1[i - 1] == strand2[j - 1]) length[i, j] = length[i - 1, j - 1] + 1;
                    else length[i, j] = Math.Max(length[i - 1, j], length[i, j - 1]);
                }
            }

            // Put together the longest subsequence
            string result = "";
            int index = length[strand1Length, strand2Length];
            int k = strand1Length;
            int m = strand2Length;
            while (k > 0 && m > 0)
            {
                if (strand1[k - 1] == strand2[m - 1])
                {
                    // The characters match, move diagonally up and left 
                    result += strand1[k - 1];
                    k--;
                    m--;
                    index--;
                }
                else if (length[k - 1, m] > length[k, m - 1]) k--; // Determine whether to move left or up in the matrix
                else m--; // Just move left
            }

            // Reverse the resulting string and output the final result
            string finalResult = new string(result.Reverse().ToArray());
            txtOutput.Text = finalResult;
        }

        private void btnFindDNA_Click(object sender, EventArgs e)
        {
            // Define a regular expression to match
            Regex regex = new Regex(@"[ATGC]{4,}");

            Match match = regex.Match(txtInput.Text);

            if (match.Success) txtOutput.Text = "index = " + match.Index;
            else txtOutput.Text = "index = -1";
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            txtInput.SelectAll();
        }

        private string ConvertDNA()
        {
            // Convert to ASCII
            byte[] convertedBytes = Encoding.ASCII.GetBytes(txtInput.Text);

            // Convert to byte string
            string resultBytes = "";

            for (int i = 0; i < convertedBytes.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    resultBytes += (convertedBytes[i] & 0x80) > 0 ? "1" : "0";
                    convertedBytes[i] <<= 1;
                }
            }

            // Split byte string into 2-bit substrings
            List<string> splitStr = new List<string>();

            while (resultBytes.Length > 0)
            {
                splitStr.Add(resultBytes.Substring(0, 2));
                resultBytes = resultBytes.Substring(2);
            }

            // Replace each substring of bits to it's DNA encoding character
            string finalResult = "";
            foreach (string str in splitStr)
            {
                switch (str)
                {
                    case "00":
                        finalResult += "A"; // 00
                        break;
                    case "01":
                        finalResult += "T"; // 01
                        break;
                    case "10":
                        finalResult += "G"; // 10 
                        break;
                    case "11":
                        finalResult += "C"; // 11
                        break;
                    default:
                        finalResult += "Invalid Character"; // something went horribly wrong
                        break;
                }
            }
            return finalResult;
        }

    }
}
