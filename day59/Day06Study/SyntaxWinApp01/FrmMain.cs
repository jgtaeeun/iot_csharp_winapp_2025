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
            //백그라운드 워커 초기화

           
            BgwProcess.WorkerReportsProgress = true;  //진행상황 리포트할 것인지
            BgwProcess.DoWork += BgwProcess_DoWork;   //백그라운드 진행 이벤트
            BgwProcess.ProgressChanged += BgwProcess_ProgressChanged; //백그라운드 진행상태 변경 이벤트 UI
            BgwProcess.RunWorkerCompleted += BgwProcess_RunWorkerCompleted; //백그라운드 진행완료 이벤트

            // 버튼 클릭 이벤트
            BtnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            LblState.Text = "현재상태 : 진행";
            BtnStart.Text = "진행 중";
            BtnStart.Enabled = false;

            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;
            PrgProcess.Value = 0;

            TxtLog.Clear();

            BgwProcess.RunWorkerAsync(); //백그라운드 작업 시작

        }

        //백그라운드 실제 작업
        private void BgwProcess_DoWork(object? sender, DoWorkEventArgs e)
        {
            long MaxVal = 200;
            long total = 0;

            for (int i = 0; i < MaxVal; i++) 
            {
                total += i % 3;

                int progress = (int)((i * 100) / MaxVal) + 1;
                //진행상황을 ProgressChanged 이벤트쪽으로 전달
                BgwProcess.ReportProgress(progress, i);
                Thread.Sleep(50);
            }
        }

        //진행상태를 UI에 업데이트
        private void BgwProcess_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            //DoWork()함수의 ReportProgress(progress, i)
            int progress = e.ProgressPercentage;  //int형인 progress
            int currVal = (int) e.UserState;         //object형인 i

            PrgProcess.Value = progress;

            TxtLog.AppendText(currVal.ToString()+"\r\n");
            TxtLog.SelectionStart = TxtLog.Text.Length;
            TxtLog.ScrollToCaret();

            LblState.Text = $"현재상태 : {progress}";


        }
        //백그라운드 작업 완료된 후 처리 이벤트
        private void BgwProcess_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            LblState.Text = "현재상태 : 중지";
            BtnStart.Text = "시작";
            BtnStart.Enabled = true;

        }

    }
}
