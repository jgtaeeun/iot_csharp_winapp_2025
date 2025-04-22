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
            LblName = new Label();
            TxtName = new TextBox();
            LblAge = new Label();
            LblGender = new Label();
            RdoFemale = new RadioButton();
            RdoMale = new RadioButton();
            LblResult = new Label();
            TxtResult = new TextBox();
            BtnOk = new Button();
            TxtAge = new MaskedTextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(34, 30);
            LblName.Name = "LblName";
            LblName.Size = new Size(58, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름입력:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(98, 27);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(34, 67);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(58, 15);
            LblAge.TabIndex = 0;
            LblAge.Text = "생년월일:";
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(34, 103);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(58, 15);
            LblGender.TabIndex = 0;
            LblGender.Text = "이름입력:";
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Checked = true;
            RdoFemale.Location = new Point(103, 103);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(49, 19);
            RdoFemale.TabIndex = 3;
            RdoFemale.TabStop = true;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.Location = new Point(149, 103);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(49, 19);
            RdoMale.TabIndex = 3;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(34, 143);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(58, 15);
            LblResult.TabIndex = 4;
            LblResult.Text = "결      과:";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(98, 140);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(387, 23);
            TxtResult.TabIndex = 5;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(365, 331);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(100, 40);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "확인";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(98, 64);
            TxtAge.Mask = "0000-00-00";
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(100, 23);
            TxtAge.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(TxtAge);
            Controls.Add(BtnOk);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(RdoMale);
            Controls.Add(RdoFemale);
            Controls.Add(TxtName);
            Controls.Add(LblGender);
            Controls.Add(LblAge);
            Controls.Add(LblName);
            Name = "FrmMain";
            Text = "문법학습 윈앱01";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private Label LblGender;
        private RadioButton RdoFemale;
        private RadioButton RdoMale;
        private Label LblResult;
        private TextBox TxtResult;
        private Button BtnOk;
        private MaskedTextBox TxtAge;
    }
}
