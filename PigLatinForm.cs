using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class PigLatinForm : Form
    {
        const string pigSuffix = "ay";

        public PigLatinForm()
        {
            InitializeComponent();
        }

        private void PigLatinForm_Load(object sender, EventArgs e)
        {

        }

        private void tanslateButton_Click(object sender, EventArgs e)
        {
            string translation = "";
            string input = inputTextBox.Text;
            string[] temporaryInput = input.Split(' ');

            for (var i = 0; i < temporaryInput.Length; i++)
            {
                translation += GetPigLatin(temporaryInput[i]);
            }

            outputTextBox.Text += translation + Environment.NewLine;
        }

        private string GetPigLatin(string input)
        {
            string word;
            string firstLetter = input.Substring(0, 1);

            word = input.Substring(1) + firstLetter + pigSuffix + " "; 

            return word;  

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
