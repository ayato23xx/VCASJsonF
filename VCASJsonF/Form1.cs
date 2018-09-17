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
    public partial class Form1 : Form
    {
        //ユーザーコントロールのインスタンス化
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;
        public static UserControl3 ctr3;
        public static UserControl4 ctr4;

        public Form1()
        {
            InitializeComponent();

            //newする
            ctr1 = new UserControl1();
            ctr2 = new UserControl2();
            ctr3 = new UserControl3();
            ctr4 = new UserControl4();
            //パネルにユーザーコントロールを貼りつける
            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            panel1.Controls.Add(ctr3);
            panel1.Controls.Add(ctr4);
            //ユーザーコントロール１だけをアクティブ化、それ以外は非アクティブ化
            ctr1.Visible = true;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = false;
        }

        public static object Form1Instance { get; internal set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ツールについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toolver toolver = new Toolver();
            toolver.Show();
        }
    }
}
