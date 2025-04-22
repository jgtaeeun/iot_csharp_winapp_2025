namespace SyntaxWinApp02
{
    internal class Person
    {
     

        //생성자
        public Person() { }

        // alt + enter눌러서 생성자 자동생성
        public Person(string name, int age, char gender, string phone)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Phone = phone;
        }

        //멤버 변수(정확히는 속성, Property)를 선언
        public string Name { get; set; } // getName(), setName() 자동 생성

        //그냥 값을 받고 사용할 때 : public int Age { get; set; }
        //0~20사이만 들어가도록 필터 적용
        private int age;
        public int Age {
            get { return age; }
            set 
            { 
                if( value <0 || value >20)
                {
                    age = 20;
                }
                else
                {
                    age = value;
                }
            }
        }
        
        public char Gender { get; set; }
        public string Phone { get; set; }

        //멤버 함수
        // alt + enter눌러서 재정의 생성
        public override string ToString()
        {
            return $"Peron 객체는 이름 , {Name}\r\n" +
                $"나이, {Age}세\r\n성별, {Gender}\r\n" +
                $"핸드폰, {Phone}";
        }

        public void GetUp()
        {
            MessageBox.Show($"{Name}가 아침에 일어납니다.");
        }

        public void GoToSchool()
        {
            MessageBox.Show($"{Name}가 학교에 갑니다.");
        }

        //static은 컴파일 후 실행되면 메모리에 자리잡음
        //객체를 생성하지 않고 바로 쓸 수 있음
        public static int GetNumber()
        {
            return 20;
        }
    }



}
