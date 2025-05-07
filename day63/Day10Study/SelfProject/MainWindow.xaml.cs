using Wpf.Ui.Controls;
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
using System.Windows.Shapes;

namespace SelfProject
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : FluentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMenu1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(
                new Uri("/MenuPage1.xaml", UriKind.RelativeOrAbsolute)
            );
        }

        private void BtnMenu2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(
              new Uri("/MenuPage2.xaml", UriKind.RelativeOrAbsolute)
          );
        }

        private void BtnMenu3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(
              new Uri("/MenuPage3.xaml", UriKind.RelativeOrAbsolute)
          );
        }

        private void BtnMenu4_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(
              new Uri("/MenuPage4.xaml", UriKind.RelativeOrAbsolute)
          );
        }
    }
}
