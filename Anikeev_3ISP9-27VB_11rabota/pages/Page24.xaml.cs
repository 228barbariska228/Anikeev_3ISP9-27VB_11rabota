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

namespace Anikeev_3ISP9_27VB_11rabota.pages
{
    /// <summary>
    /// Логика взаимодействия для Page24.xaml
    /// </summary>
    public partial class Page24 : Page
    {
        public Page24()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("pages/Page25.xaml", UriKind.Relative));
        }
    }
}
