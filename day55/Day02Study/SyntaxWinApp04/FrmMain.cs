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
                MessageBox.Show("값을 채워주세요");
                return; //메서드 탈출
            }
            else {
                LblResult.Text = "처리결과 :";
                TxtResult.Text = TxtName.Text + TxtAge.Text;
            }
        }
    }
}
