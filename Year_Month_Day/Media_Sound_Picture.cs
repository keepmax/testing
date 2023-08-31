using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Year_Month_Day
{
    public partial class Media_Sound_Picture : Form
    {
        public Media_Sound_Picture()
        {
            InitializeComponent();
        }
        private int idx = 1;

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idx--;
            if (idx < 1)
            {
                idx = 7;
            }
            object obj = Properties.Resources.ResourceManager.GetObject($"{idx}");
            pictureBox1.Image = (Image)obj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idx++;
            if (idx > 7)
            {
                idx = 1;
            }
            object obj = Properties.Resources.ResourceManager.GetObject($"{idx}");
            pictureBox1.Image = (Image)obj;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("timer1_Tick");
            label1.Text = DateTime.Now.ToString();
            // 到达指定时间播放音乐
            if (DateTime.Now.Hour == 18 && DateTime.Now.Minute == 11 && DateTime.Now.Second == 20)
            {
                //播放音乐
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"C:\Users\13577\Music\1.wav";
                int count = 0;
                while(count < 5)
                {
                    sp.Play();

                    Thread.Sleep(1000);
                    count++;
                }
                
                sp.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MediaPlayer可以播放音乐
            MediaPlayer sp = new MediaPlayer();
            string path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "黄龄,HOYO-MiX - TruE (Ed Ver.).mp3");
            Uri uri = new Uri(path);
            sp.Open(uri);
            sp.Play();
        }
    }
}
