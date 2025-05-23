namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // 메시지 박스에 표시될 내용,메시지 박스의 제목,MessageBoxButtons.OK는 메시지 박스에 표시될 버튼 종류,메시지 박스에 표시될 아이콘
            MessageBox.Show("첫번째메시지" , "알림", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //자료형
            // 정수형 자료형 (MinValue 사용)
            sbyte byteVal = 127;                                 // signed byte : -128 ~ 127
            System.SByte sbtVal2 = System.SByte.MinValue;        // -128

            byte btVal = 255;                                    // byte : 0 ~ 255
            System.Byte btMin = System.Byte.MinValue;            // 0

            short stVal = 32767;                                 // short : -32,768 ~ 32,767
            System.Int16 stMin = System.Int16.MinValue;          // -32,768

            ushort ustVal = 65535;                               // unsigned short : 0 ~ 65,535
            System.UInt16 ustMin = System.UInt16.MinValue;       // 0

            int intVal = 2147483647;                             // int : -21억 ~21억
            System.Int32 intMin = System.Int32.MinValue;         // -2,147,483,648

            uint smallVal = 4294967295;                          // uint : 0 ~42억
            System.UInt32 uintMin = System.UInt32.MinValue;      // 0

            long lngVal = 9000000000000000000;    //long -92경~92경

            ulong bigVal = 18000000000000000000;                  // ulong : 0 ~ 18,446,744,073,709,551,615(1800경)
            System.UInt64 ulongMin = System.UInt64.MinValue;     // 0

            // 실수형 자료형 (MinValue 사용)
            float fVal = 3.141592f;                              // f 접미사 꼭 붙여야 함
            System.Single fMin = System.Single.MinValue;         // -3.402823E+38

            double dVal = 3.141592;
            System.Double dMin = System.Double.MinValue;         // -1.79769313486232E+308

            decimal dcVal = 3.141592m;                           // m 또는 M 접미사 필요
            System.Decimal dcMin = System.Decimal.MinValue;      // -79,228,162,514,264,337,593,543,950,335

            //문자형 타입
            char ch01 = 'A';
            System.Char ch03 = 'B';
            Console.WriteLine(ch01); 

            char ch02 = '\u25b6';
            Console.WriteLine(ch02); //▶

            // \0은 end of line이다. c++의 널문자의 역할
            string str01 = "Hello\0World";   //Hello
            System.String str02 = "Hello\nWorld";
            // 불린타입
            bool boo01 = true;
            System.Boolean boo02 = false;

            //Nullable
            //int int02 = null; //기본타입(정수,실수,불린/문자열 제외)은 NULL 할당불가
            int? int03 = null; //기본타입 뒤에 ? 붙여줄 것


            //동적타입 - 컴파일되면서 해당타입으로 형결정
            //컴파일되면서 string형으로 
            var int04 = "50";

            // 메시지 박스에 표시될 내용,메시지 박스의 제목,MessageBoxButtons.OK는 메시지 박스에 표시될 버튼 종류,메시지 박스에 표시될 아이콘
            //MessageBox.Show(intMin.ToString() + ch01 + ch02, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(str01, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
