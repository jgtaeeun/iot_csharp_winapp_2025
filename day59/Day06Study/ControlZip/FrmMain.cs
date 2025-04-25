namespace ControlZip
{
    public partial class FrmMain : Form
    {   //������ ����
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationToken _cancellationToken;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //-----------------------������, ��׶��� ��Ŀ   with backgroundWorker1   2. ������ ��ư     ------------------------
            // ���� �̺�Ʈ �ڵ鷯 ���� (�ߺ� ����)
            backgroundWorker1.DoWork -= backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged -= backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted -= backgroundWorker1_RunWorkerCompleted;


            //------------------------������Ʈ�� 1. ��Ʈ ��������--------------------------
            //OS �� ��ü ��Ʈ ��������
            var Fonts = FontFamily.Families;
            foreach (var Font in Fonts)
            {
                CboFont.Items.Add(Font.Name);
            }

            LblState.Text = "���� : ��Ʈ�б� �Ϸ�";   //statusStrip ��Ʈ���� statusLabel


            //-----------------------������, ��׶��� ��Ŀ   with backgroundWorker1   2. ������ ��ư     ------------------------
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;


            //------------------------���� ��Ʈ�� WITH toolTip1--------------------------
            toolTip1.SetToolTip(BtnModal, "���â ���� ��ư�Դϴ�.");
            toolTip1.SetToolTip(BtnModaless, "��޸���â ���� ��ư�Դϴ�.");
            toolTip1.SetToolTip(TxtYear, "�޷¿��� ������ ���� ���� ǥ�� �ؽ�Ʈ �ڽ��Դϴ�.");

        }
        //------------------------������Ʈ�� 2. ��Ʈ ����--------------------------
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
        //------------------------Ʈ���� ------------------------
        private void TrbProcess_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
        }

        //-----------------------���, ��޸��� ��Ʈ��   1. ��� ------------------------
        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "���â";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent;
            frmModal.ShowDialog();
        }
        //-----------------------���, ��޸��� ��Ʈ��   2. ��޸��� ------------------------
        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "��޸���â";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Blue;
            //��޸���â�� �� �θ�â�� Ŭ���� �� ����->�׷��Ƿ� �θ�center�� �� ����.
            frmModal.StartPosition = FormStartPosition.Manual;
            frmModal.Location = new Point(this.Location.X + (this.Width - frmModal.Width) / 2, this.Location.Y + (this.Height - frmModal.Height) / 2);
            frmModal.Show(this);
        }
        //-----------------------���, ��޸��� ��Ʈ��   3. �޽����ڽ�â(���â)------------------------
        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtResult.Text, "�ؽ�Ʈ�ڽ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //-----------------------������, ��׶��� ��Ŀ   with backgroundWorker1   1. �뽺���� ��ư    ------------------------
        private void BtnThread1_Click(object sender, EventArgs e)
        {
            
            LblState.Text = "������� : ����";
            BtnThread1.Enabled = false; //ó�������� ��ư Ŭ�� ����.

            //��û�� �ð��� �ɸ��� ���� ����
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

            LblState.Text = "������� : ����";
            BtnThread1.Enabled = true;
        
        }
        //-----------------------������, ��׶��� ��Ŀ   with backgroundWorker1   2. ������ ��ư     ------------------------
        private void BtnThread2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) // ��׶��� �۾��� �̹� ���� ���̸� ���ο� �۾� �������� ����
            {
                MessageBox.Show("�۾��� �̹� ���� ���Դϴ�.", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            LblState.Text = "���� : ������ ����";
            BtnThread3.Enabled = true;
            BtnThread2.Enabled = false;

            // CancellationToken �ʱ�ȭ
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;

            ProProgressBack.Minimum = 0;
            ProProgressBack.Maximum = 100;
            ProProgressBack.Value = 0;

            TxtResultThread.Clear();

            backgroundWorker1.RunWorkerAsync(); //��׶��� �۾� ����
        }


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            long MaxVal = 200;
            long total = 0;

            for (int i = 0; i < MaxVal; i++)
            {
                if (_cancellationToken.IsCancellationRequested) // ��� ��û�� ������
                {
                    e.Cancel = true;  // �۾��� ���
                    return;
                }

                total += i % 3;

                int progress = (int)((i * 100) / MaxVal);
                //�����Ȳ�� ProgressChanged �̺�Ʈ������ ����
                backgroundWorker1.ReportProgress(progress, i);
                Thread.Sleep(50);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;  //int���� progress
            int currVal = (int)e.UserState;         //object���� i

            ProProgressBack.Value = progress;

            TxtResultThread.AppendText(currVal.ToString() + "\r\n");
            TxtResultThread.SelectionStart = TxtResultThread.Text.Length;
            TxtResultThread.ScrollToCaret();

            LblState.Text = $"������� : {progress}";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                LblState.Text = "���� : �����尡 ��ҵǾ����ϴ�.";
            }
            else
            {
                LblState.Text = "���� : ������ ����";
            }

            BtnThread3.Enabled = false; // �ߴ� ��ư ��Ȱ��ȭ
            BtnThread2.Enabled = true;  // ���� ��ư Ȱ��ȭ


        }

        //-----------------------������, ��׶��� ��Ŀ   with backgroundWorker1  3. ���� ��ư     ------------------------
        private void BtnThread3_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                // ������ �۾� ���� �� ���� ��ư�� Ŭ���ϸ� �����带 ��� �����մϴ�.
                LblState.Text = "���� : ������ �ߴ�";

                // �۾� ��� ��û
                _cancellationTokenSource.Cancel(); // �۾� ���
            }

        }


        //-----------------------Ʈ����,����Ʈ�� ��Ʈ�� with imageList1    1. Ʈ���� (��Ʈ�߰�, ����߰�)------------------------
        // imageList1�� Ʈ����� ����Ʈ�信 ���������� ��Ÿ�� �� ���� �������� ���� ��
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
                MessageBox.Show("��带 �����ϼ���!", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand();  //Ʈ��Ȯ�� Expand, Ʈ����� Collapse
            TreeToList();
        }

        //-----------------------Ʈ����,����Ʈ�� ��Ʈ�� with imageList1     2. ����Ʈ��------------------------
        private void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)  // Ʈ������ �ֻ���(��Ʈ) ������ ��ȸ
            {
                TreeToList(node);   // ������ ��Ʈ ��忡 ���� ��� ȣ��
            }
        }

        //Ʈ����(TreeView)�� ��带 ListView�� �ؽ�Ʈ + ���� ���� + ������ ���·� �ű�� ��� �Լ�����.
        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() });

            //�� ���� ListViewItem�� �������� �����մϴ�.
            //ImageIndex = 0�� ListView�� ����� �̹��� ����Ʈ(ImageList)���� ù ��° �̹����� ����Ѵٴ� ���Դϴ�.
            //FrmMain.cs[������]���� ListView�Ӽ��� ���� ������, imageList1���� �����ص���
            item.ImageIndex = 0;

            //���� �������� ����Ʈ��(LsvDummy)�� �߰��մϴ�.
            LsvDummy.Items.Add(item);

            //���� ����� �ڽ� ������ �ϳ��� ��ȸ�ϸ鼭 ��� ȣ���մϴ�.
            foreach (TreeNode subNode in node.Nodes)  // Ʈ������ �ֻ���(��Ʈ) ������ ��ȸ
            {
                TreeToList(subNode);   // ������ ��Ʈ ��忡 ���� ��� ȣ��
            }
        }

        //-----------------------picture box ��Ʈ�ѷ�  with DlgOpenImage ------------------------

        private void BtnImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "�̹��� ����";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        //-----------------------��Ÿ��Ʈ��   1. monthCalendar    ------------------------
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(monthCalendar1.SelectionStart.ToString());
            TxtYear.Text = monthCalendar1.SelectionStart.Year.ToString() + "��";
            TxtMonth.Text = monthCalendar1.SelectionStart.Month.ToString() + "��";
            TxtDay.Text = monthCalendar1.SelectionStart.Day.ToString() + "��";

        }

        //-----------------------��Ÿ��Ʈ��  2. dateTimePicker  ------------------------
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //-----------------------��Ÿ��Ʈ��  3.  linkLabel ------------------------
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.naver.com",
                UseShellExecute = true
            });

        }

        //-----------------------�޴��� ��Ʈ�� MenuStrip 1. &F�� �޴����̸� ���� ------------------------
        //-----------------------�޴��� ��Ʈ�� MenuStrip 2. �޴���-����-���ῡ�� ���Ḧ ������ �޽����� �߰� �� �����ϴ� ��� ------------------------
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; //�Ʒ��� ��Ŭ��¡ �̺�Ʈ�� ���������ν� �޴��� ����޽������� ���� ������ �� �ٷ� �� �����
                //���α׷� ���� ����
                Application.Exit();
            }
        }

        //-----------------------�� ���� ��Ʈ�� ------------------------
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //���Ḧ �� ��Ŵ
                e.Cancel = true;
            }
        }


        //-----------------------��Ÿ��Ʈ�� with openFileDialog1          4. ���� �ε� ------------------------
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF���� (*.rtf)|*.rtf|�������� (*.docx)|*.docx";
            openFileDialog1.Title = "RTF���� �б�";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }

        }
        //-----------------------��Ÿ��Ʈ��   with saveFileDialog1         4. ���� ���� ------------------------
        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF���� (*.rtf)|*.rtf|�������� (*.docx)|*.docx";
            saveFileDialog1.Title = "�������� ����";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }

        }
        //-----------------------��Ÿ��Ʈ��  with colorDialog1       4. ���� ���ڻ� ����(����) ------------------------
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
