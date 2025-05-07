using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static System.Net.WebRequestMethods;

namespace SelfProject
{
    /// <summary>
    /// MenuPage3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuPage3 : Page
    {
        public MenuPage3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://www.hanwhaeagles.co.kr/resources/vr/index.html";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string url = "https://www.hanwhaeagles.co.kr/ticketInfo.do";
            // 기본 웹 브라우저로 URL 열기
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "https://www.hanwhaeagles.co.kr/LO/PCLO01.do?redirectUrl=/ticketInfo.do";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
