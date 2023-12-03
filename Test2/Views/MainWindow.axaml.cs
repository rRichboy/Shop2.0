using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;
using Test2.Models;
using Test2.ViewModels;

namespace Test2.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        public MainWindow(bool isAdmin)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            AdminPanel.IsVisible = true;
        }

        private void ButtonSpinner_Spin(object? sender, Avalonia.Controls.SpinEventArgs e)
        {
            ButtonSpinner spinner = sender as ButtonSpinner;

            int value = Convert.ToInt32(spinner.Content);

            if (e.Direction == SpinDirection.Increase)
                value++;
            else if (e.Direction == SpinDirection.Decrease && value == 0)
                return;
            else
                value--;

            spinner.Content = value;

            
        }

        private void Add_cart(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            //
        }


        private void Move_cart(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CartWindow window = new CartWindow();
            window.DataContext = viewModel;
            window.Show();

            this.Hide();
            
            
        }

        private void admpanel(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            AdminWindow window = new AdminWindow();
            window.DataContext = viewModel;
            window.Show();

            this.Hide();
        }
    }
}