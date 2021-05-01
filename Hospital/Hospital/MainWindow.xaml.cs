﻿using System.Windows;

namespace Hospital
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Patient(object sender, RoutedEventArgs e)
        {
            var new_window = new PatientWindow();
            new_window.Show();
            this.Close();
        }

        private void Button_Click_Doctor(object sender, RoutedEventArgs e)
        {
            View.Doctor.DoctorWindow doctorWindow = new View.Doctor.DoctorWindow();
            doctorWindow.Show();
            this.Close();
        }

        private void Button_Click_Director(object sender, RoutedEventArgs e)
        {
            DirectorWindow directorWindow = new DirectorWindow();
            directorWindow.Show();
            this.Close();
        }

        private void Button_Click_Secretary(object sender, RoutedEventArgs e)
        {
            SecretaryFun secretaryFun = new SecretaryFun();
            secretaryFun.Show();
            this.Close();
        }
    }
}
