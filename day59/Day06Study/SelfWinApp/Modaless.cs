using SelfWinApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfWinApp
{
    internal class Modaless : Form
    {//여러 이미지 표시용

        private FlowLayoutPanel flowPanel;


        public Modaless()
        {
            this.Text = "오답노트";
            this.Size = new Size(600, 400);

            // FlowLayoutPanel 생성
            flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;  // 스크롤 가능
            this.Controls.Add(flowPanel);
        }

        public void AddPicture(int num)
        {
            Image image = null;

            switch (num)
            {
                case 0:
                    image = Resources.문제1연산자우선순위;
                    break;
                case 1:
                    image = Resources.문제2후위연산;
                    break;
                case 2:
                    image = Resources.문제3서브넷마스크;
                    break;
                default:
                    break;
            }

            if (image != null)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 500; // 원하는 크기로 조정
                pictureBox.Height = 300;
                pictureBox.Margin = new Padding(10);

                flowPanel.Controls.Add(pictureBox);
            }
            else
            {
                MessageBox.Show("이미지를 불러올 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
