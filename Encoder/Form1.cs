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
