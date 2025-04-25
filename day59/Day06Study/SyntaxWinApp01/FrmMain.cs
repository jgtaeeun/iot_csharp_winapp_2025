using System.ComponentModel;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //��׶��� ��Ŀ �ʱ�ȭ

           
            BgwProcess.WorkerReportsProgress = true;  //�����Ȳ ����Ʈ�� ������
            BgwProcess.DoWork += BgwProcess_DoWork;   //��׶��� ���� �̺�Ʈ
            BgwProcess.ProgressChanged += BgwProcess_ProgressChanged; //��׶��� ������� ���� �̺�Ʈ UI
            BgwProcess.RunWorkerCompleted += BgwProcess_RunWorkerCompleted; //��׶��� ����Ϸ� �̺�Ʈ

            // ��ư Ŭ�� �̺�Ʈ
            BtnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            LblState.Text = "������� : ����";
            BtnStart.Text = "���� ��";
            BtnStart.Enabled = false;

            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;
            PrgProcess.Value = 0;

            TxtLog.Clear();

            BgwProcess.RunWorkerAsync(); //��׶��� �۾� ����

        }

        //��׶��� ���� �۾�
        private void BgwProcess_DoWork(object? sender, DoWorkEventArgs e)
        {
            long MaxVal = 200;
            long total = 0;

            for (int i = 0; i < MaxVal; i++) 
            {
                total += i % 3;

                int progress = (int)((i * 100) / MaxVal) + 1;
                //�����Ȳ�� ProgressChanged �̺�Ʈ������ ����
                BgwProcess.ReportProgress(progress, i);
                Thread.Sleep(50);
            }
        }

        //������¸� UI�� ������Ʈ
        private void BgwProcess_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            //DoWork()�Լ��� ReportProgress(progress, i)
            int progress = e.ProgressPercentage;  //int���� progress
            int currVal = (int) e.UserState;         //object���� i

            PrgProcess.Value = progress;

            TxtLog.AppendText(currVal.ToString()+"\r\n");
            TxtLog.SelectionStart = TxtLog.Text.Length;
            TxtLog.ScrollToCaret();

            LblState.Text = $"������� : {progress}";


        }
        //��׶��� �۾� �Ϸ�� �� ó�� �̺�Ʈ
        private void BgwProcess_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            LblState.Text = "������� : ����";
            BtnStart.Text = "����";
            BtnStart.Enabled = true;

        }

    }
}
