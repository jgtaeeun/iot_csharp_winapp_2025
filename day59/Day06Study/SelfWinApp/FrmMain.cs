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

        List<Question> QuizList;    //출제문제
        int questionCount;          //내가 풀 문제 개수
        List<int> QNum;             //내가 풀 문제 개수별 랜덤문제 배정
        List<int> answeredQuestions = new List<int>();   //푼 문제를 다시 풀면 카운팅하지 않도록
        int currentQuestionIndex = 0;  // 현재 보여지는 문제 번호
        int progressNum = 0; //푼 문제 개수
        int correctNum = 0; //맞힌 문제 개수
        List<int> wrongNum = new List<int>();  //틀린문제 출제문제번호 저장


        // 타이머 관련 필드 추가
        System.Windows.Forms.Timer[] questionTimers;
        int[] timeLeft;


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
            //pictureBox1.Image = Resources.문제1연산자우선순위;
            //radioButton1.Text = QuizList[0].Choices[0];
            //radioButton2.Text = QuizList[0].Choices[1];
            //radioButton3.Text = QuizList[0].Choices[2];
            //radioButton4.Text = QuizList[0].Choices[3];
            numericUpDown1.Value = 0; // 혹은 기본 문제 수 설정

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

            // 타이머 표시 및 실행
            labelTimer.Text = $"남은 시간: {timeLeft[index]}초";
            if (!answeredQuestions.Contains(index))
            {
                questionTimers[index].Start();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // 문제 수만 저장
            questionCount = (int)numericUpDown1.Value;

           
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (questionCount <= 0)
            {
                MessageBox.Show("문제 수를 선택해주세요.");
                return;
            }

            InitQuestions(questionCount); // 여기에 문제 생성, 타이머 초기화 등 다 넣음
            currentQuestionIndex = 0;
            LoadQuestion(currentQuestionIndex);
        }

        private void InitQuestions(int questionCount)
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

            questionTimers = new System.Windows.Forms.Timer[QNum.Count];
            timeLeft = new int[QNum.Count];

            for (int i = 0; i < QNum.Count; i++)
            {
                timeLeft[i] = 60;
                questionTimers[i] = new System.Windows.Forms.Timer();
                questionTimers[i].Interval = 1000;
                int index = i; // 클로저 문제 방지
                questionTimers[i].Tick += (s, e) => Timer_Tick(index);
            }

            // 기존 상태 초기화
            progressNum = 0;
            correctNum = 0;
            answeredQuestions.Clear();
            wrongNum.Clear();
        }

        private void Timer_Tick(int index)
        {
            timeLeft[index]--;

            // 현재 보여지는 문제일 경우만 시간 표시 갱신
            if (index == currentQuestionIndex)
            {
                labelTimer.Text = $"남은 시간: {timeLeft[index]}초";
            }

            if (timeLeft[index] <= 0)
            {
                questionTimers[index].Stop();
                if (!answeredQuestions.Contains(index))
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("시간 초과! 자동으로 정답 확인합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AutoCheckAnswer(index);
                    }));
                }
            }
        }

        private void AutoCheckAnswer(int index)
        {
            int questionIndex = QNum[index];
            var question = QuizList[questionIndex];
            int correctAnswer = question.CorrectAnswer;

            // 자동이니까 오답 처리
            wrongNum.Add(questionIndex);

            progressNum++;
            textBox1.Text = question.Answer;
            progressBar1.Value = (int)((progressNum / (double)numericUpDown1.Value) * 100);
            label5.Text = $"{correctNum}/{numericUpDown1.Value}";
            answeredQuestions.Add(index);
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
            if (answeredQuestions.Contains(currentQuestionIndex))
            {
                MessageBox.Show("이미 푼 문제입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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
                correctNum++;
                MessageBox.Show("정답입니다!", "정답 확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                wrongNum.Add(questionIndex);
                MessageBox.Show("오답입니다.", "정답 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 여기에 타이머 중지 추가
            questionTimers[currentQuestionIndex].Stop();

            progressNum++;
            textBox1.Text = question.Answer;
            progressBar1.Value = (int)((progressNum / (double)numericUpDown1.Value) * 100);
            label5.Text = $"{correctNum}/{numericUpDown1.Value}";
            answeredQuestions.Add(currentQuestionIndex); //이미 푼 문제는 진행률에 포함시키지 않기 위해서
        }


        private void button7_Click(object sender, EventArgs e)
        {

            Modaless frmModaless = new Modaless();

            for (int i = 0; i < wrongNum.Count; i++)
            {
                frmModaless.AddPicture(wrongNum[i]);
            }


            //모달리스창일 때 부모창을 클릭할 수 있음->그러므로 부모center이 안 먹힘.
            frmModaless.StartPosition = FormStartPosition.Manual;
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2, this.Location.Y + (this.Height - frmModaless.Height) / 2);
            frmModaless.Show(this);
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


        private void TooltipSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF파일 (*.rtf)|*.rtf|워드파일 (*.docx)|*.docx";
            saveFileDialog1.Title = "문서파일 저장";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //종료를 안 시킴
                e.Cancel = true;
            }
        }

        private void ToolTipHelp_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "도움말";
            frmModal.Width = 400;  // 크기 조정 (너비를 늘려서 텍스트가 잘리지 않게)
            frmModal.Height = 280;  // 폼의 높이 설정

            // 텍스트 내용을 표시할 Label 생성
            Label lblHelp = new Label();
            lblHelp.Text = "앱의 목적:\r\n이 앱은 원하는 갯수의 문제를 풀어보며 메모를 색깔을 넣어서 할 수 있는 앱입니다.\r\n\r\n" +
                "규칙:\r\n각 문제는 4개의 선택지 중 하나를 선택하는 형식입니다.\r\n문제를 푼 후, '정답 확인' 버튼을 눌러 정답을 확인할 수 있습니다.\r\n\r\n" +
                "조작 방법:\r\n이전’과 ‘다음’ 버튼을 사용하여 문제를 탐색할 수 있습니다.진행률은 프로그레스바를 통해 확인할 수 있습니다.\r\n\r\n" +
                "추천: 중요한 부분이나 암기해야할 부분을 빨간색으로 강조하여 저장할 수 있는 메모를 활용해보세요";
            lblHelp.AutoSize = true;  // 내용에 맞게 자동 크기 조정
            lblHelp.Location = new Point(10, 10);  // 위치 설정 (폼 내에서 10,10 좌표로 위치 지정)
            lblHelp.MaximumSize = new Size(frmModal.Width - 20, 0);  // 최대 너비를 폼의 너비에 맞게 설정

            // Label을 폼에 추가
            frmModal.Controls.Add(lblHelp);

            // 모달창 중앙에 띄우기
            frmModal.StartPosition = FormStartPosition.CenterParent;
            frmModal.ShowDialog();
        }

        
    }
}
