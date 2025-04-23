namespace SyntaxWinApp01
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            TxtResult = new TextBox();
            TxtGender = new TextBox();
            TxtPhone = new MaskedTextBox();
            NudAge = new NumericUpDown();
            ㅍ = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtName = new TextBox();
            BtnSubmit = new Button();
            PicResult = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 36);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "이름:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(NudAge);
            groupBox1.Controls.Add(ㅍ);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 35);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(273, 287);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "정보입력/결과";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 192);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "결과:";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(6, 209);
            TxtResult.Margin = new Padding(3, 2, 3, 2);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(261, 66);
            TxtResult.TabIndex = 5;
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(104, 116);
            TxtGender.Margin = new Padding(3, 2, 3, 2);
            TxtGender.MaxLength = 1;
            TxtGender.Name = "TxtGender";
            TxtGender.PlaceholderText = "남 또는 여";
            TxtGender.Size = new Size(100, 23);
            TxtGender.TabIndex = 3;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(104, 159);
            TxtPhone.Margin = new Padding(3, 2, 3, 2);
            TxtPhone.Mask = "000-0000-0000";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(100, 23);
            TxtPhone.TabIndex = 4;
            // 
            // NudAge
            // 
            NudAge.Location = new Point(104, 73);
            NudAge.Margin = new Padding(3, 2, 3, 2);
            NudAge.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            NudAge.Name = "NudAge";
            NudAge.Size = new Size(100, 23);
            NudAge.TabIndex = 2;
            // 
            // ㅍ
            // 
            ㅍ.AutoSize = true;
            ㅍ.Location = new Point(40, 162);
            ㅍ.Name = "ㅍ";
            ㅍ.Size = new Size(58, 15);
            ㅍ.TabIndex = 0;
            ㅍ.Text = "전화번호:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 119);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 0;
            label3.Text = "성별:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 75);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "나이:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(104, 33);
            TxtName.Margin = new Padding(3, 2, 3, 2);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 1;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(471, 316);
            BtnSubmit.Margin = new Padding(3, 2, 3, 2);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(89, 32);
            BtnSubmit.TabIndex = 6;
            BtnSubmit.Text = "제출";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // PicResult
            // 
            PicResult.BackColor = SystemColors.ControlLight;
            PicResult.Image = Properties.Resources.girl;
            PicResult.Location = new Point(300, 50);
            PicResult.Margin = new Padding(3, 2, 3, 2);
            PicResult.Name = "PicResult";
            PicResult.Size = new Size(260, 260);
            PicResult.SizeMode = PictureBoxSizeMode.StretchImage;
            PicResult.TabIndex = 3;
            PicResult.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(PicResult);
            Controls.Add(BtnSubmit);
            Controls.Add(groupBox1);
            Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMain";
            Text = "문법학습 윈앱01(예외처리)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox TxtName;
        private Label label3;
        private Label label2;
        private Label ㅍ;
        private Button BtnSubmit;
        private NumericUpDown NudAge;
        private MaskedTextBox TxtPhone;
        private PictureBox PicResult;
        private TextBox TxtGender;
        private TextBox TxtResult;
        private Label label4;
    }
}
