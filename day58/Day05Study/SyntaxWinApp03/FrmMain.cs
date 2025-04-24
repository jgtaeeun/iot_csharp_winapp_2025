using System;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //2 .��ư�� ������ �ð��� ���� �ɸ��� �۾��� UI ���� ���� ó���ϸ鼭 �����(ProgressBar) �� �����ִ� ������,
        //�ٽ��� async/await, Task.Run(), �׸��� Invoke() �����̾�.


        //2-1.async 
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "������� : ����";
            BtnStart.Text = "������";
            BtnStart.Enabled = false; //ó�������� ��ư Ŭ�� ����.

            //1-1.��û�� �ð��� �ɸ��� ���� ����
            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            await Task.Run(() => {

                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;
                    int progress = (int)((i * 100 / MaxVal)) + 1;
                    Console.WriteLine(progress.ToString());
                    //Task.Run �� ���� UIó�� ����
                    this.Invoke(new Action(() => {

                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length;
                        TxtLog.ScrollToCaret();
                        PrgProcess.Value = progress;


                    }));
                    Thread.Sleep(50);

                }
            });

            // �۾� �Ϸ� �� UI ���� ����
            this.Invoke((Action)(() =>
            {
                LblCurrState.Text = "������� : ����";
                BtnStart.Text = "����";
                BtnStart.Enabled = true;
            }));
        }
    }
}