using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
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
    /// MenuPage4.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuPage4 : Page
    {
        public MenuPage4()
        {
            InitializeComponent();
            Loaded += MenuPage4_Loaded;
        }

        private async void MenuPage4_Loaded(object sender, RoutedEventArgs e) 
        {

            try
            {
                await MapView.EnsureCoreWebView2Async(null);
                MapView.Source = new Uri("https://www.google.com/maps/@36.316577,127.431205,17z");
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"WebView2 초기화 실패: {ex.Message}");
            }
           
        }
    }
}
