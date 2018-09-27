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
        //仮変数
        int txt1 = 0;

        //SETGETに送るデータ格納配列
        private string[] avatar_1 = new string[16];

        public UserControl2()
        {
            InitializeComponent();
        }

        //次のページへ遷移するときの挙動
        private void button2_Click(object sender, EventArgs e)
        {
            for (int avatar_L = 1;avatar_L<=16;avatar_L++)
            {
                Avatar[avatar_L - 1] = this.Controls["textbox" + avatar_L.ToString()].Text;
            }
            /*
            UserControl4 ucr4 = new UserControl4();
            ucr4.SendData = Avatar[0];
            ucr4.SendData2 = Avatar[1];
            ucr4.SendData3 = Avatar[2];
            ucr4.SendData4 = Avatar[3];
            ucr4.SendData5 = Avatar[4];
            ucr4.SendData6 = Avatar[5];
            ucr4.SendData7 = Avatar[6];
            ucr4.SendData8 = Avatar[7];
            ucr4.SendData9 = Avatar[8];
            ucr4.SendData10 = Avatar[9];
            ucr4.SendData11 = Avatar[10];
            ucr4.SendData12 = Avatar[11];
            ucr4.SendData13 = Avatar[12];
            ucr4.SendData14 = Avatar[13];
            ucr4.SendData15 = Avatar[14];
            ucr4.SendData16 = Avatar[15];
            Form1.ctr2.Visible = false;
            Form1.ctr4.Visible = true;
            */
        }
        
        //確認用
        private void button1_Click(object sender, EventArgs e)
        {
            //変数に入力された数値をSETする
            for (int avatarLoop = 1; avatarLoop <= 16; avatarLoop++)
            {
                Avatar[avatarLoop - 1] = this.Controls["textbox" + avatarLoop.ToString()].Text;
            }

            //エラーチェック
            if (int.TryParse(textBox1.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。","メッセージ");
            }
            else if (int.TryParse(textBox2.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox3.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox4.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox5.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox6.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox7.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox8.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox9.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox10.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox11.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox12.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox13.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox14.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox15.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }
            else if (int.TryParse(textBox16.Text, out txt1) == false)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
            }

                Avatarkakunin akg = new Avatarkakunin();
                akg.SendData = Avatar[0];
                akg.SendData2 = Avatar[1];
                akg.SendData3 = Avatar[2];
                akg.SendData4 = Avatar[3];
                akg.SendData5 = Avatar[4];
                akg.SendData6 = Avatar[5];
                akg.SendData7 = Avatar[6];
                akg.SendData8 = Avatar[7];
                akg.SendData9 = Avatar[8];
                akg.SendData10 = Avatar[9];
                akg.SendData11 = Avatar[10];
                akg.SendData12 = Avatar[11];
                akg.SendData13 = Avatar[12];
                akg.SendData14 = Avatar[13];
                akg.SendData15 = Avatar[14];
                akg.SendData16 = Avatar[15];
                //アバター確認画面を開く
                akg.Show();     
        }
    }
}
