namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            //������ : + ,-,*,/,&,=,^
            //C�� C++�� ����
            int val = 2 ^ 10;  //��Ʈ XOR

            // �޽��� �ڽ��� ǥ�õ� ����,�޽��� �ڽ��� ����,MessageBoxButtons.OK�� �޽��� �ڽ��� ǥ�õ� ��ư ����,�޽��� �ڽ��� ǥ�õ� ������
            //MessageBox.Show(val.ToString(), "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(((3>2)&&(10<9)).ToString(), "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
