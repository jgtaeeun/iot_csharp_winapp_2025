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

        List<Question> QuizList;    //��������
        int questionCount;          //���� Ǯ ���� ����
        List<int> QNum;             //���� Ǯ ���� ������ �������� ����
        List<int> answeredQuestions = new List<int>();   //Ǭ ������ �ٽ� Ǯ�� ī�������� �ʵ���
        int currentQuestionIndex = 0;  // ���� �������� ���� ��ȣ
        int progressNum = 0; //Ǭ ���� ����
        int correctNum = 0; //���� ���� ����
        List<int> wrongNum = new List<int>();  //Ʋ������ ����������ȣ ����


        // Ÿ�̸� ���� �ʵ� �߰�
        System.Windows.Forms.Timer[] questionTimers;
        int[] timeLeft;


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
            //pictureBox1.Image = Resources.����1�����ڿ켱����;
            //radioButton1.Text = QuizList[0].Choices[0];
            //radioButton2.Text = QuizList[0].Choices[1];
            //radioButton3.Text = QuizList[0].Choices[2];
            //radioButton4.Text = QuizList[0].Choices[3];
            numericUpDown1.Value = 0; // Ȥ�� �⺻ ���� �� ����

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

            // Ÿ�̸� ǥ�� �� ����
            labelTimer.Text = $"���� �ð�: {timeLeft[index]}��";
            if (!answeredQuestions.Contains(index))
            {
                questionTimers[index].Start();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // ���� ���� ����
            questionCount = (int)numericUpDown1.Value;

           
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (questionCount <= 0)
            {
                MessageBox.Show("���� ���� �������ּ���.");
                return;
            }

            InitQuestions(questionCount); // ���⿡ ���� ����, Ÿ�̸� �ʱ�ȭ �� �� ����
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
                int index = i; // Ŭ���� ���� ����
                questionTimers[i].Tick += (s, e) => Timer_Tick(index);
            }

            // ���� ���� �ʱ�ȭ
            progressNum = 0;
            correctNum = 0;
            answeredQuestions.Clear();
            wrongNum.Clear();
        }

        private void Timer_Tick(int index)
        {
            timeLeft[index]--;

            // ���� �������� ������ ��츸 �ð� ǥ�� ����
            if (index == currentQuestionIndex)
            {
                labelTimer.Text = $"���� �ð�: {timeLeft[index]}��";
            }

            if (timeLeft[index] <= 0)
            {
                questionTimers[index].Stop();
                if (!answeredQuestions.Contains(index))
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("�ð� �ʰ�! �ڵ����� ���� Ȯ���մϴ�.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // �ڵ��̴ϱ� ���� ó��
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
            if (answeredQuestions.Contains(currentQuestionIndex))
            {
                MessageBox.Show("�̹� Ǭ �����Դϴ�.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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
                correctNum++;
                MessageBox.Show("�����Դϴ�!", "���� Ȯ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                wrongNum.Add(questionIndex);
                MessageBox.Show("�����Դϴ�.", "���� Ȯ��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // ���⿡ Ÿ�̸� ���� �߰�
            questionTimers[currentQuestionIndex].Stop();

            progressNum++;
            textBox1.Text = question.Answer;
            progressBar1.Value = (int)((progressNum / (double)numericUpDown1.Value) * 100);
            label5.Text = $"{correctNum}/{numericUpDown1.Value}";
            answeredQuestions.Add(currentQuestionIndex); //�̹� Ǭ ������ ������� ���Խ�Ű�� �ʱ� ���ؼ�
        }


        private void button7_Click(object sender, EventArgs e)
        {

            Modaless frmModaless = new Modaless();

            for (int i = 0; i < wrongNum.Count; i++)
            {
                frmModaless.AddPicture(wrongNum[i]);
            }


            //��޸���â�� �� �θ�â�� Ŭ���� �� ����->�׷��Ƿ� �θ�center�� �� ����.
            frmModaless.StartPosition = FormStartPosition.Manual;
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2, this.Location.Y + (this.Height - frmModaless.Height) / 2);
            frmModaless.Show(this);
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


        private void TooltipSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF���� (*.rtf)|*.rtf|�������� (*.docx)|*.docx";
            saveFileDialog1.Title = "�������� ����";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //���Ḧ �� ��Ŵ
                e.Cancel = true;
            }
        }

        private void ToolTipHelp_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "����";
            frmModal.Width = 400;  // ũ�� ���� (�ʺ� �÷��� �ؽ�Ʈ�� �߸��� �ʰ�)
            frmModal.Height = 280;  // ���� ���� ����

            // �ؽ�Ʈ ������ ǥ���� Label ����
            Label lblHelp = new Label();
            lblHelp.Text = "���� ����:\r\n�� ���� ���ϴ� ������ ������ Ǯ��� �޸� ������ �־ �� �� �ִ� ���Դϴ�.\r\n\r\n" +
                "��Ģ:\r\n�� ������ 4���� ������ �� �ϳ��� �����ϴ� �����Դϴ�.\r\n������ Ǭ ��, '���� Ȯ��' ��ư�� ���� ������ Ȯ���� �� �ֽ��ϴ�.\r\n\r\n" +
                "���� ���:\r\n�������� �������� ��ư�� ����Ͽ� ������ Ž���� �� �ֽ��ϴ�.������� ���α׷����ٸ� ���� Ȯ���� �� �ֽ��ϴ�.\r\n\r\n" +
                "��õ: �߿��� �κ��̳� �ϱ��ؾ��� �κ��� ���������� �����Ͽ� ������ �� �ִ� �޸� Ȱ���غ�����";
            lblHelp.AutoSize = true;  // ���뿡 �°� �ڵ� ũ�� ����
            lblHelp.Location = new Point(10, 10);  // ��ġ ���� (�� ������ 10,10 ��ǥ�� ��ġ ����)
            lblHelp.MaximumSize = new Size(frmModal.Width - 20, 0);  // �ִ� �ʺ� ���� �ʺ� �°� ����

            // Label�� ���� �߰�
            frmModal.Controls.Add(lblHelp);

            // ���â �߾ӿ� ����
            frmModal.StartPosition = FormStartPosition.CenterParent;
            frmModal.ShowDialog();
        }

        
    }
}
