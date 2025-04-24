namespace SyntaxWinApp02
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
            BtnCheck = new Button();
            TxtResult = new TextBox();
            TxtTest = new TextBox();
            BtnGeneric = new Button();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(473, 301);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(99, 48);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(24, 12);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(535, 283);
            TxtResult.TabIndex = 1;
            // 
            // TxtTest
            // 
            TxtTest.Location = new Point(24, 315);
            TxtTest.Name = "TxtTest";
            TxtTest.Size = new Size(100, 23);
            TxtTest.TabIndex = 2;
            // 
            // BtnGeneric
            // 
            BtnGeneric.Location = new Point(368, 301);
            BtnGeneric.Name = "BtnGeneric";
            BtnGeneric.Size = new Size(99, 48);
            BtnGeneric.TabIndex = 3;
            BtnGeneric.Text = "제네릭";
            BtnGeneric.UseVisualStyleBackColor = true;
            BtnGeneric.Click += BtnGeneric_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(BtnGeneric);
            Controls.Add(TxtTest);
            Controls.Add(TxtResult);
            Controls.Add(BtnCheck);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "고급학습 윈앱";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private TextBox TxtResult;
        private TextBox TxtTest;
        private Button BtnGeneric;
    }
}
