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
                    //myComputer.HasFingerScanDevice();   //부모는 자식함수 쓸 수 없다.
                    myComputer.Boot();
                    myComputer.ShutDown();
                    myComputer.Reset();
                    break;
                case 1: // NoteBook
                    NoteBook myNoteBook = new NoteBook();
                    PicComputer.Image = Resources.laptop;
                    myNoteBook.ShutDown(); //자식은 부모함수 쓸 수 있다.
                    myNoteBook.Reset();

                    //-----------형변환
                    //부모클래스를 자식클래스로 형변환하면서 문제 발생 
                    //NoteBook myNoteBook2 =(NoteBook) new Computer();
                    //Computer myComputer2 = new NoteBook();
                    //if (myComputer2 is NoteBook)
                    //{
                    //    Debug.WriteLine("myComputer2는 NoteBook입니다");
                    //    NoteBook myNoteBook2 = myComputer2 as NoteBook;
                    //    Debug.WriteLine("myComputer2을 myNoteBook2로 변경");

                    //}

                    bool hasFinger = myNoteBook.HasFingerScanDevice();
                    Debug.WriteLine($"최초지문인식여부:{hasFinger}");

                    //HasFingerScanDevice 반환값
                    hasFinger = myNoteBook.HasFingerScanDevice(true);
                    Debug.WriteLine($"최종지문인식여부:{hasFinger}");
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
            server1.Name = "HP서버";
            
            //얕은복사
            Server server2 = server1;
            server2.Name = "DELL서버";

            
            Debug.WriteLine($"참조비교결과:{server1.Equals(server2)}");
            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "서버명");

            //깊은복사
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL서버";
            Debug.WriteLine($"참조비교결과:{server1.Equals(server3)}");
            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "서버명");
        }
    }
}
