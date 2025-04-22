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
            MessageBox.Show("병원에 왜 왔어요? 집에 가세요!!");
        }
        else if (TxtPain.Text == "네")
        {
            string PainPoint = CboPainPoint.SelectedItem.ToString();

            switch (PainPoint)
            {
                case "머리":
                    MessageBox.Show("내과" , "진료과");
                    break;
                case "눈":
                    MessageBox.Show("안과", "진료과");
                    break;
                case "목":
                case "코":
                    MessageBox.Show("이비인후과","진료과");
                    break;
                case "가슴":
                    MessageBox.Show("내과","진료과");
                    break;
                case "배":
                    MessageBox.Show("소아과","진료과");
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
       
        if (e.KeyChar == (char)Keys.Enter)
        {
            MessageBox.Show(TxtPain.Text, "통증여부");
        }

    }

    private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
    {
       
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
          
            TxtResult.Text += "\r\n";
        }
    }

    int clickNum = 0;
    private void BtnWhile_Click(object sender, EventArgs e)
    {

        if (clickNum >= 10)
        {
            MessageBox.Show("이미 10번 누르셨습니다.");
            return;
        }

        while (true)
        {
            MessageBox.Show("버튼클릭 " + clickNum);
            clickNum++;

            if (clickNum == 10) break;
        }
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {

    }
}
}
