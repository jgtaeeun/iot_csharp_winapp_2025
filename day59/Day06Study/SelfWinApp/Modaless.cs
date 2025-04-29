using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWinApp
{
    internal class Modaless : Form
    {
        public Modaless()
        {
            this.Text = "오답노트";
            this.Size = new Size(300, 100);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("sample.png"); // 경로는 실제 이미지 파일로 교체
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;

            this.Controls.Add(pictureBox);
        }
    }
}
