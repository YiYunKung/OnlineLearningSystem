using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store
{
    public partial class Form1 : Form
    {
        public PictureBox question = new PictureBox();
        Random Rnd = new Random();
        int correct = 0;
        int ans = 0;
        int Q = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            QA();
        }

        void QA()
        {
            int i = Rnd.Next(1, 10);
            question.Top = (this.Bottom - question.Height) / 10;
            question.Left = (this.Width/5);
            question.Size = new System.Drawing.Size(400, 200);
            question.SizeMode = PictureBoxSizeMode.StretchImage;
            question.Image = store.Properties.Resources.Q001;
            ans = 2;
            question.Visible = true;

            button1.Visible = true; button2.Visible = true; button3.Visible = true; button4.Visible = true;
            button1.Top = question.Top + question.Height +15;
            button2.Top = question.Top + question.Height +15;
            button3.Top = question.Top + question.Height +15;
            button4.Top = question.Top + question.Height +15;

            this.Controls.Add(question);
        }


        private void button1_Click(object sender, EventArgs e) //choose1
        {
            if (ans == 1)
            {
                button1.BackColor = Color.Green;
                correct++;
                button5.Visible = true;
            }
            else if (ans != 1)
            {
                button1.BackColor = Color.Red;
                if(ans == 2 ) button2.BackColor = Color.Green;
                if(ans == 3 ) button2.BackColor = Color.Green;
                if (ans == 4) button2.BackColor = Color.Green;
                button5.Visible = true;
            }
            button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false;
            label1.Text = "答對 " + correct + " 題";
        }

        private void button2_Click(object sender, EventArgs e) //choose 2
        {
            if (ans == 2)
            {
                button2.BackColor = Color.Green;
                correct++;
                button5.Visible = true;
            }
            else if (ans != 2)
            {
                button2.BackColor = Color.Red;
                if (ans == 1) button1.BackColor = Color.Green;
                if (ans == 3) button3.BackColor = Color.Green;
                if (ans == 4) button4.BackColor = Color.Green;
                button5.Visible = true;
            }
            button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false;
            label1.Text = "答對 " + correct + " 題";
        }

        private void button3_Click(object sender, EventArgs e) //choose 3
        {
            if (ans == 3)
            {
                button3.BackColor = Color.Green;
                correct++;
                button5.Visible = true;
            }
            else if (ans != 3)
            {
                button3.BackColor = Color.Red;
                if (ans == 1) button1.BackColor = Color.Green;
                if (ans == 2) button2.BackColor = Color.Green;
                if (ans == 4) button4.BackColor = Color.Green;
                button5.Visible = true;
            }
            button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false;
            label1.Text = "答對 " + correct + " 題";
        }

        private void button4_Click(object sender, EventArgs e) //choose 4 
        {
            if (ans == 4)
            {
                button4.BackColor = Color.Green;
                correct++;
                button5.Visible = true;
            }
            else if (ans != 4)
            {
                button4.BackColor = Color.Red;
                if (ans == 1) button1.BackColor = Color.Green;
                if (ans == 2) button2.BackColor = Color.Green;
                if (ans == 3) button3.BackColor = Color.Green;
                button5.Visible = true;
            }
            button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false;
            label1.Text = "答對 " + correct + " 題";
        }

        private void button5_Click(object sender, EventArgs e) //next
        {
            if(Q != 10)
            {
                Q++;
                ans = 0;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; button4.Enabled = true;
                button5.Visible = false;
                nextquestion();
                //button顏色
                //enable = true;
                // ans = 0;
            }
            else // Q == 10
            {
                MessageBox.Show("共答對 :　" + correct + " 題 \r\n 正確率為 : " + correct*10 + " %", "測驗完成", MessageBoxButtons.OK);
            }
        }
        void nextquestion()
        {
            if (Q == 2)
            {
                question.Image = store.Properties.Resources.Q002;
                ans = 4;
            }
            if (Q == 3)
            {
                question.Image = store.Properties.Resources.Q003;
                ans = 4;
            }
            if (Q == 4)
            {
                question.Image = store.Properties.Resources.Q004;
                ans = 2;
            }
            if (Q == 5)
            {
                question.Image = store.Properties.Resources.Q005;
                ans = 2;
            }
            if (Q == 6)
            {
                question.Image = store.Properties.Resources.Q006;
                ans = 4;
            }
            if (Q == 7)
            {
                question.Image = store.Properties.Resources.Q007;
                ans = 4;
            }
            if (Q == 8)
            {
                question.Image = store.Properties.Resources.Q008;
                ans = 3;
            }
            if (Q == 9)
            {
                question.Image = store.Properties.Resources.Q009;
                ans = 3;
            }
            if (Q == 10)
            {
                question.Image = store.Properties.Resources.Q0010;
                ans = 2;
            }

        }
    }
}
