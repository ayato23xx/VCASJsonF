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
        string Haikei_H;

        //SETGETに送るデータ格納配列
        private string[] avatar_1 = new string[16];
        private string[] avatar_2 = new string[16];

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
            Haikei_H = textBox17.Text;

            UserControl4 usc4 = new UserControl4();
            usc4.SendData = Avatar[0];
            usc4.SendData2 = Avatar[1];
            usc4.SendData3 = Avatar[2];
            usc4.SendData4 = Avatar[3];
            usc4.SendData5 = Avatar[4];
            usc4.SendData6 = Avatar[5];
            usc4.SendData7 = Avatar[6];
            usc4.SendData8 = Avatar[7];
            usc4.SendData9 = Avatar[8];
            usc4.SendData10 = Avatar[9];
            usc4.SendData11 = Avatar[10];
            usc4.SendData12 = Avatar[11];
            usc4.SendData13 = Avatar[12];
            usc4.SendData14 = Avatar[13];
            usc4.SendData15 = Avatar[14];
            usc4.SendData16 = Avatar[15];
            usc4.SendData17 = Haikei_H;

            //画面遷移
            Form1.ctr2.Visible = false;
            Form1.ctr3.Visible = true;
        }
        
        //確認用
        private void button1_Click(object sender, EventArgs e)
        {
            //変数に入力された数値をSETする
            for (int avatarLoop = 1; avatarLoop <= 16; avatarLoop++) {
               Avatar[avatarLoop-1] = this.Controls["textbox" + avatarLoop.ToString()].Text;
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


        //GETSET送るメソッド
        public string Avatar_1 {
            set {avatar_1[0] = value;}
            get {return Avatar_1;}
        }
        public string Avatar_2 {
            set {avatar_1[1] = value;}
            get { return Avatar_2;}
        }
        public string Avatar_3 {
            set { avatar_1[2] = value; }
            get { return Avatar_3; }
        }
        public string Avatar_4 {
            set { avatar_1[3] = value; }
            get { return Avatar_4; }
        }
        public string Avatar_5 {
            set { avatar_1[4] = value; }
            get { return Avatar_5; }
        }
        public string Avatar_6
        {
            set { avatar_1[5] = value; }
            get { return Avatar_6; }
        }
        public string Avatar_7
        {
            set { avatar_1[6] = value; }
            get { return Avatar_7; }
        }
        public string Avatar_8
        {
            set { avatar_1[7] = value; }
            get { return Avatar_8; }
        }
        public string Avatar_9
        {
            set { avatar_1[8] = value; }
            get { return Avatar_9; }
        }
        public string Avatar_10
        {
            set { avatar_1[9] = value; }
            get { return Avatar_10; }
        }
        public string Avatar_11
        {
            set { avatar_1[10] = value; }
            get { return Avatar_11; }
        }
        public string Avatar_12
        {
            set { avatar_1[11] = value; }
            get { return Avatar_12; }
        }
        public string Avatar_13
        {
            set { avatar_1[12] = value; }
            get { return Avatar_13; }
        }
        public string Avatar_14
        {
            set { avatar_1[13] = value; }
            get { return Avatar_14; }
        }
        public string Avatar_15
        {
            set { avatar_1[14] = value; }
            get { return Avatar_15; }
        }
        public string Avatar_16
        {
            set { avatar_1[15] = value; }
            get { return Avatar_16; }
        }
        public string Haikei
        {
            set { Haikei_H = value; }
            get { return Haikei; }
        }
    }
}
