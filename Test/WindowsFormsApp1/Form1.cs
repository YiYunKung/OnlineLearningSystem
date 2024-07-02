using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using WMPLib;
using System.IO;
using stdole;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int navState = 1;
        private int scoreNum = 0; //積分

        public PictureBox question = new PictureBox();
        Random Rnd = new Random();
        int correct = 0;
        int ans = 0;
        int Q = 1;
        bool firstChart = true;

        int sec = 0; //秒數
        int levelNum = 1;   /**/
        string waitlist;    /**/
        bool listShow = false;
        string vedio_name;

        bool count = true;

        public Form1()
        {
            InitializeComponent();

            bgTimer.Start();

        }


        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Visible = false;
            navState = 1;
            foreach (Control b in this.Controls)
            {
                if (b is Button && b.Tag == "nav")
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.DimGray;
                }
            }
            button1.BackColor = Color.RosyBrown;
            button1.ForeColor = Color.White;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Visible = false;
            navState = 2;
            foreach (Control b in this.Controls)
            {
                if (b is Button && b.Tag == "nav")
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.DimGray;
                }
            }
            button2.BackColor = Color.RosyBrown;
            button2.ForeColor = Color.White;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Visible = false;
            navState = 3;
            foreach (Control b in this.Controls)
            {
                if (b is Button && b.Tag == "nav")
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.DimGray;
                }
            }
            button3.BackColor = Color.RosyBrown;
            button3.ForeColor = Color.White;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Visible = false;
            navState = 4;
            foreach (Control b in this.Controls)
            {
                if (b is Button && b.Tag == "nav")
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.DimGray;
                }
            }
            button4.BackColor = Color.RosyBrown;
            button4.ForeColor = Color.White;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            navState = 5;
            foreach (Control b in this.Controls)
            {
                if (b is Button && b.Tag == "nav")
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.DimGray;
                }
            }
            button5.BackColor = Color.RosyBrown;
            button5.ForeColor = Color.White;

            pieShow();
        }
        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Visible = false;
            navState = 7;
            foreach (Control b in this.Controls)
            {
                if (b is Button && b.Tag == "nav")
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.DimGray;
                }
            }
            button7.BackColor = Color.RosyBrown;
            button7.ForeColor = Color.White;


        }

        private void bgTimer_Tick(object sender, EventArgs e)
        {
            paint();

            homePage();
            videoPlay();
            QandA();
            scorePage();
            chartPage();
            calenderShow();
            toDoList();
            if (scoreNum >= 10)
            {
                levelNum = 2;
            }/**/
            if (scoreNum >= 20)
            {
                levelNum = 3;
            }/**/
            if (scoreNum >= 30)
            {
                levelNum = 4;
            }/**/
        }

        public void homePage()
        {
            if (navState == 1)      // 顯示首頁
            {
                /*title.Text = "線上學習網站...";
                title.Visible = true;*/
                this.BackgroundImage = WindowsFormsApp1.Properties.Resources.netBG;
            }
            else
            {
                //title.Visible = false;
                this.BackgroundImage = null;
            }
        }

        public void videoPlay()     // 影片播放
        {
            if (navState == 2)
            {
                listBox1.Visible = true;
                listBox1.Size = new Size(450, 500);
                listBox1.Top = 150; listBox1.Left = 1000;

                axWindowsMediaPlayer1.Visible = true;
                axWindowsMediaPlayer1.Size = new Size(800, 600);
                axWindowsMediaPlayer1.Top = 150;
                axWindowsMediaPlayer1.Left = 150;

                label2.Top = 160;
                label2.Left = 160;

            }
            else
            {
                listBox1.Visible = false;
                axWindowsMediaPlayer1.Visible = false;
                label2.Visible = false;
            }

        }

        public void QandA()     // 題目問答
        {
            if (navState == 3)
            {
                foreach (Control b in this.Controls)
                {
                    if (b is Button && b.Tag == "selection")
                        b.Visible = true;
                }
                int i = Rnd.Next(1, 10);
                question.Top = (this.Bottom - question.Height) / 3;
                question.Left = (this.Width / 4);
                question.Size = new System.Drawing.Size(600, 280);
                question.SizeMode = PictureBoxSizeMode.StretchImage;
                question.Visible = true;
                nextquestion();
                this.Controls.Add(question);
            }
            else
            {
                question.Visible = false;
                label1.Visible = false;
                button6.Visible = false;
                foreach (Control b in this.Controls)
                {
                    if (b is Button && b.Tag == "selection")
                        b.Visible = false;
                }
            }
        }

        public void scorePage()     // 積分
        {
            if (navState == 4)      // 積分紀錄
            {
                score.Text = "積分：" + scoreNum.ToString() + "\n\n" + "累積點數以解鎖更多頭像...";
                score.Visible = true;

                picturePanel1.Visible = true;
                if (scoreNum >= 10)
                    picturePanel2.Visible = true;
                if (scoreNum >= 20)
                    picturePanel3.Visible = true;
                if (scoreNum >= 30)
                    picturePanel4.Visible = true;
            }
            else
            {
                score.Visible = false;
                foreach (Control pic in this.Controls)
                {
                    if (pic is FlowLayoutPanel && pic.Tag == "picturePanel")
                    {
                        pic.Visible = false;
                    }
                }
            }
        }

        public void chartPage()        // 學習成果分析
        {
            if (navState == 5)
            {
                chart1.Visible = true;
            }
            else
            {
                chart1.Visible = false;
            }
        }

        public void pieShow()       // 顯示圓餅圖百分比
        {
            if (firstChart)
            {
                chart1.Titles.Add("影片觀看時數");
                //chart1.Series["s1"].IsValueShownAsLabel = true;
                chart1.Series["s1"].Points.AddXY("已觀看", sec);
                chart1.Series["s1"].Points.AddXY("未觀看", 306-sec);
                firstChart = false;
            }
            if(navState == 5)
            {
                label3.Visible = true;
                label3.Text = "\r\n  答對 :　" + correct + " 題.....正確率為 : " + correct * 10 + " %";
            }
            else
            {
                label3.Visible = false;
            }

            
        }

        public void calenderShow()
        {
            if (navState == 7)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
        }

        private void picturePanel1_Click(object sender, EventArgs e)
        {
            selfie.Image = picturePanel1.BackgroundImage;
        }

        private void picturePanel2_Click(object sender, EventArgs e)
        {
            selfie.Image = picturePanel2.BackgroundImage;
        }

        private void picturePanel3_Click(object sender, EventArgs e)
        {
            selfie.Image = picturePanel3.BackgroundImage;
        }

        private void picturePanel4_Click(object sender, EventArgs e)
        {
            selfie.Image = picturePanel4.BackgroundImage;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ans == 1)
            {
                ans1.BackColor = Color.Green;
                correct++;
                button6.Visible = true;
            }
            else if (ans != 1)
            {
                ans1.BackColor = Color.Red;
                if (ans == 2) ans2.BackColor = Color.Green;
                if (ans == 3) ans3.BackColor = Color.Green;
                if (ans == 4) ans4.BackColor = Color.Green;
                button6.Visible = true;
            }
            ans1.Enabled = false; ans2.Enabled = false; ans3.Enabled = false; ans4.Enabled = false;
            label1.Text = "答對 " + correct + " 題";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ans == 2)
            {
                ans2.BackColor = Color.Green;
                correct++;
                button6.Visible = true;
            }
            else if (ans != 2)
            {
                ans2.BackColor = Color.Red;
                if (ans == 1) ans1.BackColor = Color.Green;
                if (ans == 3) ans3.BackColor = Color.Green;
                if (ans == 4) ans4.BackColor = Color.Green;
                button6.Visible = true;
            }
            ans1.Enabled = false; ans2.Enabled = false; ans3.Enabled = false; ans4.Enabled = false;
            label1.Text = "答對 " + correct + " 題";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ans == 3)
            {
                ans3.BackColor = Color.Green;
                correct++;
                button6.Visible = true;
            }
            else if (ans != 3)
            {
                ans3.BackColor = Color.Red;
                if (ans == 1) ans1.BackColor = Color.Green;
                if (ans == 2) ans2.BackColor = Color.Green;
                if (ans == 4) ans4.BackColor = Color.Green;
                button6.Visible = true;
            }
            ans1.Enabled = false; ans2.Enabled = false; ans3.Enabled = false; ans4.Enabled = false;
            label1.Text = "答對 " + correct + " 題";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ans == 4)
            {
                ans4.BackColor = Color.Green;
                correct++;
                button6.Visible = true;
            }
            else if (ans != 4)
            {
                ans4.BackColor = Color.Red;
                if (ans == 1) ans1.BackColor = Color.Green;
                if (ans == 2) ans2.BackColor = Color.Green;
                if (ans == 3) ans3.BackColor = Color.Green;
                button6.Visible = true;
            }
            ans1.Enabled = false; ans2.Enabled = false; ans3.Enabled = false; ans4.Enabled = false;
            label1.Text = "答對 " + correct + " 題";
        }

        private void button6_Click(object sender, EventArgs e)      // 下一題按鍵
        {
            if (Q < 10)
            {
                Q++;
                ans = 0;
                ans1.BackColor = Color.White;
                ans2.BackColor = Color.White;
                ans3.BackColor = Color.White;
                ans4.BackColor = Color.White;
                ans1.Enabled = true; ans2.Enabled = true; ans3.Enabled = true; ans4.Enabled = true;
                button6.Visible = false;
                nextquestion();
                //button顏色
                //enable = true;
                // ans = 0;
            }
            else // Q == 10
            {
                MessageBox.Show("共答對 :　" + correct + " 題 \r\n 正確率為 : " + correct * 10 + " %", "測驗完成", MessageBoxButtons.OK);
                if(count)
                {
                    scoreNum += correct;
                    count = false; 
                }

                

            }
        }

        void nextquestion()
        {
            if (Q == 1)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q001;
                ans = 2;
            }

            if (Q == 2)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q002;
                ans = 4;
            }
            if (Q == 3)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q003;
                ans = 4;
            }
            if (Q == 4)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q004;
                ans = 2;
            }
            if (Q == 5)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q005;
                ans = 2;
            }
            if (Q == 6)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q006;
                ans = 4;
            }
            if (Q == 7)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q007;
                ans = 4;
            }
            if (Q == 8)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q008;
                ans = 3;
            }
            if (Q == 9)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q009;
                ans = 3;
            }
            if (Q == 10)
            {
                question.Image = WindowsFormsApp1.Properties.Resources.Q0010;
                ans = 2;
            }

        }

        void paint()      // 版面配置
        {
            //logo.Left = ;

            ans1.Visible = true; ans2.Visible = true; ans3.Visible = true; ans4.Visible = true;
            ans4.Top = question.Top + question.Height + 50;
            ans3.Top = question.Top + question.Height + 50;
            ans2.Top = question.Top + question.Height + 50;
            ans1.Top = question.Top + question.Height + 50;
            ans1.Left = question.Left;
            ans2.Left = question.Left + question.Width / 4;
            ans3.Left = question.Left + question.Width / 2;
            ans4.Left = question.Left + (question.Width / 4) * 3;
            button6.Left = this.Width - 300;
            button6.Top = this.Height - 250;

            selfie.Left = this.Width - 150;
            selfie.Top = 50;
            data.Left = selfie.Left - 140;
            data.Top = selfie.Top + 40;

            button1.Left = 200;
            button2.Left = 200 + this.Width / 12;
            button3.Left = button2.Left + this.Width / 12;
            button4.Left = button3.Left + this.Width / 12;
            button5.Left = button4.Left + this.Width / 12;
            button7.Left = button5.Left + this.Width / 10;

            button6.Size = new Size(100, 50);

            picturePanel1.Left = this.Width / 8;
            picturePanel2.Left = picturePanel1.Left + this.Width / 10;
            picturePanel3.Left = picturePanel2.Left + this.Width / 10;
            picturePanel4.Left = picturePanel3.Left + this.Width / 10;
            picturePanel5.Left = picturePanel4.Left + this.Width / 10;
            foreach (Control x in this.Controls)
            {
                if (x is FlowLayoutPanel && x.Tag == "picturePanel")
                {
                    x.Top = score.Top + 150;
                }
            }
            data.Text = "Level：" + levelNum.ToString() + "\n姓名：王美女";      /**/

            chart1.Left = 100;
            chart1.Top = 200;
            score.Left = 200;
            score.Top = 200;
            label1.Left = 100;
            label1.Top = 200;


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if (sec % 5 == 0) // 15分鐘積分加一 (900)
            {
                scoreNum += 10; //1
                label2.Visible = true;
            }
            if (sec % 5 == 1)  // 隔1秒 消失
            {
                label2.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying && navState == 2)
            {
                timer1.Start();
                //label1.Text = "k";
            }
            else
            {
                timer1.Stop();
                //label1.Text = "I";
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = string.Format(@""+listBox1.SelectedItem);
            vedio_name = listBox1.SelectedItem.ToString();
        }

        private void VideoPlayer_initial()
        {
            VideoFolderRefresh();
            //axWindowsMediaPlayer1.PlayStateChange += player_PlayStateChange;
        }
        public void VideoFolderRefresh() //目錄內所有wmv檔案放進listBox1
        {
            listBox1.Items.Clear();
            string[] tempVideoFile;
            string path = @"D:\Test\WindowsFormsApp1\bin\Debug";
            //tempVideoFile = Directory.GetDirectories(path);
            tempVideoFile = Directory.GetFiles(path, "*.wmv");

            foreach (string iii in tempVideoFile)
            {
                listBox1.Items.Add(Path.GetFileName(iii));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = string.Format(@"math_01.wmv");
            timer1.Interval = 1000;
            timer2.Start();
            label2.Text = "積分+1";
            VideoPlayer_initial();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                waitlist = textBox1.Text;
                textBox1.Text = "";
                listShow = true;
            }
        }
        private void toDoList()     // 待辦事項
        {
            if (navState == 7)
            {
                foreach (Control x in this.Controls)
                {
                    if (x.Tag == "toDoItem")
                    {
                        x.Visible = true;
                    }
                }
                if (listShow)
                {
                    string yyyy, mm, dd;
                    yyyy = year.SelectedItem.ToString();
                    mm = month.SelectedItem.ToString();
                    dd = date.SelectedItem.ToString();
                    checkedListBox1.Items.Add(yyyy + "/" + mm + "/" + dd + " " +waitlist, CheckState.Unchecked);
                    listShow = false;
                }
            }
            else
            {
                foreach (Control x in this.Controls)
                {
                    if (x.Tag == "toDoItem")
                    {
                        x.Visible = false;
                    }
                }
                year.Text = "年份";
                month.Text = "月份";
                date.Text = "日期";
            }
        }//new
    }
}
