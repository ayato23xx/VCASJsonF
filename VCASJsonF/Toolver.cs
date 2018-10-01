using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCASJsonF
{
    public partial class Toolver : Form
    {
        public Toolver()
        {
            InitializeComponent();
        }
        string var_Str;

        private void Toolver_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            System.Diagnostics.FileVersionInfo var = 
                System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location);
            //MessageBox.Show(var_Str = var.FileVersion);
            var_Str = var.FileVersion;
            label2.Text = var_Str;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
