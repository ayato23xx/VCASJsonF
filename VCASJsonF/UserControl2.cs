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

        //SETGETに送るデータ格納配列
        private string[] avatar_1 = new string[16];

        public UserControl2()
        {
            InitializeComponent();
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
            for (int avatarLoop = 1; avatarLoop <= 16; avatarLoop++) {
               Avatar[avatarLoop-1] = this.Controls["textbox" + avatarLoop.ToString()].Text;
            }

            //アバター確認画面を開く           
            Avatarkakunin avatarkakunin = new Avatarkakunin();
            avatarkakunin.SendData = Avatar[0];
            avatarkakunin.SendData2 = Avatar[1];
            avatarkakunin.SendData3 = Avatar[2];
            avatarkakunin.SendData4 = Avatar[3];
            avatarkakunin.SendData5 = Avatar[4];
            avatarkakunin.SendData6 = Avatar[5];
            avatarkakunin.SendData7 = Avatar[6];
            avatarkakunin.SendData8 = Avatar[7];
            avatarkakunin.SendData9 = Avatar[8];
            avatarkakunin.SendData10 = Avatar[9];
            avatarkakunin.SendData11 = Avatar[10];
            avatarkakunin.SendData12 = Avatar[11];
            avatarkakunin.SendData13 = Avatar[12];
            avatarkakunin.SendData14 = Avatar[13];
            avatarkakunin.SendData15 = Avatar[14];
            avatarkakunin.SendData16 = Avatar[15];

            avatarkakunin.Show();          
        }

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

    }
}
