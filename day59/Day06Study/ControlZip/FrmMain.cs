namespace ControlZip
{
    public partial class FrmMain : Form
    {   //스레드 정지
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationToken _cancellationToken;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //-----------------------스레드, 백그라운드 워커   with backgroundWorker1   2. 스레드 버튼     ------------------------
            // 기존 이벤트 핸들러 제거 (중복 방지)
            backgroundWorker1.DoWork -= backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged -= backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted -= backgroundWorker1_RunWorkerCompleted;


            //------------------------공용컨트롤 1. 폰트 가져오기--------------------------
            //OS 내 전체 폰트 가져오기
            var Fonts = FontFamily.Families;
            foreach (var Font in Fonts)
            {
                CboFont.Items.Add(Font.Name);
            }

            LblState.Text = "상태 : 폰트읽기 완료";   //statusStrip 컨트롤의 statusLabel


            //-----------------------스레드, 백그라운드 워커   with backgroundWorker1   2. 스레드 버튼     ------------------------
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;


            //------------------------툴팀 컨트롤 WITH toolTip1--------------------------
            toolTip1.SetToolTip(BtnModal, "모달창 연습 버튼입니다.");
            toolTip1.SetToolTip(BtnModaless, "모달리스창 연습 버튼입니다.");
            toolTip1.SetToolTip(TxtYear, "달력에서 선택한 날의 연도 표시 텍스트 박스입니다.");

        }
        //------------------------공용컨트롤 2. 폰트 설정--------------------------
        private void changeFont()
        {
            if (CboFont.SelectedIndex < 0)
            {
                return;
            }

            FontStyle style = FontStyle.Regular;

            if (ChkBold.Checked) style |= FontStyle.Bold;  //FontStyle.Regular | FontStyle.Bold ->0000|0001=0001
            if (ChkItalic.Checked) style |= FontStyle.Italic; // 0001|0010 = 0011

            TxtResult.Font = new Font((string)CboFont.SelectedItem, 12, style);
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            changeFont();
        }
        //------------------------트랙바 ------------------------
        private void TrbProcess_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
        }

        //-----------------------모달, 모달리스 컨트롤   1. 모달 ------------------------
        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "모달창";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent;
            frmModal.ShowDialog();
        }
        //-----------------------모달, 모달리스 컨트롤   2. 모달리스 ------------------------
        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "모달리스창";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Blue;
            //모달리스창일 때 부모창을 클릭할 수 있음->그러므로 부모center이 안 먹힘.
            frmModal.StartPosition = FormStartPosition.Manual;
            frmModal.Location = new Point(this.Location.X + (this.Width - frmModal.Width) / 2, this.Location.Y + (this.Height - frmModal.Height) / 2);
            frmModal.Show(this);
        }
        //-----------------------모달, 모달리스 컨트롤   3. 메시지박스창(모달창)------------------------
        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtResult.Text, "텍스트박스 문장", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //-----------------------스레드, 백그라운드 워커   with backgroundWorker1   1. 노스레드 버튼    ------------------------
        private void BtnThread1_Click(object sender, EventArgs e)
        {
            
            LblState.Text = "현재상태 : 진행";
            BtnThread1.Enabled = false; //처리동안은 버튼 클릭 못함.

            //엄청난 시간이 걸리는 연산 수행
            long MaxVal = 200;
            long total = 0;
            ProProgressBack.Minimum = 0;
            ProProgressBack.Maximum = 100;
            ProProgressBack.Value = 0;

            for (int i = 0; i < MaxVal; i++)
            {
                total += i % 3;
                int progress = (int)((i * 100 / MaxVal));

                TxtResultThread.Text += i.ToString() + "\r\n";
                TxtResultThread.SelectionStart = TxtResultThread.Text.Length;
                TxtResultThread.ScrollToCaret();
                ProProgressBack.Value = progress;

                Thread.Sleep(50);


            }
            ;

            LblState.Text = "현재상태 : 종료";
            BtnThread1.Enabled = true;
        
        }
        //-----------------------스레드, 백그라운드 워커   with backgroundWorker1   2. 스레드 버튼     ------------------------
        private void BtnThread2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) // 백그라운드 작업이 이미 진행 중이면 새로운 작업 시작하지 않음
            {
                MessageBox.Show("작업이 이미 진행 중입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            LblState.Text = "상태 : 스레드 진행";
            BtnThread3.Enabled = true;
            BtnThread2.Enabled = false;

            // CancellationToken 초기화
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;

            ProProgressBack.Minimum = 0;
            ProProgressBack.Maximum = 100;
            ProProgressBack.Value = 0;

            TxtResultThread.Clear();

            backgroundWorker1.RunWorkerAsync(); //백그라운드 작업 시작
        }


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            long MaxVal = 200;
            long total = 0;

            for (int i = 0; i < MaxVal; i++)
            {
                if (_cancellationToken.IsCancellationRequested) // 취소 요청이 들어오면
                {
                    e.Cancel = true;  // 작업을 취소
                    return;
                }

                total += i % 3;

                int progress = (int)((i * 100) / MaxVal);
                //진행상황을 ProgressChanged 이벤트쪽으로 전달
                backgroundWorker1.ReportProgress(progress, i);
                Thread.Sleep(50);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;  //int형인 progress
            int currVal = (int)e.UserState;         //object형인 i

            ProProgressBack.Value = progress;

            TxtResultThread.AppendText(currVal.ToString() + "\r\n");
            TxtResultThread.SelectionStart = TxtResultThread.Text.Length;
            TxtResultThread.ScrollToCaret();

            LblState.Text = $"현재상태 : {progress}";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                LblState.Text = "상태 : 스레드가 취소되었습니다.";
            }
            else
            {
                LblState.Text = "상태 : 스레드 종료";
            }

            BtnThread3.Enabled = false; // 중단 버튼 비활성화
            BtnThread2.Enabled = true;  // 시작 버튼 활성화


        }

        //-----------------------스레드, 백그라운드 워커   with backgroundWorker1  3. 정지 버튼     ------------------------
        private void BtnThread3_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                // 스레드 작업 중일 때 정지 버튼을 클릭하면 스레드를 즉시 종료합니다.
                LblState.Text = "상태 : 스레드 중단";

                // 작업 취소 요청
                _cancellationTokenSource.Cancel(); // 작업 취소
            }

        }


        //-----------------------트리뷰,리스트뷰 컨트롤 with imageList1    1. 트리뷰 (루트추가, 노드추가)------------------------
        // imageList1은 트리뷰랑 리스트뷰에 폴더구조로 나타낼 때 폴더 아이콘을 위한 것
        private void BtnRoot_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            TrvDummy.Nodes.Add(rand.Next().ToString());
            TreeToList();
        }

        private void BtnNode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("노드를 선택하세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand();  //트리확장 Expand, 트리축소 Collapse
            TreeToList();
        }

        //-----------------------트리뷰,리스트뷰 컨트롤 with imageList1     2. 리스트뷰------------------------
        private void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)  // 트리뷰의 최상위(루트) 노드들을 순회
            {
                TreeToList(node);   // 각각의 루트 노드에 대해 재귀 호출
            }
        }

        //트리뷰(TreeView)의 노드를 ListView에 텍스트 + 깊이 정보 + 아이콘 형태로 옮기는 재귀 함수예요.
        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() });

            //이 줄은 ListViewItem에 아이콘을 설정합니다.
            //ImageIndex = 0은 ListView에 연결된 이미지 리스트(ImageList)에서 첫 번째 이미지를 사용한다는 뜻입니다.
            //FrmMain.cs[디자인]에서 ListView속성을 작은 아이콘, imageList1으로 설정해뒀음
            item.ImageIndex = 0;

            //만든 아이템을 리스트뷰(LsvDummy)에 추가합니다.
            LsvDummy.Items.Add(item);

            //현재 노드의 자식 노드들을 하나씩 순회하면서 재귀 호출합니다.
            foreach (TreeNode subNode in node.Nodes)  // 트리뷰의 최상위(루트) 노드들을 순회
            {
                TreeToList(subNode);   // 각각의 루트 노드에 대해 재귀 호출
            }
        }

        //-----------------------picture box 컨트롤러  with DlgOpenImage ------------------------

        private void BtnImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        //-----------------------기타컨트롤   1. monthCalendar    ------------------------
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(monthCalendar1.SelectionStart.ToString());
            TxtYear.Text = monthCalendar1.SelectionStart.Year.ToString() + "년";
            TxtMonth.Text = monthCalendar1.SelectionStart.Month.ToString() + "월";
            TxtDay.Text = monthCalendar1.SelectionStart.Day.ToString() + "일";

        }

        //-----------------------기타컨트롤  2. dateTimePicker  ------------------------
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //-----------------------기타컨트롤  3.  linkLabel ------------------------
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.naver.com",
                UseShellExecute = true
            });

        }

        //-----------------------메뉴탭 컨트롤 MenuStrip 1. &F로 메뉴탭이름 지정 ------------------------
        //-----------------------메뉴탭 컨트롤 MenuStrip 2. 메뉴탭-파일-종료에서 종료를 누르면 메시지가 뜨고 폼 종료하는 기능 ------------------------
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; //아래의 폼클로징 이벤트를 삭제함으로써 메뉴탭 종료메시지에서 예를 눌렀을 때 바로 폼 종료됨
                //프로그램 완전 종료
                Application.Exit();
            }
        }

        //-----------------------폼 종료 컨트롤 ------------------------
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //종료를 안 시킴
                e.Cancel = true;
            }
        }


        //-----------------------기타컨트롤 with openFileDialog1          4. 파일 로드 ------------------------
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF파일 (*.rtf)|*.rtf|워드파일 (*.docx)|*.docx";
            openFileDialog1.Title = "RTF파일 읽기";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }

        }
        //-----------------------기타컨트롤   with saveFileDialog1         4. 파일 저장 ------------------------
        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF파일 (*.rtf)|*.rtf|워드파일 (*.docx)|*.docx";
            saveFileDialog1.Title = "문서파일 저장";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }

        }
        //-----------------------기타컨트롤  with colorDialog1       4. 파일 글자색 수정(강조) ------------------------
        private void button1_Click(object sender, EventArgs e)
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
