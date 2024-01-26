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
    /// Логика взаимодействия для Login1.xaml
    /// </summary>
    public partial class Login1 : Page
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(parol.Password.Length >= 5) 
            {
                this.NavigationService.Navigate(new Uri("pages/Page1.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Пароль должен содержать 5 и более символов");
            }
        }
    }
}
