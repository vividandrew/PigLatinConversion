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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (input == "") { return; }

            PigLatin output = new PigLatin(input);

            txtOutput.Text = output.ToString();
        }
    }
}
