using Avalonia.Controls;

namespace Test2.Views
{
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();

        }

        private void Back_products(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {   
            this.Close();

            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}
