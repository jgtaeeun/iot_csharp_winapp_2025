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

namespace SelfProject
{
    /// <summary>
    /// MenuPage2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuPage2 : Page
    {
        public MenuPage2()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
          
            string url = "https://www.youtube.com/shorts/q7fBbgMXqrI";
            // 기본 웹 브라우저로 URL 열기
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            string url = "https://www.youtube.com/shorts/Ubs5PVYDl2Q";
            // 기본 웹 브라우저로 URL 열기
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "https://www.youtube.com/shorts/uSggKmyw_2o";
            // 기본 웹 브라우저로 URL 열기
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Hyperlink_Click_3(object sender, RoutedEventArgs e)
        {
            string url = "https://www.youtube.com/shorts/YJhg4mCxQuI";
            // 기본 웹 브라우저로 URL 열기
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
