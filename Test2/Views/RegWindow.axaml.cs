using Avalonia.Controls;
using Avalonia.Interactivity;
using Test2.ViewModels;

namespace Test2.Views
{
    public partial class RegWindow : Window
    {
        public bool IsAdmin;
        public RegWindow()
        {
            InitializeComponent();
        }
        
        private void SignIn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (CodeTextBox.Text == "0000")
            {
                IsAdmin = true;
                var win = new MainWindow(IsAdmin);
                win.DataContext = new MainWindowViewModel();
                win.Show();

            }
            else
            {
                var win = new MainWindow();
                win.DataContext = new MainWindowViewModel();
                win.Show();

            }

            this.Close();
        }
    }
}
