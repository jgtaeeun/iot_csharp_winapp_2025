using System.Diagnostics;
using static System.Windows.Forms.LinkLabel;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TxtTest.PlaceholderText = "테스트입니다";
            TxtTest.Size = new Size(200, 23);
            TxtTest.KeyPress += TxtTest_KeyPress;
            TxtTest.Font = new Font("휴먼매직체", 10, FontStyle.Italic);
        }

        private void TxtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                MessageBox.Show("엔터를 클릭했습니다.", "키프레스",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int add(int x, int y)
        {
            return x + y;

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);
            TxtResult.Text += $"함수호출 {result}\r\n";


            //�븮��
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtResult.Text += $"람다식 대리자 호출 {add2(10, 5)}\r\n\r\n";

            // SayHello �Լ� ���� ��� 
            Action<string> SayHello = name => MessageBox.Show($"안녕~{name}", "람다식 대리자 호출",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            SayHello("성 시원");


            //LINQ 사용 이전
            List<int> resList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];

            //짝수만 , 오름차순정렬
            foreach (int x in numbers)
            {
                if (x % 2 == 0) { resList.Add(x); }
            }
            TxtResult.Text += "LINQ 사용 이전\r\n";
            TxtResult.Text += $"원본리스트> {string.Join(" ", numbers)}\r\n";

            TxtResult.Text += $"짝수리스트> {string.Join(" ", resList)}\r\n";

            resList.Sort();
            TxtResult.Text += $"정렬리스트> {string.Join(" ", resList)} \r\n\r\n";


            //기본 LINQ 방식 사용

            numbers = [14, 20, 11, 15, 19, 18, 16, 13, 12, 17];
            var resList2 = from n in numbers
                           where n % 2 == 0
                           orderby n
                           select n;
            TxtResult.Text += "기본 LINQ  방식 사용 \r\n";
            TxtResult.Text += $"원본리스트> {string.Join(" ", numbers)}\r\n";
            TxtResult.Text += $"짝수,정렬리스트> {string.Join(" ", resList2)} \r\n\r\n";


            // LINK Method Chain
            numbers = [24, 30, 21, 25, 29, 28, 26, 23, 22, 27];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtResult.Text += "LINK Method Chain 사용 \r\n";
            TxtResult.Text += $"원본리스트> {string.Join(" ", numbers)}\r\n";
            TxtResult.Text += $"짝수,정렬리스트> {string.Join(" ", resList3)} \r\n\r\n";



        }



        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            PrintGeneric<int>(100);
            PrintGeneric<float>(3.141592f);
            PrintGeneric<string>("안녕하세요");
            PrintGeneric<bool>(true);

            PrintGeneric(200);
            PrintGeneric(6.141592f);
            PrintGeneric("적당히 바람이 시원해 기분이 너무 좋아요 유후");
            PrintGeneric(false);


            Box<int> intBox = new Box<int>();
            intBox.data = 20250424;
            intBox.Show();


            Box<String> strBox = new Box<String>();
            strBox.data = "애슐리";
            strBox.Show();
        }

        public void PrintGeneric<T>(T data) { Debug.WriteLine(data); }

        //제네릭 클래스
        public class Box<T> 
        {
            public T data {  get; set; } //속성

            public void Show() 
            {
                MessageBox.Show($"Box 클래스의 속성 값: {data}" , "제네릭클래스" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



    }
}
