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
            button1 = new Button();
            LblPain = new Label();
            TxtPain = new TextBox();
            LblPain2 = new Label();
            CboPainPoint = new ComboBox();
            TxtResult = new TextBox();
            BtnDisplay = new Button();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("한컴 울주 반구대 암각화체", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(461, 347);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 7;
            button1.Text = "메시지";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnMsg_Click;
            // 
            // LblPain
            // 
            LblPain.AutoSize = true;
            LblPain.Location = new Point(42, 42);
            LblPain.Name = "LblPain";
            LblPain.Size = new Size(55, 15);
            LblPain.TabIndex = 0;
            LblPain.Text = "통증여부";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(115, 39);
            TxtPain.MaxLength = 3;
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니오";
            TxtPain.Size = new Size(100, 23);
            TxtPain.TabIndex = 1;
            TxtPain.TextChanged += TxtPain_TextChanged;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // LblPain2
            // 
            LblPain2.AutoSize = true;
            LblPain2.Location = new Point(42, 79);
            LblPain2.Name = "LblPain2";
            LblPain2.Size = new Size(55, 15);
            LblPain2.TabIndex = 2;
            LblPain2.Text = "통증부위";
            // 
            // CboPainPoint
            // 
            CboPainPoint.FormattingEnabled = true;
            CboPainPoint.Items.AddRange(new object[] { "머리", "눈", "코", "목", "가슴", "배" });
            CboPainPoint.Location = new Point(115, 76);
            CboPainPoint.Name = "CboPainPoint";
            CboPainPoint.Size = new Size(121, 23);
            CboPainPoint.TabIndex = 3;
            CboPainPoint.Text = "부위선택";
            CboPainPoint.SelectedIndexChanged += CboPainPoint_SelectedIndexChanged;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(42, 120);
            TxtResult.MaxLength = 3;
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(519, 212);
            TxtResult.TabIndex = 4;
            // 
            // BtnDisplay
            // 
            BtnDisplay.BackColor = SystemColors.InactiveCaption;
            BtnDisplay.Font = new Font("한컴 울주 반구대 암각화체", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            BtnDisplay.ForeColor = SystemColors.ActiveCaption;
            BtnDisplay.Location = new Point(341, 347);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(100, 40);
            BtnDisplay.TabIndex = 6;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = false;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // BtnWhile
            // 
            BtnWhile.BackColor = SystemColors.InactiveCaption;
            BtnWhile.Font = new Font("한컴 울주 반구대 암각화체", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            BtnWhile.ForeColor = SystemColors.ActiveCaption;
            BtnWhile.Location = new Point(218, 347);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(100, 40);
            BtnWhile.TabIndex = 5;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = false;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 450);
            Controls.Add(BtnWhile);
            Controls.Add(BtnDisplay);
            Controls.Add(TxtResult);
            Controls.Add(CboPainPoint);
            Controls.Add(LblPain2);
            Controls.Add(TxtPain);
            Controls.Add(LblPain);
            Controls.Add(button1);
            Name = "FrmMain";
            Text = "문법학습 윈앱03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label LblPain;
        private TextBox TxtPain;
        private Label LblPain2;
        private ComboBox CboPainPoint;
        private TextBox TxtResult;
        private Button BtnDisplay;
        private Button BtnWhile;
    }
}
