namespace SyntaxWinApp03
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
            BtnSave = new Button();
            imageList1 = new ImageList(components);
            BtnLoad = new Button();
            RtbResult = new RichTextBox();
            BtnRed = new Button();
            BtnBold = new Button();
            DlgOpen = new OpenFileDialog();
            DlgSave = new SaveFileDialog();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSave.ImageIndex = 1;
            BtnSave.ImageList = imageList1;
            BtnSave.Location = new Point(357, 239);
            BtnSave.Name = "BtnSave";
            BtnSave.Padding = new Padding(10, 0, 0, 0);
            BtnSave.Size = new Size(100, 28);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder.png");
            imageList1.Images.SetKeyName(1, "save.png");
            // 
            // BtnLoad
            // 
            BtnLoad.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLoad.ImageIndex = 0;
            BtnLoad.ImageList = imageList1;
            BtnLoad.Location = new Point(472, 239);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Padding = new Padding(10, 0, 0, 0);
            BtnLoad.Size = new Size(100, 28);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "읽기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // RtbResult
            // 
            RtbResult.Font = new Font("나눔고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RtbResult.Location = new Point(12, 11);
            RtbResult.Name = "RtbResult";
            RtbResult.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            RtbResult.Size = new Size(560, 222);
            RtbResult.TabIndex = 2;
            RtbResult.Text = "";
            // 
            // BtnRed
            // 
            BtnRed.BackColor = SystemColors.ControlLight;
            BtnRed.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnRed.ForeColor = Color.Red;
            BtnRed.Location = new Point(279, 239);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(28, 28);
            BtnRed.TabIndex = 3;
            BtnRed.Text = "R";
            BtnRed.UseVisualStyleBackColor = false;
            BtnRed.Click += BtnRed_Click;
            // 
            // BtnBold
            // 
            BtnBold.BackColor = SystemColors.ControlLight;
            BtnBold.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnBold.ForeColor = Color.Black;
            BtnBold.Location = new Point(313, 239);
            BtnBold.Name = "BtnBold";
            BtnBold.Size = new Size(28, 28);
            BtnBold.TabIndex = 4;
            BtnBold.Text = "B";
            BtnBold.UseVisualStyleBackColor = false;
            BtnBold.Click += BtnBold_Click;
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 290);
            Controls.Add(BtnBold);
            Controls.Add(BtnRed);
            Controls.Add(RtbResult);
            Controls.Add(BtnLoad);
            Controls.Add(BtnSave);
            Font = new Font("나눔고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "파일입출력 윈앱";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSave;
        private Button BtnLoad;
        private RichTextBox RtbResult;
        private ImageList imageList1;
        private Button BtnRed;
        private Button BtnBold;
        private OpenFileDialog DlgOpen;
        private SaveFileDialog DlgSave;
    }
}
