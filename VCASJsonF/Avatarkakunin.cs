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
    public partial class Avatarkakunin : Form
    {

        //GetSet用配列宣言
        private string[] sendData = new string[16];

        public Avatarkakunin()
        {
            InitializeComponent();
        }

        public string SendData {
            set {
                sendData[0] = value;
                //avaLabel1.Text = sendData[0];
            }            
        }
        public string SendData2 {
            set {
                sendData[1] = value;
                //avaLabel2.Text = sendData[1];
            }
        }
        public string SendData3
        {
            set
            {
                sendData[2] = value;
                //avaLabel3.Text = sendData[2];
            }
        }
        public string SendData4
        {
            set
            {
                sendData[3] = value;
                //avaLabel4.Text = sendData[3];
            }
        }
        public string SendData5
        {
            set
            {
                sendData[4] = value;
                //avaLabel5.Text = sendData[4];
            }
        }
        public string SendData6
        {
            set
            {
                sendData[5] = value;
                //avaLabel6.Text = sendData[5];
            }
        }
        public string SendData7
        {
            set
            {
                sendData[6] = value;
                //avaLabel7.Text = sendData[6];
            }
        }
        public string SendData8
        {
            set
            {
                sendData[7] = value;
                //avaLabel8.Text = sendData[7];
            }
        }
        public string SendData9
        {
            set
            {
                sendData[8] = value;
                //label9.Text = sendData[8];
            }
        }
        public string SendData10
        {
            set
            {
                sendData[9] = value;
                //label10.Text = sendData[9];
            }
        }
        public string SendData11
        {
            set
            {
                sendData[10] = value;
                //label11.Text = sendData[10];
            }
        }
        public string SendData12
        {
            set
            {
                sendData[11] = value;
                //label12.Text = sendData[11];
            }
        }
        public string SendData13
        {
            set
            {
                sendData[12] = value;
                //label13.Text = sendData[12];
            }
        }
        public string SendData14
        {
            set
            {
                sendData[13] = value;
                //label14.Text = sendData[13];
            }
        }
        public string SendData15
        {
            set
            {
                sendData[14] = value;
                //label15.Text = sendData[14];
            }
        }
        public string SendData16
        {
            set
            {
                sendData[15] = value;
                //label16.Text = sendData[15];
            }
        }

        //確認画面
        private void button1_Click_1(object sender, EventArgs e)
        {
            string testc = sendData[15];
            MessageBox.Show(testc,"メッセージ");
        }

        //画面ロード時に自動的に読み込む
        private void Avatarkakunin_Load(object sender, EventArgs e)
        {
            //Getで貰った変数を専用変数に入れる
            string avat_1 = sendData[0];
            string avat_2 = sendData[1];
            string avat_3 = sendData[2];
            string avat_4 = sendData[3];
            string avat_5 = sendData[4];
            string avat_6 = sendData[5];
            string avat_7 = sendData[6];
            string avat_8 = sendData[7];
            string avat_9 = sendData[8];
            string avat_10 = sendData[9];
            string avat_11 = sendData[10];
            string avat_12 = sendData[11];
            string avat_13 = sendData[12];
            string avat_14 = sendData[13];
            string avat_15 = sendData[14];
            string avat_16 = sendData[15];
            MessageBox.Show(sendData[0],"メッセージ");

        }
    }
}
