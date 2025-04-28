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

        int currentQuestionIndex = 0;  // 현재 보여지는 문제 번호
        int progressNum = 0; //푼 문제 개수

        private void FrmMain_Load(object sender, EventArgs e)
        {
            QuizList = new List<Question>
            {
                new Question
                {

                    Choices = new List<string> { "0", "1", "2", "컴파일오류" },
                    CorrectAnswer = 0,
                    Answer = "계산 순서:\r\n1.곱셈 먼저 → 4 * 2 = 8\r\n2.덧셈 → 3 + 8 = 11\r\n3.11 > 10 → true (1)\r\n4.3 + 1 = 4 → 5 < 4 → false (0)\r\n1 && 0 → false (0)"
                },
                new Question
                {

                    Choices = new List<string> { "ABCD-*+", "AB+CD-", "AB+C-D*", "ABCD+-*" },
                    CorrectAnswer = 0,
                    Answer = "우선순위는: 괄호 > 곱셈 > 덧셈\r\n(C - D) → CD-\r\nB * (CD-) → BCD-*\r\nA + (BCD-*) → ABCD-*+"
                },
                  new Question
                {

                    Choices = new List<string> { "64", "62", "256", "254" },
                    CorrectAnswer = 1,
                    Answer ="IP: 192.168.10.0/26\r\n/26 → 남은 호스트 비트: 32 - 26 = 6\r\n가능한 주소 수: 2^6 = 64\r\n사용 가능한 호스트 수: 64 - 2 = 62 (네트워크 주소 + 브로드캐스트 주소 제외)"
                },
            };
            pictureBox1.Image = Resources.문제1연산자우선순위;
            radioButton1.Text = QuizList[0].Choices[0];
            radioButton2.Text = QuizList[0].Choices[1];
            radioButton3.Text = QuizList[0].Choices[2];
            radioButton4.Text = QuizList[0].Choices[3];


        }

        private void LoadQuestion(int index)
        {

            int questionId = QNum[index]; // QNum에서 문제 인덱스를 가져옴
            var question = QuizList[questionId];

            switch (questionId)
            {
                case 0:
                    pictureBox1.Image = Resources.문제1연산자우선순위;
                    break;
                case 1:
                    pictureBox1.Image = Resources.문제2후위연산;
                    break;
                case 2:
                    pictureBox1.Image = Resources.문제3서브넷마스크;
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
                MessageBox.Show("이전 문제가 없습니다.");
                return;
            }


            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("첫 번째 문제입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (QNum == null || QNum.Count <= 1)
            {
                MessageBox.Show("다음 문제가 없습니다.");
                return;
            }

            if (currentQuestionIndex < QNum.Count - 1)
            {
                currentQuestionIndex++;
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("마지막 문제입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            if (QNum == null || QNum.Count == 0) return;


            int questionIndex = QNum[currentQuestionIndex];   //문제번호
            var question = QuizList[questionIndex];         //문제
            int correctAnswer = question.CorrectAnswer;      //문제답
            int selectedAnswer = -1;

            if (radioButton1.Checked) selectedAnswer = 0;
            else if (radioButton2.Checked) selectedAnswer = 1;
            else if (radioButton3.Checked) selectedAnswer = 2;
            else if (radioButton4.Checked) selectedAnswer = 3;

            if (selectedAnswer == -1)
            {
                MessageBox.Show("보기를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedAnswer == correctAnswer)
            {
                MessageBox.Show("정답입니다!", "정답 확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("오답입니다.", "정답 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            progressNum++;
            textBox1.Text = question.Answer;
            progressBar1.Value = (int)((progressNum / (double)numericUpDown1.Value) * 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF파일 (*.rtf)|*.rtf|워드파일 (*.docx)|*.docx";
            saveFileDialog1.Title = "문서파일 저장";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF파일 (*.rtf)|*.rtf|워드파일 (*.docx)|*.docx";
            openFileDialog1.Title = "RTF파일 읽기";

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
