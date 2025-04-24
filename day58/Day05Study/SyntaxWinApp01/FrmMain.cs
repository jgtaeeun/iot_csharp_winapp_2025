using System.Diagnostics;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
           
            Debug.WriteLine("1.폼생성자 이벤트 실행");

            //4.2  이벤트 구독
            this.SomethingHappend  += MyEventHandlerMethod;
        }

        //5. 이벤트
        private void FrmMain_Load(object sender, EventArgs e)
        {
          
            Debug.WriteLine("2.폼로드 이벤트 실행");
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            
            Debug.WriteLine("4.폼숀 이벤트 실행");

        }


        private void FrmMain_Activated(object sender, EventArgs e)
        {
           
            Debug.WriteLine("3.폼액티베이트 이벤트 실행");
        }


        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Debug.WriteLine("5.폼클로징 이벤트 실행");
        }


        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Debug.WriteLine("6.폼클로즈드 이벤트 실행");
        }

        //1-1. 델리게이트 선언
        delegate void MyDelegate(string msg);

        //4-1	이벤트와 델리게이트 정의
        public event EventHandler SomethingHappend;

        //1- 2. 델리게이트를 사용할 메서드
        void SayHello(string msg)
        {
            MessageBox.Show($"안녕~{msg}", "델리게이트 실습", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void SayGoodBye(string msg)
        {
            MessageBox.Show($"굿바이~{msg}", "델리게이트 실습", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //직접호출
            SayHello("우리 만날래?(직접호출)");
            SayGoodBye("나의 로맨스여(직접호출)");

            //1- 3. 델리게이트 인스턴스 생성
            MyDelegate del = SayHello;
            del += SayGoodBye;
            del -= SayHello;
            // 1-4. 델리게이트 호출 (메서드 호출처럼 사용)
            del("이란 말은 말아요~(델리게이트호출)");
            del("baby good bye~(델리게이트호출)");

            //2. 반환값없는 대리자 - Action
            Action<string> act = SayHello;
            act("성시원(Action호출)");

            //3. 반환값 있는 대리자 - Func
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(7, 8);
            Debug.WriteLine(result);

            //4-3. 이벤트 실행
            if (SomethingHappend != null)
            {
                SomethingHappend(this, new EventArgs());
            }


        }

        private void MyEventHandlerMethod(object sender, EventArgs e)
        {
            MessageBox.Show("내부에서 이벤트 감지!", "이벤트 핸들러", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
