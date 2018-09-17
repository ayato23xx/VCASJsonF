using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCASJsonF
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ctr1.Visible = false;
            Form1.ctr2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.textBox1.ReadOnly = true;
            textBox1.Enabled = false;
            textBox1.BackColor = textBox1.BackColor;
        }
    }
}
