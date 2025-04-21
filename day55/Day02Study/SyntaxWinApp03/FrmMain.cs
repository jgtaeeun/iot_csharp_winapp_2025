namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {

            if (TxtPain.Text == "�ƴϿ�")
            {
                MessageBox.Show("������ �� �Ծ��? ���� ������!");
            }
            else if (TxtPain.Text == "��")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();

                switch (PainPoint)
                {
                    case "�Ӹ�":
                        MessageBox.Show("�Ű���� ������", "���������");
                        break;
                    case "��":
                        MessageBox.Show("�Ȱ��� ������", "���������");
                        break;
                    case "��":
                    case "��":
                        MessageBox.Show("�̺����İ��� ������", "���������");
                        break;
                    case "����":
                        MessageBox.Show("������ ������", "���������");
                        break;
                    case "��":
                        MessageBox.Show("�Ҿư��� ������", "���������");
                        break;
                    default:
                        break;
                }

            }

        }

        private void TxtPain_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ű���������� ���͸� �Է��ϸ�
            //TxtPain - �׾ƴϿ� ���� 
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "�Է°�");
            }

        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox ������ �� �� �� ����
            var selectedPoint = CboPainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "��������");
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    var result = i + "x" + j + "=" + (i * j) + "\t";
                    TxtResult.Text += result;
                }
                //Windows������ �ٹٲ� ���ڷ� \r\n (Carriage Return + Line Feed)�� ����մϴ�.
                TxtResult.Text += "\r\n";
            }
        }

        int clickNum = 0;
        private void BtnWhile_Click(object sender, EventArgs e)
        {
            
            // clickNum�� 11���ʹ� �ٽ� ���ѹݺ��Ǵ� �����ذ�
            if (clickNum >= 10)
            {
                MessageBox.Show("�̹� 10������ Ŭ���ϼ̽��ϴ�.");
                return;
            }

            while (true)
            {
                MessageBox.Show("��� " + clickNum);
                clickNum++;

                if (clickNum == 10) break;
                //continue ; �� �ľ��� ��
                //goto;�� �����ϸ� ���� �� ��
            }
        }
    }
}
