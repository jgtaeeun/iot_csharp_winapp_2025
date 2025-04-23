namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private string filePath = "sample.rtf";   //Rich Text Format (MS Word�� ����)

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //����������
            //C:\Source\iot_csharp_winapp_2025\day57\Day04Study\SyntaxWinApp03\bin\Debug\net8.0-windows
            //string filePath = "sample.txt";
            try
            {
                //File : ���� ���� �޼��尡 ����ִ� Ŭ����
                //1. TXT���� ����
                //File.WriteAllText(filePath, RtbResult.Text);

                //2.Rich Text Format  ���� ����
                RtbResult.SaveFile(filePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("������ ����Ǿ����ϴ�.", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� : {ex.Message}", "��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //3. OpenFileDialog ���
            // doc, docx�� ���� �ε� �Ұ�
            DlgOpen.Filter = "RTF���� (*.rtf)|*.rtf|�������� (*.docx)|*.docx";
            DlgOpen.Title = "RTF���� �б�";

            //���̾�α�â ����(DialogResult.OK),���(DialogResult.Cancel)
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    RtbResult.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"�б���� : {ex.Message}", "�����б�", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            
            //string filePath = "sample.txt"; //�о�� ���ϸ�
            //try
            //{
            //    if (File.Exists(filePath))
            //    {
            //        //1.TXT���� �ε�
            //        //string content = File.ReadAllText(filePath);
            //        // RtbResult.Text = content;

            //        //2. Rich Text Format  ���� �ε�
            //        RtbResult.LoadFile(filePath, RichTextBoxStreamType.RichText);
            //    }
            //    else
            //    {
            //        //sample.txt ������ �ش� ��ο� �������� ���� ��
            //        //�ش� ��ġ�� ������ ���ų� �̸��� Ʋ���� ��
            //        MessageBox.Show($"������ �������� �ʽ��ϴ�.", "�����б�", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    //������ �����ϱ� ������ ���� �б� �� ���ܰ� �߻����� ��
            //    MessageBox.Show($"�б���� : {ex.Message}", "�����б�", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            RtbResult.SelectionColor = Color.Red;
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font currFont = RtbResult.SelectionFont;
            FontStyle newStyle;

            if (currFont.Bold)
            {
                newStyle = currFont.Style & ~FontStyle.Bold;  // Bold ����
            }
            else 
            {
                newStyle = currFont.Style | FontStyle.Bold;   //Bold �߰�
            }
            RtbResult.SelectionFont = new Font(currFont, newStyle);
        }
    }
}
