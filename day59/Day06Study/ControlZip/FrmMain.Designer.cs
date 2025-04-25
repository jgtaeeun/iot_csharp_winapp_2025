namespace ControlZip
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuNewFile = new ToolStripMenuItem();
            MnuExit = new ToolStripMenuItem();
            편집ㄷToolStripMenuItem = new ToolStripMenuItem();
            편집EToolStripMenuItem = new ToolStripMenuItem();
            MnuView = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            ChkItalic = new CheckBox();
            TxtResult = new TextBox();
            ChkBold = new CheckBox();
            CboFont = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnImage = new Button();
            PicImage = new PictureBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            BtnCheck = new Button();
            BtnSave = new Button();
            BtnLoad = new Button();
            richTextBox1 = new RichTextBox();
            linkLabel1 = new LinkLabel();
            dateTimePicker1 = new DateTimePicker();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            monthCalendar1 = new MonthCalendar();
            groupBox4 = new GroupBox();
            PrgProcess = new ProgressBar();
            TrbProcess = new TrackBar();
            groupBox5 = new GroupBox();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox6 = new GroupBox();
            BtnThread3 = new Button();
            BtnThread2 = new Button();
            BtnThread1 = new Button();
            ProProgressBack = new ProgressBar();
            TxtResultThread = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox7 = new GroupBox();
            BtnNode = new Button();
            BtnRoot = new Button();
            TrvDummy = new TreeView();
            imageList1 = new ImageList(components);
            LsvDummy = new ListView();
            DlgOpenImage = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1077, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(90, 17);
            LblState.Text = "상태 : 일반상태";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile, 편집ㄷToolStripMenuItem, 편집EToolStripMenuItem, MnuView });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1077, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuNewFile, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuNewFile
            // 
            MnuNewFile.Name = "MnuNewFile";
            MnuNewFile.Size = new Size(119, 22);
            MnuNewFile.Text = "새 글(&N)";
            // 
            // MnuExit
            // 
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(119, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // 편집ㄷToolStripMenuItem
            // 
            편집ㄷToolStripMenuItem.Name = "편집ㄷToolStripMenuItem";
            편집ㄷToolStripMenuItem.Size = new Size(12, 20);
            // 
            // 편집EToolStripMenuItem
            // 
            편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            편집EToolStripMenuItem.Size = new Size(57, 20);
            편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // MnuView
            // 
            MnuView.Name = "MnuView";
            MnuView.Size = new Size(59, 20);
            MnuView.Text = "보기(&V)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFont);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 129);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "공용 컨트롤";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("한컴 말랑말랑 Regular", 9.749998F, FontStyle.Italic, GraphicsUnit.Point, 129);
            ChkItalic.Location = new Point(264, 45);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(71, 21);
            ChkItalic.TabIndex = 4;
            ChkItalic.Text = "기울임꼴";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(6, 89);
            TxtResult.Name = "TxtResult";
            TxtResult.PlaceholderText = "Sample Text";
            TxtResult.Size = new Size(329, 24);
            TxtResult.TabIndex = 3;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("한컴 말랑말랑 Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ChkBold.Location = new Point(209, 45);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(49, 21);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFont
            // 
            CboFont.FormattingEnabled = true;
            CboFont.Location = new Point(42, 43);
            CboFont.Name = "CboFont";
            CboFont.Size = new Size(161, 25);
            CboFont.TabIndex = 1;
            CboFont.SelectedIndexChanged += CboFont_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnImage);
            groupBox2.Controls.Add(PicImage);
            groupBox2.Location = new Point(369, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 338);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "PictureBox";
            // 
            // BtnImage
            // 
            BtnImage.Location = new Point(247, 298);
            BtnImage.Name = "BtnImage";
            BtnImage.Size = new Size(88, 34);
            BtnImage.TabIndex = 1;
            BtnImage.Text = "이미지열기";
            BtnImage.UseVisualStyleBackColor = true;
            BtnImage.Click += BtnImage_Click;
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.ActiveCaption;
            PicImage.Location = new Point(6, 23);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(329, 268);
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(BtnCheck);
            groupBox3.Controls.Add(BtnSave);
            groupBox3.Controls.Add(BtnLoad);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(TxtDay);
            groupBox3.Controls.Add(TxtMonth);
            groupBox3.Controls.Add(TxtYear);
            groupBox3.Controls.Add(monthCalendar1);
            groupBox3.Location = new Point(725, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(341, 509);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "기타컨트롤";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(134, 464);
            button1.Name = "button1";
            button1.Size = new Size(26, 28);
            button1.TabIndex = 7;
            button1.Text = "R";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(222, 197);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(75, 25);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(247, 464);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 28);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "파일저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(166, 464);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 28);
            BtnLoad.TabIndex = 5;
            BtnLoad.Text = "파일로드";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 281);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox1.Size = new Size(323, 166);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 238);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 17);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 197);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 24);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(235, 83);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(100, 24);
            TxtDay.TabIndex = 1;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(235, 53);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(100, 24);
            TxtMonth.TabIndex = 1;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(235, 23);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(100, 24);
            TxtYear.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 23);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(PrgProcess);
            groupBox4.Controls.Add(TrbProcess);
            groupBox4.Location = new Point(12, 162);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(341, 108);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "트랙바";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(6, 65);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(329, 23);
            PrgProcess.TabIndex = 1;
            // 
            // TrbProcess
            // 
            TrbProcess.Location = new Point(6, 23);
            TrbProcess.Maximum = 100;
            TrbProcess.Name = "TrbProcess";
            TrbProcess.Size = new Size(329, 45);
            TrbProcess.TabIndex = 0;
            TrbProcess.TickFrequency = 10;
            TrbProcess.Scroll += TrbProcess_Scroll;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnMsgBox);
            groupBox5.Controls.Add(BtnModaless);
            groupBox5.Controls.Add(BtnModal);
            groupBox5.Location = new Point(12, 276);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(341, 89);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "모달, 모달리스";
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(197, 32);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(121, 40);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(110, 32);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(81, 40);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(22, 32);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(82, 40);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnThread3);
            groupBox6.Controls.Add(BtnThread2);
            groupBox6.Controls.Add(BtnThread1);
            groupBox6.Controls.Add(ProProgressBack);
            groupBox6.Controls.Add(TxtResultThread);
            groupBox6.Location = new Point(369, 371);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(341, 165);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "스레드, 백그라운드워커";
            // 
            // BtnThread3
            // 
            BtnThread3.Location = new Point(260, 131);
            BtnThread3.Name = "BtnThread3";
            BtnThread3.Size = new Size(75, 24);
            BtnThread3.TabIndex = 2;
            BtnThread3.Text = "정지";
            BtnThread3.UseVisualStyleBackColor = true;
            BtnThread3.Click += BtnThread3_Click;
            // 
            // BtnThread2
            // 
            BtnThread2.Location = new Point(176, 131);
            BtnThread2.Name = "BtnThread2";
            BtnThread2.Size = new Size(75, 24);
            BtnThread2.TabIndex = 2;
            BtnThread2.Text = "스레드";
            BtnThread2.UseVisualStyleBackColor = true;
            BtnThread2.Click += BtnThread2_Click;
            // 
            // BtnThread1
            // 
            BtnThread1.Location = new Point(95, 131);
            BtnThread1.Name = "BtnThread1";
            BtnThread1.Size = new Size(75, 24);
            BtnThread1.TabIndex = 2;
            BtnThread1.Text = "노스레드";
            BtnThread1.UseVisualStyleBackColor = true;
            BtnThread1.Click += BtnThread1_Click;
            // 
            // ProProgressBack
            // 
            ProProgressBack.Location = new Point(6, 97);
            ProProgressBack.Name = "ProProgressBack";
            ProProgressBack.Size = new Size(329, 23);
            ProProgressBack.TabIndex = 1;
            // 
            // TxtResultThread
            // 
            TxtResultThread.Location = new Point(6, 23);
            TxtResultThread.Multiline = true;
            TxtResultThread.Name = "TxtResultThread";
            TxtResultThread.ScrollBars = ScrollBars.Vertical;
            TxtResultThread.Size = new Size(329, 68);
            TxtResultThread.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(BtnNode);
            groupBox7.Controls.Add(BtnRoot);
            groupBox7.Controls.Add(TrvDummy);
            groupBox7.Controls.Add(LsvDummy);
            groupBox7.Location = new Point(12, 371);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(341, 165);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "트리뷰, 리스트뷰";
            // 
            // BtnNode
            // 
            BtnNode.Location = new Point(258, 131);
            BtnNode.Name = "BtnNode";
            BtnNode.Size = new Size(75, 28);
            BtnNode.TabIndex = 3;
            BtnNode.Text = "노드추가";
            BtnNode.UseVisualStyleBackColor = true;
            BtnNode.Click += BtnNode_Click;
            // 
            // BtnRoot
            // 
            BtnRoot.Location = new Point(177, 131);
            BtnRoot.Name = "BtnRoot";
            BtnRoot.Size = new Size(75, 28);
            BtnRoot.TabIndex = 2;
            BtnRoot.Text = "루트추가";
            BtnRoot.UseVisualStyleBackColor = true;
            BtnRoot.Click += BtnRoot_Click;
            // 
            // TrvDummy
            // 
            TrvDummy.ImageIndex = 0;
            TrvDummy.ImageList = imageList1;
            TrvDummy.Location = new Point(22, 23);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.SelectedImageIndex = 0;
            TrvDummy.Size = new Size(142, 97);
            TrvDummy.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            // 
            // LsvDummy
            // 
            LsvDummy.LargeImageList = imageList1;
            LsvDummy.Location = new Point(177, 23);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(142, 97);
            LsvDummy.SmallImageList = imageList1;
            LsvDummy.TabIndex = 0;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.SmallIcon;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 561);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("한컴 말랑말랑 Regular", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 129);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "컨트롤 모음집";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox CboFont;
        private CheckBox ChkBold;
        private TextBox TxtResult;
        private CheckBox ChkItalic;
        private ToolStripStatusLabel LblState;
        private GroupBox groupBox4;
        private TrackBar TrbProcess;
        private ProgressBar PrgProcess;
        private GroupBox groupBox5;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private GroupBox groupBox6;
        private TextBox TxtResultThread;
        private ProgressBar ProProgressBack;
        private Button BtnThread3;
        private Button BtnThread2;
        private Button BtnThread1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox7;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private Button BtnRoot;
        private Button BtnNode;
        private ImageList imageList1;
        private PictureBox PicImage;
        private Button BtnImage;
        private OpenFileDialog DlgOpenImage;
        private MonthCalendar monthCalendar1;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private DateTimePicker dateTimePicker1;
        private LinkLabel linkLabel1;
        private RichTextBox richTextBox1;
        private Button BtnLoad;
        private Button BtnSave;
        private Button BtnCheck;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem 편집ㄷToolStripMenuItem;
        private ToolStripMenuItem MnuNewFile;
        private ToolStripMenuItem MnuExit;
        private ToolStripMenuItem 편집EToolStripMenuItem;
        private ToolStripMenuItem MnuView;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private ColorDialog colorDialog1;
    }
}
