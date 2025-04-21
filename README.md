# iot_csharp_winapp_2025
C# /윈도우 애플리케이션

|실행|키|
|:--:|:--:|
|코드보기|F7|
|디자이너보기|SHIFT + F7|
|파일1개 저장|CTRL + S|
|파일전체 저장|CTRL + SHIFT + S|
|복사|CTRL + C+ V |
|그룹복사|2개이상의 컨트롤 + CTRL + 드래그|
## 54일차 (4/18)

### C# 시작전에
- repository만들기
    - gitignore을 visualstudio로
    - <img src = './day54/repository만들기.png' width =500>
- visual studio installer 확인
    - `ASP.NET 및 웹 개발, .NET 데스크톱 개발은 필수!`
    - python 개발, Node.js개발도 추가!
    - .NET Multi-Platform App UI 개발은 옵션!
    - <img src = './day54/visual studio installer.png' width =500>

### C# 학습
#### C#이란?
- C#  : **마이크로소프트**가 개발한 객체지향 프로그래밍 언어
    - 1991년, 귀도 반 로섬이 Python 개발
    - 1985년, 비야네 스트롭스트룹이 C++을 개발(너무 어려움, 1980년 초반 개발시작)
    - 1995년, 제임스 고슬링이 Java를 개발(C++의 문법을 기반, 좀 더 쉬운 언어, 1991년 개발 시작)
    - MS가 썬 마이크로시스템즈와 라이센스 채결 후 MS용 Java인 J++개발. 특허권 소송 발생
    - 1999년, 파스칼, 델파이를 개발한 `엔더스 헤일스버그`가 C++,Java를 기반으로 C#개발
    - 2000년, C# 발표

- C# 특징
    - 닷넷 플랫폼 위에서 동작(Managed C++ , C#, Java, Python, ...)
    - 문법이 Java와 상당히 유사
    - Java와 달리 unsafe mode를 사용하면 C/C++포인트 기능을 사용 가능
    - 런타임 시 **쓰레기 수집(Garbage Collection)**으로 자동으로 메모리 관리
- C# 유머
    - 1999년 앤더스 헤일스버그가 최초 Cool(C-like Object Oriented Language)로 이름을 생성
    - C#의 의미는 C++보다 개선된 언어의 의미로 C++++ , 또는 음악에서 #이 원래 음보다 반음 높음을 뜻

- C# 버전
    - C# 1.x - 2002~2003년, .NET Framework 1.x ,  문제많음
    - C# 2.x - 2006년, .NET Framework 2.x , 개선이 많이 됨
    - C# 3.x - 2007년, .NET Framework 2.x ~3.5, Java와 차이가 많아짐
    - C# 4.x - 2010년, .NET Framework 4.x, C#의 기반 
    - ...
    - C# 6.x - 2015년, .NET Framework 4.6 , .NET Core 1.x (리눅스) 
    - C# 7.x - 2017~2018년, .NET Framework 4.7 , .NET Core 2.x
    - ...
    - C# 9.0 - 2020년 , **.NET 5.0(Framework와 Core 통합)**
    - C# 10.0 - 2021년, .NET 6
    - C# 11.0 - 2022년, .NET 7
    - C# 12.x - 2023년 , .NET 8
    - C# 13.x - 2024년 11월 , .NET 9(visual studio 2022에서 동작)

- 호환성, 범용성
    - 초기 Window OS에서만 동작, OS플랫폼 독립적인 Java보다 범용성이 낮았음
    - 2016년부터 리눅스 공식지원. macOS에서도 사용 가능. 오픈소스 공표
    - 유니티 엔진 기본언어, Xamarin(이후 MAUI로 변경)로 모바일 개발 가능
    - 리눅스 Mono라는 닷넷 개발 프로젝트 -> 후에 MS에 흡수됨

#### .NET Framework(.NET)
- CLR(Common Langauage Runtime) 클래스를 사용하는 가상 머신
- Java와 JVM과 유사한 개념
- 언어가 발전하면서 필요한 기능이 늘기 때문에 .NET Framework도 버전업을 계속함
- 2015년 리눅스 지원 개발시부터 .NET Framework가 너무 윈도우 구조에 토착되다보니 새로운 프레임워크가 필요함
- .NET Core - 리눅스 지원용 만든 .NET[Framework]
- .NET Core와 .NET Framework가 혼용
- 2020년 .NET Core와 .NET Framework를 통합해서 .NET 5.0 공표 . 이 이후부터 Framework, Core 이름 사라짐
- C# 버전과 .NET 버전 숫자 차이가 나기 시작

- .NET 데스크톱 개발을 설치하면 C# , Visual Basic, F# 등 여러언어를 사용가능
- **C# 12.0 , .NET 8 , Visual Studio 2022 Community Edition에서 학습**

#### 첫번째 실행파일 실습 [c#](./day54/FirstCsharpApp/Program.cs)
1. 새 프로젝트 만들기 - c# 모든 플랫폼 콘솔 - 콘솔앱 - 프로젝트이름 및 위치 - 프레임워크 .NET 8.0  및 최상위 문 사용 안 함 체크 
2. 확장자가 .cs인 파일
    ```cs
    namespace FirstCsharpApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
    ```
    - <img src='./day54/기본디폴트 파일명.png' width = 500>
    - <img src='./day54/기본코드 해석.png' width = 500>
    - <img src='./day54/using system namespace.png' width = 500>
3. 주의할점
    - <img src ='./day54/클래스명,파일명첫글자는대문자그리고시작객체설정.png' width = 500>
4. Java와 C# 비교
    - <img src='./day54/기본코드.png' width = 500>
    - <img src='./day54/기본코드2.png' width = 500>

## 55일차 (4/21)
- WinApp으로 문법 학습. 문법 학습 후 WPF로 이전
### 새 프로젝트(콘솔) 만들기
1. 선택
    - 언어 : c# 
    - 플랫폼 : 모든 플랫폼
    - 프로젝트 :  콘솔/데스크톱/웹 중 콘솔
2. 새프로젝트 구성
    - 콘솔앱
    - 프로젝트 이름 및 위치, 솔루션 이름
    - 솔루션 및 프로젝트를 같은 디렉토리에 배치 체크박스`해제` : 솔루션 내에 여러 프로젝트를 관리
3. 추가정보
    - 프레임워크 :.NET 8.0 (장기지원) 선택
    - 최상위 문 사용 안 함 `체크`


### 새 프로젝트(데스크톱,WinApp) 만들기
- 아직 멀티플랫폼은 지원 안됨(Windows만 지원)
- Windows Forms앱(문법학습 시에만 사용할 예정) - 가장 오래된 WinApp개발
- WPF (실습할 때 사용할 예정)- 좀 더 디자인적으로 뛰어난 WinApp개발
1. 선택
    - 언어 : c# 
    - 플랫폼 : 모든 플랫폼
    - 프로젝트 : 데스크톱
2. 새프로젝트 구성
    - Windows Forms앱
    - 프로젝트 이름 및 위치, 솔루션 이름
    - 솔루션 및 프로젝트를 같은 디렉토리에 배치 체크박스`해제` : 솔루션 내에 여러 프로젝트를 관리
3. 추가정보
    - 프레임워크 :.NET 8.0  (장기지원) 선택
    - 최상위 문 사용 안 함 `체크`

- 프로젝트 구조
    - 종속성:필요모듈 추가/관리/삭제
    - Form1. cs : 윈폼 앱 개발 로직
    - Form1.Designer.cs : 실제 디자인 요소
    - Form1.resx : 아이콘, 이미지, 리소스문자열 관리 파일
    - Program.cs : 시작 프로그램 소스

### 솔루션 관리
- 하나의 솔루션에 여러개 프로젝트가 있으면 시작프로젝트가 선별되어야 함
- 굵은 글씨체로 나오는 프로젝트가 시작 프로젝트

1. 프로젝트 오른쪽 마우스-시작프로젝트로 설정
2. 솔루션 오른쪽 마우스- 시작프로젝트구성- 한개의 시작프로젝트 - 시작프로젝트 고르기
    - <img src='./day55/시작프로젝트설정.png' width=500>

- 전체솔루션 : *.sln
    - C# 프로젝트 파일 : *.csproj
    - C++ 프로젝트 파일 : *.vcxproj
- debug/release 모드
    - debug - 개발시 사용 모드, 디버깅 로그, 디버깅을 위주
    - release - 배포시 사용 모드, 프로그램 최적화, 성능 업

### WinForm 앱 개발 순서
1. Form1.cs 이름 변경 (F2): FrmMain.cs
    - 변경시 모든 참조 이름도 바꾸시겠습니까? 메시지창
    - 반드시 예 선택
2. FrmMain.cs [디자인] 
    - 마우스로 크기조정
3. 속성 창 (F4) , 솔루션 탐색기 아래쪽으로 드래그 후 붙이기
4. PyQt Designer와 거의 유사
    - FrmMain 속성 창 > Text 
    - size속성 > Width, Height
    - StartPosition > CenterScreen으로 변경
    - MaximizeBoxe > False      # 최대화 버튼 비활성화
    - FormBorderStyle >FixedSingle로 변경  # 사용자가 창 크기를 조절 못 하게 만들고  얇은 단일 실선 테두리만 남겨
5. 보기 >도구상자
    - 공용컨트롤 > button 드래그
6. 속성 창 - 드롭다운 컨트롤 > 여러 클래스 리스트
7. button1 속성 변경
    - (Name) -> button1 을 BtnMsg로 변경
    - size조정
    - text > button1 을 메시지로 변경

8. 중간마다 ctrl +S 눌러서 저장 습관
9. 이벤트방법(1) 속성 창의 이벤트아이콘(번개표시) 클릭
    - click에 선택되어 있음
    - 버튼의 경우, 버튼클릭이 기본 이벤트
    - click 오른쪽 빈공간을 더블 클릭
    - 버튼을 클릭했을 시 처리할 이벤트 메서드가 자동 생성

10. 이벤트방법(2) 새로 만든 컨트롤을 더블클릭
    - 이벤트 메서드가 자동생성
    - 최초에 아무런 이벤트가 없을 때 기본 이벤트 메서드 생성
11. 오류 발생 시
    - 폼 디자인의 컨트롤 이벤트와 로직 코드 상의 이벤트 처리 메서드 생성 상 불일치
    - 이벤트 이름은 생성되고, 이벤트 정의 메서드는 생성이 안되어서
    <img src='./day55/디자인 오류.png'>
    - FrmMain.Designer.cs파일 오픈 후 오류난 이벤트 이름 삭제
12. MessageBox.show() 작업
    - MessageBoxIcon.Warning
    - MessageBoxIcon.Error 사용시 알람 사운드 발생
    ```cs
          // 메시지 박스에 표시될 내용,메시지 박스의 제목,MessageBoxButtons.OK는 메시지 박스에 표시될 버튼 종류,메시지 박스에 표시될 아이콘
      MessageBox.Show("첫번째메시지" , "알림", MessageBoxButtons.OK,MessageBoxIcon.Error);
    ```
    - `MessageBox.Show()는 string을 받아야 하니까, .ToString()을 써야 해`
    - MessageBox.show()  오버로딩
        - <img src = './day55/메시지박스오버로딩.png'>
13. **폼 디자이너 화면과 코드 상 전환**
    - **F7 코드보기**
    - **SHIFT F7 디자이너 화면 보기**

14. VS에서 더블클릭 함부로 하지 말 것!
    - 이벤트 메서드 생성, 컨트롤 자동 생성, 폼 디자인 표시 등에서만 더블클릭 사용

15. 두 개 이상의 컨트롤 선택 후 CTRL 키 누른 상태에서 드래그하면 그룹으로 복사
### 윈앱 컨트롤 [C#](./day55/Day02Study/SyntaxWinApp03/FrmMain.cs)
- Button : 마우스 클릭위한 컨트롤
    - 보통 Btn으로 시작
    - (Name) : 소스코드상에서 접근,사용
    - Enabled : 사용여부
    - location : 폼상의 위치(x,y)
    - Size : 버튼 크기 (w, h)
    - Text : 버튼 표시 글씨
    - Visible : 화면 표현 여부
    - TabIndex : 실행 후 탭으로 포커스가 가는 순서(레이블에는 포커스 안감)
    - (이벤트)Click : 버튼 클릭 이벤트 처리 메서드 연결
- Label : 화면상의 글자만 표현하는 컨트롤
    - 보통 Lbl로 시작
    - Button 컨트롤과 속성은 동일
    - Label은 이벤트 거의 사용하지 않음
- TextBox : 텍스트 입력을 위한 컨트롤
    - 보통 Txt로 시작
    - Button 컨트롤과 속성은 동일
    - Multiline : 여러줄 사용여부 .true가 되어야 높이 조절 가능
    - MaxLength : 최대 몇자까지 적을 수 있는지
    - PlaceholderText : 입력 전 입력내용 표시
    - (이벤트)TextChanged : 글자가 변경되면 발생하는 이벤트
    - (이벤트)KeyPress : 키보드 입력이 생기면 발생하는 이벤트 
- ComboBox : 여러 개 중 아이템을 선택하는 컨트롤 . 기본적으로 단일 선택만 가능합니다. 
    - 보통 Cbo로 시작
    - Button 컨트롤과 속성은 동일
    - Items(Collection) :필요한 아이템 할당
    - (이벤트)SelectedIndexChanged : 선택한 아이템 순번이 바뀔 때 발생하는 이벤트
    - (이벤트)SelectedValueChanged : 선택한 아이템 값이 바뀔 때 발생하는 이벤트
- RadioButton : 여러 개 중 하나만 선택하는 컨트롤
    - 보통 Rdo로 시작
    - Button 컨트롤과 속성은 동일
    - Checked : 체크여부
### C# 문법 
- 문법 - C++, Java와 거의 동일 . C++와의 차이점
    1. 기본구조 및 주석 [C#](./day55/Day02Study/ConsoleApp1/Program.cs)
        - 한줄 주석 //
        - 여러줄 주석 /**/
        - XML 주석 ///   - 소스코드 자동 문서 생성 시 사용하는 주석
    2. 자료형과 변수 , Nullable [C#](./day55/Day02Study/SyntaxWinApp01/FrmMain.Designer.cs)
        - 변수 사용은 C++과 유사
        - 자료형도 C++과 유사, 닷넷타입은 차이있음
        - `닷넷타입`은 여러언어에서 공통으로 사용위해서 추가된 기능
            - <img src ='./day55/닷넷타입.png'>
        - `Nullable`: 특수타입. 데이터타입 뒤에 ? 추가.
            - <img src = './day55/nullable.png'>
        - `var` 타입: 지역변수에서 타입을 동적으로 지정할 때
            - 한 번 타입이 정해지면 그 타입은 고정입니다.
            - 지역변수만 가능
            - <img src='./day55/var1.png'>
            - <img src='./day55/var2.png'>

    3. 연산자
        - C와 C++와 동일
        - C#에서 불린형은 true, false이지만 
        - 메시지박스에서 .toString()으로 출력할 때는 True, False이다.
        - <img src='./day55/연산자그리고자료형.png'>

    4. 분기문, 반복문 [C#](./day55/Day02Study/SyntaxWinApp03/FrmMain.cs)
        - if문
        - switch문
        - for문
        - while문
            - 무한반복문 윈앱 종료하는 법 : ctrl shift esc - 작업관리자 오른쪽 마우스 세부내용보기 - 프로젝트명(예-SyntaxWinApp03) 작업끝내기
        
   
## 56일차(4/22)
### C# 문법 
5. 문자열 처리 [C#](./day55/Day02Study/SyntaxWinApp04/FrmMain.cs)
6. 클래스와 객체, 메서드
7. 접근제어자
8. 상속, 다형성 , 추상크랠스, 인터페이스
9. 예외처리
10. 컬렉션
11. 파일입출력
12. 델리게이트, 이벤트
13. 람다식
14. LINQ
15. 비동기 
16. 속성
17. 제너릭