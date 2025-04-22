using Microsoft.VisualBasic.Devices;
using SyntaxWinApp03.Properties;
using System.Diagnostics;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Computer myCom = new Computer();
            //NoteBook myNotebook = new NoteBook();
            //Server myServer = new Server();
            //Computer myNotebook = new NoteBook();

            switch (CboDivision.SelectedIndex)
            {
                case 0:   // Computer
                    Computer myComputer = new Computer();
                    PicComputer.Image = Resources.computer_case;
                    //myComputer.HasFingerScanDevice();   //�θ�� �ڽ��Լ� �� �� ����.
                    myComputer.Boot();
                    myComputer.ShutDown();
                    myComputer.Reset();
                    break;
                case 1: // NoteBook
                    NoteBook myNoteBook = new NoteBook();
                    PicComputer.Image = Resources.laptop;
                    myNoteBook.ShutDown(); //�ڽ��� �θ��Լ� �� �� �ִ�.
                    myNoteBook.Reset();

                    //-----------����ȯ
                    //�θ�Ŭ������ �ڽ�Ŭ������ ����ȯ�ϸ鼭 ���� �߻� 
                    //NoteBook myNoteBook2 =(NoteBook) new Computer();
                    //Computer myComputer2 = new NoteBook();
                    //if (myComputer2 is NoteBook)
                    //{
                    //    Debug.WriteLine("myComputer2�� NoteBook�Դϴ�");
                    //    NoteBook myNoteBook2 = myComputer2 as NoteBook;
                    //    Debug.WriteLine("myComputer2�� myNoteBook2�� ����");

                    //}

                    bool hasFinger = myNoteBook.HasFingerScanDevice();
                    Debug.WriteLine($"���������νĿ���:{hasFinger}");

                    //HasFingerScanDevice ��ȯ��
                    hasFinger = myNoteBook.HasFingerScanDevice(true);
                    Debug.WriteLine($"���������νĿ���:{hasFinger}");
                    break;
                case 2: //Server
                    Server myServer = new Server();
                    PicComputer.Image = Resources.server;
                    break;

                default:
                    break;

            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP����";
            
            //��������
            Server server2 = server1;
            server2.Name = "DELL����";

            
            Debug.WriteLine($"�����񱳰��:{server1.Equals(server2)}");
            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "������");

            //��������
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL����";
            Debug.WriteLine($"�����񱳰��:{server1.Equals(server3)}");
            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "������");
        }
    }
}
