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
    public partial class UserControl4 : UserControl
    {
        private string[] sendData = new string[16];
        private string sendData2 ;

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

        }


    }
}
