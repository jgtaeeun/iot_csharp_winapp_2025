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

            if (TxtPain.Text == "아니오")
            {
                MessageBox.Show("병원을 왜 왔어요? 집에 가세요!");
            }
            else if (TxtPain.Text == "네")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();

                switch (PainPoint)
                {
                    case "머리":
                        MessageBox.Show("신경과로 가세요", "진료과선택");
                        break;
                    case "눈":
                        MessageBox.Show("안과로 가세요", "진료과선택");
                        break;
                    case "코":
                    case "목":
                        MessageBox.Show("이비인후과로 가세요", "진료과선택");
                        break;
                    case "가슴":
                        MessageBox.Show("내과로 가세요", "진료과선택");
                        break;
                    case "배":
                        MessageBox.Show("소아과로 가세요", "진료과선택");
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
            //키프레스에서 엔터를 입력하면
            //TxtPain - 네아니오 값만 
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "입력값");
            }

        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox 아이템 중 한 개 선택
            var selectedPoint = CboPainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "통증부위");
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
                //Windows에서는 줄바꿈 문자로 \r\n (Carriage Return + Line Feed)를 사용합니다.
                TxtResult.Text += "\r\n";
            }
        }

        int clickNum = 0;
        private void BtnWhile_Click(object sender, EventArgs e)
        {
            
            // clickNum이 11부터는 다시 무한반복되는 문제해결
            if (clickNum >= 10)
            {
                MessageBox.Show("이미 10번까지 클릭하셨습니다.");
                return;
            }

            while (true)
            {
                MessageBox.Show("계속 " + clickNum);
                clickNum++;

                if (clickNum == 10) break;
                //continue ; 도 파악할 것
                //goto;는 웬만하면 쓰지 말 것
            }
        }
    }
}
