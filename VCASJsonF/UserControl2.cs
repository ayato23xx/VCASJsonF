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
    public partial class UserControl2 : UserControl
    {
        //アバター格納用配列作成
        string[] Avatar = new string[16];
        string str = "\""; //2重引用符
        int ava_L = 0;//アバターを数える変数
        int ava_L2 = 0;//アバターループで回す変数
        int haikei_L = 0;//背景を数える変数
        int Whbd_L = 0;//ホワイトボード用画像を数える変数
        int cucd = 0; //カンペ用画像を数える変数
        //読込昨日で使う変数・配列一覧//


        //SETGETに送るデータ格納配列
        private string[] avatar_1 = new string[16];
        private string mDefaultDirectory;

        public UserControl2()
        {
            InitializeComponent();
        }

        //次のページへ遷移するときの挙動
        private void button2_Click(object sender, EventArgs e)
        {
            //アバターを配列に格納する
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
            //入力されたアバターの数を数える
            for (ava_L = 0;ava_L<=15 && Avatar[ava_L]!="";ava_L++) { }
            ava_L2 = ava_L - 1;
            //入力された背景の数を数える
            string[] haikei_Str = textBox17.Text.Split(new string[] { "\r\n" },StringSplitOptions.None);
            string[] whbd_Str = textBox18.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            string[] cubd_Str = textBox19.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            //ファイル出力
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "config.json";
            sfd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            sfd.Filter = "jsonファイル(*.json)|*.json|すべてのファイル(*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.Title = "ファイルを保存する場所を指定してください";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
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
                    sw.WriteLine("  " + str + "niconico" + str + ":{");
                    //アバター出力
                    sw.WriteLine("      " + str + "character_models" + str + ":[");
                    //アバター情報はここに書く
                    for (ava_L=0;ava_L<ava_L2;ava_L++)
                    {
                        sw.WriteLine("          "+Avatar[ava_L]+",");
                    }
                    sw.WriteLine("          "+Avatar[ava_L]);
                    sw.WriteLine("      ]");
                    sw.WriteLine("  },");
                    //背景画像出力
                    sw.WriteLine("  " + str + "panorama" + str + ":{");
                    sw.WriteLine("      " + str + "urls" + str + ":[");
                    //ここに背景画像を書く
                    for (haikei_L=0;haikei_L<haikei_Str.Length-1;haikei_L++)
                    {
                        sw.WriteLine("          "+str+haikei_Str[haikei_L]+str+",");
                    }
                    sw.WriteLine("          "+str+haikei_Str[haikei_L]+str);
                    sw.WriteLine("      ]");
                    sw.WriteLine("  },");
                    //ホワイトボード用画像出力
                    sw.WriteLine("  " + str + "whiteboard" + str + ":{");
                    sw.WriteLine("      " + str + "urls" + str + ":[");
                    //ここにホワイトボード用画像を書く
                    for (Whbd_L=0;Whbd_L<whbd_Str.Length-1;Whbd_L++)
                    {
                        sw.WriteLine("          "+str+whbd_Str[Whbd_L]+str+",");
                    }
                    sw.WriteLine("          "+str+whbd_Str[Whbd_L]+str);
                    sw.WriteLine("      ]");
                    sw.WriteLine("  },");
                    //カンペ用画像出力
                    sw.WriteLine("  " + str + "cue_card" + str + ":{");
                    sw.WriteLine("      " + str + "urls" + str + ":[");
                    //ここにカンペ用画像を書く
                    for (cucd=0;cucd<cubd_Str.Length-1;cucd++)
                    {
                        sw.WriteLine("          "+str+cubd_Str[cucd]+str+",");
                    }
                    sw.WriteLine("          "+str+cubd_Str[cucd]+str);
                    sw.WriteLine("      ]");
                    sw.WriteLine("  },");
                    //その他設定項目
                    //ダイレクトビューモード
                    if (checkBox3.Checked)
                    {
                        if (checkBox1.Checked || checkBox2.Checked)
                        {
                            sw.WriteLine("  \"mode\": \"direct-view\",");
                        }
                        else
                        {
                            sw.WriteLine("  \"mode\": \"direct-view\"");
                        }
                        
                    }
                    //ダイレクトビューでの凸許可
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                        {
                            sw.WriteLine("  \"allow_direct_view\": true,");
                        }
                        else
                        {
                            sw.WriteLine("  \"allow_direct_view\": true");
                        }
                        
                    }
                    //カメラ非表示
                    if (checkBox2.Checked)
                    {
                        sw.WriteLine("  \"hide_camera_from_viewers\": true");
                    }
                    sw.WriteLine("}");
                    //閉じる
                    sw.Close();
                    stream.Close();
                }
            }
        }
        
        //確認用
        private void button1_Click(object sender, EventArgs e)
        {
            //変数に入力された数値をSETする
            for (int avatarLoop = 1; avatarLoop <= 16; avatarLoop++)
            {
                Avatar[avatarLoop - 1] = this.Controls["textbox" + avatarLoop.ToString()].Text;
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

        //アバター入力欄の入力チェック（数値のみ許可）
        private void TextBox1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<'0'||'9'<e.KeyChar)
            {
                MessageBox.Show("入力できるのは数字のみです。\n\rURLのtsは不要です。", "メッセージ");
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ファイル読込
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.FileName = "config.json";
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            ofd.Filter = "JSONファイル(*.json)|*.json|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "開くファイルを選択してください。";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            //ファイルを読み込んだ時の処理
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                Stream stream = ofd.OpenFile();
                //ファイルパスを保存
                string OPFName = ofd.FileName;
                if (stream != null)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                    System.Text.Encoding enc = System.Text.Encoding.GetEncoding("UTF-8");
                    //各種変数宣言
                    string textFile = OPFName;
                    string Input_Str = System.IO.File.ReadAllText(textFile, enc);
                    string[] Input_Str_Enc = Input_Str.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    string[] Vcas_Json = new string[0];//空白部分を省いたjsonの配列
                    //アバター格納配列
                    string[] Ava_Str = new string[0];
                    string[] Ava_Str2 = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

                    //アバターCount配列
                    int Ava_Count = 0;

                    //余計な空白を省いて別配列に入れる
                    for (int i = 0; i < Input_Str_Enc.Length; i++)
                    {
                        Array.Resize(ref Vcas_Json, i + 1);
                        Vcas_Json[i] = Input_Str_Enc[i].Trim();
                        Console.WriteLine(Vcas_Json[i]);
                    }
                    for (int i=3;i<Vcas_Json.Length&&Vcas_Json[i]!="]";i++)
                    {
                        Array.Resize(ref Ava_Str, i + 1);
                        Ava_Str[i] = Vcas_Json[i];
                    }
                    for (int i = 3; i<Ava_Str.Length && Ava_Str[i] != "]"; i++)
                    {
                        if (Ava_Count < 16)
                        {
                            Ava_Str2[i] = Ava_Str[i].Replace(",", "");
                            Console.WriteLine(Ava_Str2[i]);
                        }
                        else
                        {
                            Array.Resize(ref Ava_Str2,i+1);
                            Ava_Str2[i] = Ava_Str[i];
                            Console.WriteLine(Ava_Str2[i]);
                        }
                        Ava_Count++;
                    }
                    Console.WriteLine(Ava_Count);
                    //Importしたアバターをテキストボックスに表示する（16体）
                    textBox1.Text = Ava_Str2[3];
                    textBox2.Text = Ava_Str2[4];
                    textBox3.Text = Ava_Str2[5];
                    textBox4.Text = Ava_Str2[6];
                    textBox5.Text = Ava_Str2[7];
                    textBox6.Text = Ava_Str2[8];
                    textBox7.Text = Ava_Str2[9];
                    textBox8.Text = Ava_Str2[10];
                    textBox9.Text = Ava_Str2[11];
                    textBox10.Text = Ava_Str2[12];
                    textBox11.Text = Ava_Str2[13];
                    textBox12.Text = Ava_Str2[14];
                    textBox13.Text = Ava_Str2[15];
                    textBox14.Text = Ava_Str2[16];
                    textBox15.Text = Ava_Str2[17];
                    textBox16.Text = Ava_Str2[18];
                    //デバック処理
                    MessageBox.Show("ファイルを読み込みました。","メッセージ");
                    //閉じる処理
                    sr.Close();
                }
                stream.Close();                
            }
        }
    }
}
