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
using System.Windows.Shapes;

namespace PetShop
{
    /// <summary>
    /// Interaction logic for Home_Page.xaml
    /// </summary>
    public partial class Home_Page : Window
    {
        public Home_Page()
        {
            InitializeComponent();
            lbGetDate.Content= DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logging out...");
            MainWindow LoginPage = new MainWindow();
            LoginPage.Show();
            this.Close();
        }

        private void btPet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btOwner_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
