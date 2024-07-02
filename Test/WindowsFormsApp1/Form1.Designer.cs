namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bgTimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.picturePanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.button6 = new System.Windows.Forms.Button();
            this.ans4 = new System.Windows.Forms.Button();
            this.ans3 = new System.Windows.Forms.Button();
            this.ans2 = new System.Windows.Forms.Button();
            this.ans1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.data = new System.Windows.Forms.Label();
            this.picturePanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.picturePanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.picturePanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.picturePanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.selfie = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selfie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 62);
            this.button1.TabIndex = 2;
            this.button1.Tag = "nav";
            this.button1.Text = "首頁";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(372, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 62);
            this.button2.TabIndex = 3;
            this.button2.Tag = "nav";
            this.button2.Text = "影片";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(508, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 62);
            this.button3.TabIndex = 4;
            this.button3.Tag = "nav";
            this.button3.Text = "問答";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(644, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 62);
            this.button4.TabIndex = 5;
            this.button4.Tag = "nav";
            this.button4.Text = "積分";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(780, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 62);
            this.button5.TabIndex = 6;
            this.button5.Tag = "nav";
            this.button5.Text = "學習成果";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            // 
            // bgTimer
            // 
            this.bgTimer.Interval = 10;
            this.bgTimer.Tick += new System.EventHandler(this.bgTimer_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.score.Location = new System.Drawing.Point(91, 210);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(70, 28);
            this.score.TabIndex = 10;
            this.score.Text = "積分";
            this.score.Visible = false;
            // 
            // picturePanel5
            // 
            this.picturePanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePanel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePanel5.Location = new System.Drawing.Point(893, 318);
            this.picturePanel5.Margin = new System.Windows.Forms.Padding(15);
            this.picturePanel5.Name = "picturePanel5";
            this.picturePanel5.Size = new System.Drawing.Size(150, 150);
            this.picturePanel5.TabIndex = 12;
            this.picturePanel5.Tag = "picturePanel";
            this.picturePanel5.Visible = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(1199, 727);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 34);
            this.button6.TabIndex = 18;
            this.button6.Text = "下一題";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ans4
            // 
            this.ans4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans4.Location = new System.Drawing.Point(870, 601);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(80, 80);
            this.ans4.TabIndex = 17;
            this.ans4.Tag = "selection";
            this.ans4.Text = "4";
            this.ans4.UseVisualStyleBackColor = true;
            this.ans4.Visible = false;
            this.ans4.Click += new System.EventHandler(this.button7_Click);
            // 
            // ans3
            // 
            this.ans3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans3.Location = new System.Drawing.Point(722, 601);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(80, 80);
            this.ans3.TabIndex = 16;
            this.ans3.Tag = "selection";
            this.ans3.Text = "3";
            this.ans3.UseVisualStyleBackColor = true;
            this.ans3.Visible = false;
            this.ans3.Click += new System.EventHandler(this.button8_Click);
            // 
            // ans2
            // 
            this.ans2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans2.Location = new System.Drawing.Point(586, 601);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(80, 80);
            this.ans2.TabIndex = 15;
            this.ans2.Tag = "selection";
            this.ans2.Text = "2";
            this.ans2.UseVisualStyleBackColor = true;
            this.ans2.Visible = false;
            this.ans2.Click += new System.EventHandler(this.button9_Click);
            // 
            // ans1
            // 
            this.ans1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans1.Location = new System.Drawing.Point(450, 601);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(80, 80);
            this.ans1.TabIndex = 14;
            this.ans1.Tag = "selection";
            this.ans1.Text = "1";
            this.ans1.UseVisualStyleBackColor = true;
            this.ans1.Visible = false;
            this.ans1.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(98, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.ForeColor = System.Drawing.Color.DimGray;
            this.button7.Location = new System.Drawing.Point(959, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 62);
            this.button7.TabIndex = 20;
            this.button7.Tag = "nav";
            this.button7.Text = "行事曆";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button7_MouseDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthCalendar1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthCalendar1.Location = new System.Drawing.Point(1302, 404);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(799, 66);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(500, 500);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.Color.Transparent;
            this.data.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.data.Location = new System.Drawing.Point(1066, 84);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(154, 46);
            this.data.TabIndex = 25;
            this.data.Text = "Level：1\r\n姓名：貳佰伍";
            this.data.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // picturePanel2
            // 
            this.picturePanel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Lv02;
            this.picturePanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePanel2.Location = new System.Drawing.Point(380, 318);
            this.picturePanel2.Margin = new System.Windows.Forms.Padding(15);
            this.picturePanel2.Name = "picturePanel2";
            this.picturePanel2.Size = new System.Drawing.Size(150, 150);
            this.picturePanel2.TabIndex = 12;
            this.picturePanel2.Tag = "picturePanel";
            this.picturePanel2.Visible = false;
            this.picturePanel2.Click += new System.EventHandler(this.picturePanel2_Click);
            // 
            // picturePanel4
            // 
            this.picturePanel4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Lv04;
            this.picturePanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePanel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePanel4.Location = new System.Drawing.Point(722, 318);
            this.picturePanel4.Margin = new System.Windows.Forms.Padding(15);
            this.picturePanel4.Name = "picturePanel4";
            this.picturePanel4.Size = new System.Drawing.Size(150, 150);
            this.picturePanel4.TabIndex = 12;
            this.picturePanel4.Tag = "picturePanel";
            this.picturePanel4.Visible = false;
            this.picturePanel4.Click += new System.EventHandler(this.picturePanel4_Click);
            // 
            // picturePanel3
            // 
            this.picturePanel3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Lv03;
            this.picturePanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePanel3.Location = new System.Drawing.Point(548, 318);
            this.picturePanel3.Margin = new System.Windows.Forms.Padding(15);
            this.picturePanel3.Name = "picturePanel3";
            this.picturePanel3.Size = new System.Drawing.Size(150, 150);
            this.picturePanel3.TabIndex = 12;
            this.picturePanel3.Tag = "picturePanel";
            this.picturePanel3.Visible = false;
            this.picturePanel3.Click += new System.EventHandler(this.picturePanel3_Click);
            // 
            // picturePanel1
            // 
            this.picturePanel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Lv01;
            this.picturePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePanel1.Location = new System.Drawing.Point(216, 318);
            this.picturePanel1.Margin = new System.Windows.Forms.Padding(15);
            this.picturePanel1.Name = "picturePanel1";
            this.picturePanel1.Size = new System.Drawing.Size(150, 150);
            this.picturePanel1.TabIndex = 11;
            this.picturePanel1.Tag = "picturePanel";
            this.picturePanel1.Visible = false;
            this.picturePanel1.Click += new System.EventHandler(this.picturePanel1_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::WindowsFormsApp1.Properties.Resources._250logo;
            this.logo.Location = new System.Drawing.Point(53, 30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(127, 129);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // selfie
            // 
            this.selfie.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Lv01;
            this.selfie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selfie.Location = new System.Drawing.Point(1226, 30);
            this.selfie.Name = "selfie";
            this.selfie.Size = new System.Drawing.Size(110, 100);
            this.selfie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selfie.TabIndex = 7;
            this.selfie.TabStop = false;
            this.selfie.Click += new System.EventHandler(this.picture_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(372, 111);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(130, 119);
            this.axWindowsMediaPlayer1.TabIndex = 26;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(518, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 96);
            this.listBox1.TabIndex = 27;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(657, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(870, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 38);
            this.textBox1.TabIndex = 29;
            this.textBox1.Tag = "toDoItem";
            this.textBox1.Text = "待辦事項";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date.FormattingEnabled = true;
            this.date.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.date.Location = new System.Drawing.Point(644, 150);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(171, 37);
            this.date.TabIndex = 30;
            this.date.Tag = "toDoItem";
            this.date.Text = "日";
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "1 ",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.month.Location = new System.Drawing.Point(450, 150);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(171, 37);
            this.month.TabIndex = 31;
            this.month.Tag = "toDoItem";
            this.month.Text = "月份";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "2022",
            "2023"});
            this.year.Location = new System.Drawing.Point(260, 150);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(171, 37);
            this.year.TabIndex = 32;
            this.year.Tag = "toDoItem";
            this.year.Text = "年份";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(450, 236);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(593, 466);
            this.checkedListBox1.TabIndex = 33;
            this.checkedListBox1.Tag = "toDoItem";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(756, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 500);
            this.label3.TabIndex = 34;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.netBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1709, 954);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.date);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.picturePanel2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.picturePanel5);
            this.Controls.Add(this.picturePanel4);
            this.Controls.Add(this.picturePanel3);
            this.Controls.Add(this.picturePanel1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.selfie);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "教學平台";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selfie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox selfie;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer bgTimer;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.FlowLayoutPanel picturePanel1;
        private System.Windows.Forms.FlowLayoutPanel picturePanel2;
        private System.Windows.Forms.FlowLayoutPanel picturePanel3;
        private System.Windows.Forms.FlowLayoutPanel picturePanel4;
        private System.Windows.Forms.FlowLayoutPanel picturePanel5;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ans4;
        private System.Windows.Forms.Button ans3;
        private System.Windows.Forms.Button ans2;
        private System.Windows.Forms.Button ans1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label data;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox date;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
    }
}

