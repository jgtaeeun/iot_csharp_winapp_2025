using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SelfProject
{
    /// <summary>
    /// MenuPage1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuPage1 : Page
    {
        
        Dictionary<string, List<string>> Plays = new Dictionary<string, List<string>>()
{
         { "2025-05-07", new List<string> { "삼성 라이온즈", "한화 이글스", "대전 한화생명 볼파크" } },
        {"2025-05-09", new List<string> { "한화 이글스", "키움 히어로즈", "고척돔스카이돔" } },
        { "2025-05-10", new List<string> { "한화 이글스", "키움 히어로즈", "고척돔스카이돔" } },
        { "2025-05-11", new List<string> { "한화 이글스", "키움 히어로즈", "고척돔스카이돔" } },
        { "2025-05-13", new List<string> { "두산 베어스", "한화 이글스", "대전 한화생명 볼파크" } },
        { "2025-05-14", new List<string> { "두산 베어스", "한화 이글스", "대전 한화생명 볼파크" } },
        { "2025-05-15", new List<string> { "두산 베어스", "한화 이글스", "대전 한화생명 볼파크" } }
        };

        public MenuPage1()
        {
            InitializeComponent();

        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;

            // 선택된 날짜가 있는지 확인
            if (calendar.SelectedDate.HasValue)
            {
                DateTime selectedDate = calendar.SelectedDate.Value;  // 선택된 날짜
                string temp = selectedDate.ToString("yyyy-MM-dd");
                switch (temp)
                {
                    case "2025-05-07":
                        date.Content = temp+ " 18:30";
                        team1.Content = Plays[temp][0];
                        team2.Content = Plays[temp][1];
                        venue.Content= Plays[temp][2];
                        break;
                    case "2025-05-09":
                        date.Content = temp + " 18:30";
                        team1.Content = Plays[temp][0];
                        team2.Content = Plays[temp][1];
                        venue.Content = Plays[temp][2];
                        break;
                    case "2025-05-10":
                        date.Content = temp + " 14:00";
                        team1.Content = Plays[temp][0];
                        team2.Content = Plays[temp][1];
                        venue.Content = Plays[temp][2];
                        break;
                    case "2025-05-11":
                        date.Content = temp + " 14:00";
                        team1.Content = Plays[temp][0];
                        team2.Content = Plays[temp][1];
                        venue.Content = Plays[temp][2];
                        break;
                    case "2025-05-13":
                        date.Content = temp + " 18:30";
                        team1.Content = Plays[temp][0];
                        team2.Content = Plays[temp][1];
                        venue.Content = Plays[temp][2];
                        break;
                    case "2025-05-14":
                        date.Content = temp + " 18:30";
                        team1.Content = Plays[temp][0];
                        team2.Content = Plays[temp][1];
                        venue.Content = Plays[temp][2];
                        break;
                    case "2025-05-15":
                        date.Content = temp + " 18:30";
                        team1.Content = Plays[temp][0];
                        team2.Content = Plays[temp][1];
                        venue.Content = Plays[temp][2];
                        break;
                    default:
                        date.Content = temp;
                        team1.Content = "";
                        team2.Content = "";
                        venue.Content = "";
                        MessageBox.Show("경기정보가 업로드 중입니다.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("날짜를 선택하지 않았습니다.");
            }
        }
    }
}
