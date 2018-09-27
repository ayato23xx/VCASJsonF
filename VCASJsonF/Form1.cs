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

        public Form1()
        {
            InitializeComponent();

            //newする
            ctr1 = new UserControl1();
            ctr2 = new UserControl2();
            //パネルにユーザーコントロールを貼りつける
            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            //ユーザーコントロール１だけをアクティブ化、それ以外は非アクティブ化
            ctr1.Visible = true;
            ctr2.Visible = false;
        }

        public static object Form1Instance { get; internal set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //ツールのヘルプ画面を開く
        private void ツールについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toolver toolver = new Toolver();
            toolver.Show();
        }
        //ツールを終了させる
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
