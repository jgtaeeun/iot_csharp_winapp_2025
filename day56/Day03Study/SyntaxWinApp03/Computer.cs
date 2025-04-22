using System;
using System.Collections.Generic;
using System.Diagnostics;   //진단네임스페이스 Debug클래스 포함
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp03
{
    internal class Computer
    {
        public Computer() {

            Debug.WriteLine("[디버그]Computer 객체 생성됨");
            //Console.WriteLine("Computer 객체 생성됨");
        }

        bool powerOn;

        public void Boot() 
        {
            Debug.WriteLine("컴퓨터 부팅!");
        }
        public virtual void ShutDown() {
            Debug.WriteLine("컴퓨터 ShutDown!");
        }
        public void Reset() { }

       
    }

    internal class NoteBook : Computer {

        public NoteBook()
        {
            Debug.WriteLine("[디버그]NoteBook 객체 생성됨");
            base.Boot();
        }

        bool fingerScan;

        public bool HasFingerScanDevice()
        {
            return fingerScan;
        }

        //오버로딩
        public bool HasFingerScanDevice(bool fingerScan)
        {

            this.fingerScan = fingerScan;
            return this.fingerScan;
        }

        //부모 클래스 ShutDown()을 자식에서 다시 재정의
        public override void ShutDown() {
            Debug.WriteLine("노트북 ShutDown!");
        }
    }

    internal class Server : Computer , IMoblie {

        public Server() { Debug.WriteLine("[디버그]Server 객체 생성됨");  }

        bool storage;
        public string Name { get; set; }

        public bool HasStorage()
        {
            return storage;
        }

        public void Call()
        {
            Debug.WriteLine("Server클래스가 인터페이스 IMoblie 상속받아 Call()오버라이딩");
        }

        public string GetList()
        {
            return $"Server클래스가 인터페이스 IMoblie 상속받아 GetList()오버라이딩";
        }

        public Server DeepCopy()
        {
            Server tmp = new Server();
            tmp.Name = this.Name;
            tmp.storage = this.storage; // 누락됐던 부분 추가
            return tmp;
        }
    }
}
