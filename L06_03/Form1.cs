using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L06_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblOut.ForeColor= Color.Black;
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblOut.ForeColor = Color.Blue;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblOut.ForeColor = Color.Red;
        }

        private void grayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblOut.BackColor = Color.Gray;
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblOut.BackColor = Color.White;
        }
    }
}
