using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReplacementTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {

            string syn1 = searchBox_1.Text;

            string rep1 = replacementBox_1.Text;
            
            string textoutp = TextInputBox.Text.Replace(syn1, rep1);

            TextOutputBox.Text = textoutp;
        }
    }
}
