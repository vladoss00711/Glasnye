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

namespace Glasnye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KnowBtn_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower().Trim();
            Vowel vowel = new Vowel(text);
        }
    }
}
