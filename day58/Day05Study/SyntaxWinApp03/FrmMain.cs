using System;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //2 .버튼을 누르면 시간이 오래 걸리는 작업을 UI 멈춤 없이 처리하면서 진행률(ProgressBar) 을 보여주는 구조고,
        //핵심은 async/await, Task.Run(), 그리고 Invoke() 사용법이야.


        //2-1.async 
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "현재상태 : 진행";
            BtnStart.Text = "진행중";
            BtnStart.Enabled = false; //처리동안은 버튼 클릭 못함.

            //1-1.엄청난 시간이 걸리는 연산 수행
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
                    //Task.Run 내 들어가는 UI처리 로직
                    this.Invoke(new Action(() => {

                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length;
                        TxtLog.ScrollToCaret();
                        PrgProcess.Value = progress;


                    }));
                    Thread.Sleep(50);

                }
            });

            // 작업 완료 후 UI 상태 변경
            this.Invoke((Action)(() =>
            {
                LblCurrState.Text = "현재상태 : 중지";
                BtnStart.Text = "시작";
                BtnStart.Enabled = true;
            }));
        }
    }
}