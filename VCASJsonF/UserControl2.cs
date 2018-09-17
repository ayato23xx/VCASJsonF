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
    public partial class UserControl2 : UserControl
    {
        //アバター格納用配列作成
        string[] Avatar = new string[16];
        public UserControl2()
        {
            InitializeComponent();
            //pictureBox1.ImageLocation = "http://tn.smilevideo.jp/smile?i=9";
        }

        //次のページへ遷移するときの挙動
        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ctr2.Visible = false;
            Form1.ctr3.Visible = true;
        }

        //確認用
        private void button1_Click(object sender, EventArgs e)
        {
            //変数に入力された数値をSETする
            Avatar[0] = textBox1.Text;
            Avatar[1] = textBox2.Text;
            Avatar[2] = textBox3.Text;
            Avatar[3] = textBox4.Text;
            Avatar[4] = textBox5.Text;
            Avatar[5] = textBox6.Text;
            Avatar[6] = textBox7.Text;
            Avatar[7] = textBox8.Text;
            Avatar[8] = textBox9.Text;
            Avatar[9] = textBox10.Text;
            Avatar[10] = textBox11.Text;
            Avatar[11] = textBox12.Text;
            Avatar[12] = textBox13.Text;
            Avatar[13] = textBox14.Text;
            Avatar[14] = textBox15.Text;
            Avatar[15] = textBox16.Text;
            //デバッグ用
            //label3.Text = Avatar[13];

            //アバター確認画面を開く
            Avatarkakunin avatarkakunin = new Avatarkakunin();
            avatarkakunin.Show();
            
        }
    }
}
