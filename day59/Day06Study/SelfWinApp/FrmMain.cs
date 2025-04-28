using SelfWinApp.Properties;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace SelfWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        List<Question> QuizList;
        List<int> QNum;

        int currentQuestionIndex = 0;  // ���� �������� ���� ��ȣ
        int progressNum = 0; //Ǭ ���� ����

        private void FrmMain_Load(object sender, EventArgs e)
        {
            QuizList = new List<Question>
            {
                new Question
                {

                    Choices = new List<string> { "0", "1", "2", "�����Ͽ���" },
                    CorrectAnswer = 0,
                    Answer = "��� ����:\r\n1.���� ���� �� 4 * 2 = 8\r\n2.���� �� 3 + 8 = 11\r\n3.11 > 10 �� true (1)\r\n4.3 + 1 = 4 �� 5 < 4 �� false (0)\r\n1 && 0 �� false (0)"
                },
                new Question
                {

                    Choices = new List<string> { "ABCD-*+", "AB+CD-", "AB+C-D*", "ABCD+-*" },
                    CorrectAnswer = 0,
                    Answer = "�켱������: ��ȣ > ���� > ����\r\n(C - D) �� CD-\r\nB * (CD-) �� BCD-*\r\nA + (BCD-*) �� ABCD-*+"
                },
                  new Question
                {

                    Choices = new List<string> { "64", "62", "256", "254" },
                    CorrectAnswer = 1,
                    Answer ="IP: 192.168.10.0/26\r\n/26 �� ���� ȣ��Ʈ ��Ʈ: 32 - 26 = 6\r\n������ �ּ� ��: 2^6 = 64\r\n��� ������ ȣ��Ʈ ��: 64 - 2 = 62 (��Ʈ��ũ �ּ� + ��ε�ĳ��Ʈ �ּ� ����)"
                },
            };
            pictureBox1.Image = Resources.����1�����ڿ켱����;
            radioButton1.Text = QuizList[0].Choices[0];
            radioButton2.Text = QuizList[0].Choices[1];
            radioButton3.Text = QuizList[0].Choices[2];
            radioButton4.Text = QuizList[0].Choices[3];


        }

        private void LoadQuestion(int index)
        {

            int questionId = QNum[index]; // QNum���� ���� �ε����� ������
            var question = QuizList[questionId];

            switch (questionId)
            {
                case 0:
                    pictureBox1.Image = Resources.����1�����ڿ켱����;
                    break;
                case 1:
                    pictureBox1.Image = Resources.����2��������;
                    break;
                case 2:
                    pictureBox1.Image = Resources.����3����ݸ���ũ;
                    break;
            }

            radioButton1.Text = question.Choices[0];
            radioButton2.Text = question.Choices[1];
            radioButton3.Text = question.Choices[2];
            radioButton4.Text = question.Choices[3];

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            QNum = new List<int>();
            Random rand = new Random();

            int num;

            int value = (int)numericUpDown1.Value;
            if (value > 3)
            {
                QNum.Add(0);
                QNum.Add(1);
                QNum.Add(2);

                for (int i = 0; i < value - 3; i++)
                {
                    num = rand.Next(0, 3);
                    QNum.Add(num);
                }


            }
            else if (value == 3)
            {
                QNum.Add(0);
                QNum.Add(1);
                QNum.Add(2);
            }
            else if (value == 2)
            {
                QNum.Add(0);
                QNum.Add(1);
            }
            else
            {
                QNum.Add(0);

            }

            currentQuestionIndex = 0;
            LoadQuestion(currentQuestionIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (QNum == null || QNum.Count <= 1)
            {
                MessageBox.Show("���� ������ �����ϴ�.");
                return;
            }


            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("ù ��° �����Դϴ�.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (QNum == null || QNum.Count <= 1)
            {
                MessageBox.Show("���� ������ �����ϴ�.");
                return;
            }

            if (currentQuestionIndex < QNum.Count - 1)
            {
                currentQuestionIndex++;
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("������ �����Դϴ�.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            if (QNum == null || QNum.Count == 0) return;


            int questionIndex = QNum[currentQuestionIndex];   //������ȣ
            var question = QuizList[questionIndex];         //����
            int correctAnswer = question.CorrectAnswer;      //������
            int selectedAnswer = -1;

            if (radioButton1.Checked) selectedAnswer = 0;
            else if (radioButton2.Checked) selectedAnswer = 1;
            else if (radioButton3.Checked) selectedAnswer = 2;
            else if (radioButton4.Checked) selectedAnswer = 3;

            if (selectedAnswer == -1)
            {
                MessageBox.Show("���⸦ �������ּ���.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedAnswer == correctAnswer)
            {
                MessageBox.Show("�����Դϴ�!", "���� Ȯ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("�����Դϴ�.", "���� Ȯ��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            progressNum++;
            textBox1.Text = question.Answer;
            progressBar1.Value = (int)((progressNum / (double)numericUpDown1.Value) * 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF���� (*.rtf)|*.rtf|�������� (*.docx)|*.docx";
            saveFileDialog1.Title = "�������� ����";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF���� (*.rtf)|*.rtf|�������� (*.docx)|*.docx";
            openFileDialog1.Title = "RTF���� �б�";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
            }

        }
    }
}
