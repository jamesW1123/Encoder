using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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
