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
            // �޽��� �ڽ��� ǥ�õ� ����,�޽��� �ڽ��� ����,MessageBoxButtons.OK�� �޽��� �ڽ��� ǥ�õ� ��ư ����,�޽��� �ڽ��� ǥ�õ� ������
            MessageBox.Show("ù��°�޽���" , "�˸�", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //�ڷ���
            // ������ �ڷ��� (MinValue ���)
            sbyte byteVal = 127;                                 // signed byte : -128 ~ 127
            System.SByte sbtVal2 = System.SByte.MinValue;        // -128

            byte btVal = 255;                                    // byte : 0 ~ 255
            System.Byte btMin = System.Byte.MinValue;            // 0

            short stVal = 32767;                                 // short : -32,768 ~ 32,767
            System.Int16 stMin = System.Int16.MinValue;          // -32,768

            ushort ustVal = 65535;                               // unsigned short : 0 ~ 65,535
            System.UInt16 ustMin = System.UInt16.MinValue;       // 0

            int intVal = 2147483647;                             // int : -21�� ~21��
            System.Int32 intMin = System.Int32.MinValue;         // -2,147,483,648

            uint smallVal = 4294967295;                          // uint : 0 ~42��
            System.UInt32 uintMin = System.UInt32.MinValue;      // 0

            long lngVal = 9000000000000000000;    //long -92��~92��

            ulong bigVal = 18000000000000000000;                  // ulong : 0 ~ 18,446,744,073,709,551,615(1800��)
            System.UInt64 ulongMin = System.UInt64.MinValue;     // 0

            // �Ǽ��� �ڷ��� (MinValue ���)
            float fVal = 3.141592f;                              // f ���̻� �� �ٿ��� ��
            System.Single fMin = System.Single.MinValue;         // -3.402823E+38

            double dVal = 3.141592;
            System.Double dMin = System.Double.MinValue;         // -1.79769313486232E+308

            decimal dcVal = 3.141592m;                           // m �Ǵ� M ���̻� �ʿ�
            System.Decimal dcMin = System.Decimal.MinValue;      // -79,228,162,514,264,337,593,543,950,335

            // �޽��� �ڽ��� ǥ�õ� ����,�޽��� �ڽ��� ����,MessageBoxButtons.OK�� �޽��� �ڽ��� ǥ�õ� ��ư ����,�޽��� �ڽ��� ǥ�õ� ������
            MessageBox.Show(intMin.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
