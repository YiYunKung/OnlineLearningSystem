using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace video
{
    public partial class Form1 : Form
    {
        int sec = 0;
        int score = 0; // 積分
        int read = 0; // 已看過//

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = string.Format(@"math_01.wmv");
            timer1.Interval = 1000;
            timer2.Start();
            label1.Text = "積分+1";
            VideoPlayer_initial();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if(sec % 5 == 0) // 15分鐘積分加一 (900)
            {
                score += 1;
                label1.Visible = true;
            }
            if(sec % 5 == 1)  // 隔1秒 消失
            {
                label1.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timer1.Start();
                //label1.Text = "k";
            }
            else
            {
                timer1.Stop();
                //label1.Text = "I";
            }
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                read = 1;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = string.Format(@""+listBox1.SelectedItem);
        }

        private void VideoPlayer_initial()
        {
            VideoFolderRefresh();
            //axWindowsMediaPlayer1.PlayStateChange += player_PlayStateChange;
        }
        public void VideoFolderRefresh() //目錄內所有wmv檔案倒進listBox1
        {
            listBox1.Items.Clear();
            string[] tempVideoFile;
            string path = @"D:\video\video\bin\Debug";
            //tempVideoFile = Directory.GetDirectories(path);
            tempVideoFile = Directory.GetFiles(path, "*.wmv");

            foreach (string iii in tempVideoFile)
            {
                listBox1.Items.Add(Path.GetFileName(iii));
            }
        }

    }
}
