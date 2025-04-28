using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudyApp04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<string> sungsimdangItems { get; set; }
        public Dictionary<string, string> volleyballTeams { get; set; }
        public MainWindow()
        {
            InitializeComponent();
           
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sungsimdangItems = new ObservableCollection<string>
            {
                "회오리소세지",
                "애플브리치즈 샌드위치",
                "이탈리안 샌드위치",
                "초코튀소"
            };
            //윈앱의 컨트롤.DataSource와 동일한 속성
            CboCollection.ItemsSource = sungsimdangItems;


            

            volleyballTeams = new Dictionary<string, string>() {
                { "천안" , "현대캐피탈 스카이워커스" },
                { "인천" , "흥국생명 핑크스파이더스"},
                { "수원"  ,"한국전력 빅스톰"},
                { "광주"  ,"페퍼저축은행 AI PEPPERS"}
            };

            LoadDivisionFromDataBase();   //mysql데이터 로드


            //WPF xaml의 전체의 데이터컨텍스트에 현재값을 바인딩
            this.DataContext = this;

            //this.DataContext=this;와 동일한 기능
            //대신 데이터를 전달하는 레벨은 다름
            //CboBread.DataContext = this;

          
        }

        private void LoadDivisionFromDataBase()
        {
            string connectionString = "Server=localhost;Database=madang;Uid=root;Pwd=12345;Charset=utf8;";
            string query = "SELECT publisher, bookname FROM Book";

            List<KeyValuePair<string, string>> divisions = new List<KeyValuePair<string, string>>();

            //db연결, 할당, 
            //using을 쓰면 db.close()를 using문이 대신 실행
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) 
                    { var division = reader.GetString("publisher");  //reader.GetString(0)은 지양!
                        var names = reader.GetString("bookname");
                        divisions.Add(new KeyValuePair<string, string>(division, names));
                    }
                


                }
                catch (Exception ex) 
                { 
                    MessageBox.Show($"DB연결실패!:{ex.Message}","오류",MessageBoxButton.OK, MessageBoxImage.Error);
                }
                //conn.Close();
            }


            CboDivision.ItemsSource = divisions;

        }

        private void CboVolleyballTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Debug.WriteLine(CboVolleyballTeams.SelectedItem);
            string value = ((KeyValuePair<string, string>)CboVolleyballTeams.SelectedItem).Value;
            MessageBox.Show(value, "선택한 배구팀", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}