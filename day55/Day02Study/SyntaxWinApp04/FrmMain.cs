namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtAge.Text == "" || TxtName.Text == "")
            {
                MessageBox.Show("���� ä���ּ���");
                return; //�޼��� Ż��
            }
            else {
                LblResult.Text = "ó����� :";
                TxtResult.Text = TxtName.Text + TxtAge.Text;
            }
        }
    }
}
