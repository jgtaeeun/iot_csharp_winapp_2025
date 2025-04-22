namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("���� ä���ּ���:");
                return;
            }
            else
            {
                LblResult.Text = "ó�����:";
                TxtResult.Text = "���� ó�� �� ����";

                string name = TxtName.Text.Trim(); //�յڿ��� ����

                //�Ľ� -> �м��ؼ� �� ��ȯ
                DateTime birthday = DateTime.Parse(TxtAge.Text.Trim());
                int age = DateTime.Now.Year - birthday.Year;
                //3�׽� �б�
                string gender = RdoFemale.Checked ? "��" : "��";

                // ������� ���ڿ� ������
                TxtResult.Text = "���� " + name + "�̰�, " + birthday.ToString("yyyy-MM-dd") + "�� �¾ " + age + "�� " + gender + "���Դϴ�.";

                //�ֽŹ�� ���ڿ� ������ $""
                TxtResult.Text = $"���� {name}�̰�, {birthday:yyyy-MM-dd}�Ͽ� �¾ {age:F2}�� {gender}���Դϴ�.";

            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
