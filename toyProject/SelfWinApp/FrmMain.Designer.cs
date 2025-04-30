namespace SelfWinApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            TooltipSave = new ToolStripMenuItem();
            MnuHelp = new ToolStripMenuItem();
            ToolTipHelp = new ToolStripMenuItem();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            BtnLeft = new Button();
            BtnRight = new Button();
            BtnShowAnswer = new Button();
            richTextBox1 = new RichTextBox();
            TxtAnswer = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            BtnLoad = new Button();
            BtnSave = new Button();
            BtnRed = new Button();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            label4 = new Label();
            label1 = new Label();
            LblRate = new Label();
            BtnShowWrong = new Button();
            LblTimer = new Label();
            BtnStart = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile, MnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { TooltipSave });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // TooltipSave
            // 
            TooltipSave.Name = "TooltipSave";
            TooltipSave.Size = new Size(190, 22);
            TooltipSave.Text = "다른이름으로 저장(&A)";
            TooltipSave.Click += TooltipSave_Click;
            // 
            // MnuHelp
            // 
            MnuHelp.DropDownItems.AddRange(new ToolStripItem[] { ToolTipHelp });
            MnuHelp.Name = "MnuHelp";
            MnuHelp.Size = new Size(72, 20);
            MnuHelp.Text = "도움말(&H)";
            // 
            // ToolTipHelp
            // 
            ToolTipHelp.Name = "ToolTipHelp";
            ToolTipHelp.Size = new Size(150, 22);
            ToolTipHelp.Text = "도움말보기(&V)";
            ToolTipHelp.Click += ToolTipHelp_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 282);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(44, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "1번";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 307);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "2번";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(21, 332);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(44, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "3번";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(21, 357);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(44, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "4번";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // BtnLeft
            // 
            BtnLeft.Location = new Point(21, 394);
            BtnLeft.Name = "BtnLeft";
            BtnLeft.Size = new Size(65, 23);
            BtnLeft.TabIndex = 4;
            BtnLeft.Text = "이전문제";
            BtnLeft.UseVisualStyleBackColor = true;
            BtnLeft.Click += BtnLeft_Click;
            // 
            // BtnRight
            // 
            BtnRight.Location = new Point(102, 394);
            BtnRight.Name = "BtnRight";
            BtnRight.Size = new Size(65, 23);
            BtnRight.TabIndex = 4;
            BtnRight.Text = "다음문제";
            BtnRight.UseVisualStyleBackColor = true;
            BtnRight.Click += BtnRight_Click;
            // 
            // BtnShowAnswer
            // 
            BtnShowAnswer.Location = new Point(184, 394);
            BtnShowAnswer.Name = "BtnShowAnswer";
            BtnShowAnswer.Size = new Size(65, 23);
            BtnShowAnswer.TabIndex = 4;
            BtnShowAnswer.Text = "정답확인";
            BtnShowAnswer.UseVisualStyleBackColor = true;
            BtnShowAnswer.Click += BtnShowAnswer_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(570, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(200, 283);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // TxtAnswer
            // 
            TxtAnswer.Location = new Point(302, 127);
            TxtAnswer.Multiline = true;
            TxtAnswer.Name = "TxtAnswer";
            TxtAnswer.Size = new Size(250, 188);
            TxtAnswer.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(74, 33);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(570, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 35);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "문제 수";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(611, 384);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 10;
            BtnLoad.Text = "Load";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(692, 384);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnRed
            // 
            BtnRed.Location = new Point(570, 384);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(35, 23);
            BtnRed.TabIndex = 11;
            BtnRed.Text = "R";
            BtnRed.UseVisualStyleBackColor = true;
            BtnRed.Click += BtnRed_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(74, 62);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 23);
            progressBar1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 95);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 13;
            label3.Text = "해설";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.필적문구;
            pictureBox1.Location = new Point(21, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 66);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 15;
            label4.Text = "진행률";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 95);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 15;
            label1.Text = "정답률";
            // 
            // LblRate
            // 
            LblRate.AutoSize = true;
            LblRate.Location = new Point(74, 95);
            LblRate.Name = "LblRate";
            LblRate.Size = new Size(26, 15);
            LblRate.TabIndex = 16;
            LblRate.Text = "0/0";
            // 
            // BtnShowWrong
            // 
            BtnShowWrong.Location = new Point(184, 91);
            BtnShowWrong.Name = "BtnShowWrong";
            BtnShowWrong.Size = new Size(90, 23);
            BtnShowWrong.TabIndex = 17;
            BtnShowWrong.Text = "틀린문제조회";
            BtnShowWrong.UseVisualStyleBackColor = true;
            BtnShowWrong.Click += BtnShowWrong_Click;
            // 
            // LblTimer
            // 
            LblTimer.AutoSize = true;
            LblTimer.ForeColor = Color.Red;
            LblTimer.Location = new Point(170, 309);
            LblTimer.Name = "LblTimer";
            LblTimer.Size = new Size(55, 15);
            LblTimer.TabIndex = 15;
            LblTimer.Text = "남은시간";
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(209, 33);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(65, 23);
            BtnStart.TabIndex = 18;
            BtnStart.Text = "시험시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnStart);
            Controls.Add(BtnShowWrong);
            Controls.Add(LblTimer);
            Controls.Add(LblRate);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(BtnRed);
            Controls.Add(BtnSave);
            Controls.Add(BtnLoad);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(TxtAnswer);
            Controls.Add(richTextBox1);
            Controls.Add(BtnShowAnswer);
            Controls.Add(BtnRight);
            Controls.Add(BtnLeft);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "퀴즈 윈앱";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuHelp;
        private ToolStripMenuItem TooltipSave;
        private ToolStripMenuItem ToolTipHelp;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button BtnLeft;
        private Button BtnRight;
        private Button BtnShowAnswer;
        private RichTextBox richTextBox1;
        private TextBox TxtAnswer;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button BtnLoad;
        private Button BtnSave;
        private Button BtnRed;
        private ProgressBar progressBar1;
        private Label label3;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label4;
        private Label label1;
        private Label LblRate;
        private Button BtnShowWrong;
        private Label LblTimer;
        private Button BtnStart;
    }
}
