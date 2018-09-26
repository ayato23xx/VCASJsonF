using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VCASJsonF
{
    public partial class UserControl4 : UserControl
    {
        private string[] sendData = new string[16];
        private string sendData2;

        public UserControl4()
        {
            InitializeComponent();
        }

        public string SendData
        {
            set
            {
                sendData[0] = value;
                //label1.Text = sendData[0];
                Console.WriteLine(sendData[0]);

            }
        }
        public string SendData2
        {
            set
            {
                sendData[1] = value;
                //label2.Text = sendData[1];
                Console.WriteLine(sendData[1]);
            }
        }
        public string SendData3
        {
            set
            {
                sendData[2] = value;
                //label3.Text = sendData[2];
                Console.WriteLine(sendData[2]);
            }
        }
        public string SendData4
        {
            set
            {
                sendData[3] = value;
                //label4.Text = sendData[3];
                Console.WriteLine(sendData[3]);
            }
        }
        public string SendData5
        {
            set
            {
                sendData[4] = value;
                //label5.Text = sendData[4];
                Console.WriteLine(sendData[4]);
            }
        }
        public string SendData6
        {
            set
            {
                sendData[5] = value;
                //label6.Text = sendData[5];
                Console.WriteLine(sendData[5]);
            }
        }
        public string SendData7
        {
            set
            {
                sendData[6] = value;
                //label7.Text = sendData[6];
                Console.WriteLine(sendData[6]);
            }
        }
        public string SendData8
        {
            set
            {
                sendData[7] = value;
                //label8.Text = sendData[7];
                Console.WriteLine(sendData[7]);
            }
        }
        public string SendData9
        {
            set
            {
                sendData[8] = value;
                //label9.Text = sendData[8];
                Console.WriteLine(sendData[8]);
            }
        }
        public string SendData10
        {
            set
            {
                sendData[9] = value;
                //label10.Text = sendData[9];
                Console.WriteLine(sendData[9]);
            }
        }
        public string SendData11
        {
            set
            {
                sendData[10] = value;
                //label11.Text = sendData[10];
                Console.WriteLine(sendData[10]);
            }
        }
        public string SendData12
        {
            set
            {
                sendData[11] = value;
                //label12.Text = sendData[11];
                Console.WriteLine(sendData[11]);
            }
        }
        public string SendData13
        {
            set
            {
                sendData[12] = value;
                //label13.Text = sendData[12];
                Console.WriteLine(sendData[12]);
            }
        }
        public string SendData14
        {
            set
            {
                sendData[13] = value;
                //label14.Text = sendData[13];
                Console.WriteLine(sendData[13]);
            }
        }
        public string SendData15
        {
            set
            {
                sendData[14] = value;
                //label15.Text = sendData[14];
                Console.WriteLine(sendData[14]);
            }
        }
        public string SendData16
        {
            set
            {
                sendData[15] = value;
                //label16.Text = sendData[15];
                Console.WriteLine(sendData[15]);
            }
        }
        public string SendData17
        {
            set
            {
                sendData2 = value;
                Console.WriteLine(sendData2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "test.json";
            //はじめに表示されるフォルダを指定する
            //sfd.InitialDirectory = @"C:\";
            sfd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            sfd.Filter = "jsonファイル(*.json)|*.json|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            sfd.FilterIndex = 1;
            //タイトルを設定する
            sfd.Title = "保存先のファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            //既に存在するファイル名を指定したとき警告する
            //デフォルトでTrueなので指定する必要はない
            sfd.OverwritePrompt = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            sfd.CheckPathExists = true;

            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream stream;
                stream = sfd.OpenFile();
                if (stream != null)
                {                    
                    //ファイルに書き込む
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    sw.WriteLine("https://dobon.net");
                    sw.WriteLine("aaaa");
                    sw.WriteLine("iiiii");
                    //閉じる
                    sw.Close();
                    stream.Close();
                }
            }
        }
    }
}
