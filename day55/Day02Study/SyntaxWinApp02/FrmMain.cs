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
            //연산자 : + ,-,*,/,&,=,^
            //C와 C++와 동일
            int val = 2 ^ 10;  //비트 XOR

            // 메시지 박스에 표시될 내용,메시지 박스의 제목,MessageBoxButtons.OK는 메시지 박스에 표시될 버튼 종류,메시지 박스에 표시될 아이콘
            //MessageBox.Show(val.ToString(), "연산자", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(((3>2)&&(10<9)).ToString(), "연산자", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
