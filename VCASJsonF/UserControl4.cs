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
        string[] Avatar = new string[16];//渡されたアバターを格納する配列
       public string testa;
        private string sendData2;
        string str = "\""; //2重引用符

        public UserControl4()
        {
            InitializeComponent();
        }

        public string SendData
        {
            set
            {
                sendData[0] = value;
            }
        }
        public string SendData2
        {
            set
            {
                sendData[1] = value;
            }
        }
        public string SendData3
        {
            set
            {
                sendData[2] = value;
            }
        }
        public string SendData4
        {
            set
            {
                sendData[3] = value;
            }
        }
        public string SendData5
        {
            set
            {
                sendData[4] = value;
            }
        }
        public string SendData6
        {
            set
            {
                sendData[5] = value;
            }
        }
        public string SendData7
        {
            set
            {
                sendData[6] = value;
            }
        }
        public string SendData8
        {
            set
            {
                sendData[7] = value;
            }
        }
        public string SendData9
        {
            set
            {
                sendData[8] = value;
            }
        }
        public string SendData10
        {
            set
            {
                sendData[9] = value;
            }
        }
        public string SendData11
        {
            set
            {
                sendData[10] = value;
            }
        }
        public string SendData12
        {
            set
            {
                sendData[11] = value;
            }
        }
        public string SendData13
        {
            set
            {
                sendData[12] = value;
            }
        }
        public string SendData14
        {
            set
            {
                sendData[13] = value;
            }
        }
        public string SendData15
        {
            set
            {
                sendData[14] = value;
            }
        }
        public string SendData16
        {
            set
            {
                sendData[15] = value;
            }
        }
        public string SendData17
        {
            set
            {
                sendData2 = value;
            }
            get { return SendData17; }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sendData[0]);
            SaveFileDialog sfd = new SaveFileDialog();
            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "config.json";
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
                    sw.WriteLine("{");
                    sw.WriteLine("  "+str+"niconico"+str+":{");
                    //アバター出力
                    sw.WriteLine("      "+str+ "character_models"+str+":[");
                    //アバター情報はここに書く
                    sw.WriteLine(sendData[0]);
                    sw.WriteLine("      ]");
                    sw.WriteLine("  },");
                    //背景画像出力
                    sw.WriteLine("  "+str+"panorama"+str+":{");
                    sw.WriteLine("      "+str+"urls"+str+":[");
                    //ここに背景画像を書く
                    sw.WriteLine("      ]");
                    sw.WriteLine("  },");
                    //ホワイトボード用画像出力
                    sw.WriteLine("  "+str+ "whiteboard"+str+":{");
                    sw.WriteLine("      "+str+"urls"+str+":[");
                    //ここにホワイトボード用画像を書く
                    sw.WriteLine("      ]");
                    sw.WriteLine("  },");
                    //カンペ用画像出力
                    sw.WriteLine("  "+str+ "cue_card"+str+":{");
                    sw.WriteLine("      "+str+"urls"+str+":[");
                    //ここにカンペ用画像を書く
                    sw.WriteLine("      ]");
                    sw.WriteLine("  }");


                    sw.WriteLine("}");
                    //閉じる
                    sw.Close();
                    stream.Close();
                }
            }
        }
    }
}
