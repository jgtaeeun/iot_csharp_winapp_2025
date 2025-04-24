using System.Diagnostics;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
           
            Debug.WriteLine("1.�������� �̺�Ʈ ����");

            //4.2  �̺�Ʈ ����
            this.SomethingHappend  += MyEventHandlerMethod;
        }

        //5. �̺�Ʈ
        private void FrmMain_Load(object sender, EventArgs e)
        {
          
            Debug.WriteLine("2.���ε� �̺�Ʈ ����");
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            
            Debug.WriteLine("4.���� �̺�Ʈ ����");

        }


        private void FrmMain_Activated(object sender, EventArgs e)
        {
           
            Debug.WriteLine("3.����Ƽ����Ʈ �̺�Ʈ ����");
        }


        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Debug.WriteLine("5.��Ŭ��¡ �̺�Ʈ ����");
        }


        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Debug.WriteLine("6.��Ŭ����� �̺�Ʈ ����");
        }

        //1-1. ��������Ʈ ����
        delegate void MyDelegate(string msg);

        //4-1	�̺�Ʈ�� ��������Ʈ ����
        public event EventHandler SomethingHappend;

        //1- 2. ��������Ʈ�� ����� �޼���
        void SayHello(string msg)
        {
            MessageBox.Show($"�ȳ�~{msg}", "��������Ʈ �ǽ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void SayGoodBye(string msg)
        {
            MessageBox.Show($"�¹���~{msg}", "��������Ʈ �ǽ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //����ȣ��
            SayHello("�츮 ������?(����ȣ��)");
            SayGoodBye("���� �θǽ���(����ȣ��)");

            //1- 3. ��������Ʈ �ν��Ͻ� ����
            MyDelegate del = SayHello;
            del += SayGoodBye;
            del -= SayHello;
            // 1-4. ��������Ʈ ȣ�� (�޼��� ȣ��ó�� ���)
            del("�̶� ���� ���ƿ�~(��������Ʈȣ��)");
            del("baby good bye~(��������Ʈȣ��)");

            //2. ��ȯ������ �븮�� - Action
            Action<string> act = SayHello;
            act("���ÿ�(Actionȣ��)");

            //3. ��ȯ�� �ִ� �븮�� - Func
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(7, 8);
            Debug.WriteLine(result);

            //4-3. �̺�Ʈ ����
            if (SomethingHappend != null)
            {
                SomethingHappend(this, new EventArgs());
            }


        }

        private void MyEventHandlerMethod(object sender, EventArgs e)
        {
            MessageBox.Show("���ο��� �̺�Ʈ ����!", "�̺�Ʈ �ڵ鷯", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
