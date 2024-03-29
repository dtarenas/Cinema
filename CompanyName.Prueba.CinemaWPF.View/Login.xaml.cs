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

namespace CompanyName.Prueba.CinemaWPF.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CleanView()
        {
            this.txtUser.Clear();
            this.txtPassword.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.CleanView();
            var registerView = new Register();
            registerView.ShowDialog();
        }
    }
}
