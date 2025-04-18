# iot_csharp_winapp_2025
C# /윈도우 애플리케이션

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
    ```c#
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
### C# 문법
