﻿using System;
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
    /// Логика взаимодействия для Page30.xaml
    /// </summary>
    public partial class Page30 : Page
    {
        public Page30()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("pages/Page31.xaml", UriKind.Relative));
        }
    }
}
