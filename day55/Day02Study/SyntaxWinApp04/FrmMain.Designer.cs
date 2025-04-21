namespace SyntaxWinApp04
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
            TxtAge = new TextBox();
            LblGender = new Label();
            RdoFemale = new RadioButton();
            RdoMale = new RadioButton();
            BtnMsg = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("한컴 훈민정음 가로쓰기", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblName.Location = new Point(24, 15);
            LblName.Name = "LblName";
            LblName.Size = new Size(72, 17);
            LblName.TabIndex = 0;
            LblName.Text = "이름입력:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(103, 12);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(126, 23);
            TxtName.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Font = new Font("한컴 훈민정음 가로쓰기", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblAge.Location = new Point(24, 60);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(72, 17);
            LblAge.TabIndex = 0;
            LblAge.Text = "나이입력:";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(103, 57);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(126, 23);
            TxtAge.TabIndex = 2;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Font = new Font("한컴 훈민정음 가로쓰기", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblGender.Location = new Point(24, 104);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(72, 17);
            LblGender.TabIndex = 0;
            LblGender.Text = "성별입력:";
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Checked = true;
            RdoFemale.Location = new Point(103, 102);
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
            RdoMale.Location = new Point(158, 102);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(49, 19);
            RdoMale.TabIndex = 4;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // BtnMsg
            // 
            BtnMsg.Font = new Font("한컴 훈민정음 가로쓰기", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            BtnMsg.Location = new Point(411, 293);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 5;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Font = new Font("한컴 훈민정음 가로쓰기", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblResult.Location = new Point(24, 167);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(67, 17);
            LblResult.TabIndex = 0;
            LblResult.Text = "결     과:";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(103, 164);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(408, 23);
            TxtResult.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 358);
            Controls.Add(BtnMsg);
            Controls.Add(RdoMale);
            Controls.Add(RdoFemale);
            Controls.Add(LblGender);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(TxtAge);
            Controls.Add(LblAge);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "FrmMain";
            Text = "문법학습 윈앱04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private TextBox TxtAge;
        private Label LblGender;
        private RadioButton RdoFemale;
        private RadioButton RdoMale;
        private Button BtnMsg;
        private Label LblResult;
        private TextBox TxtResult;
    }
}
