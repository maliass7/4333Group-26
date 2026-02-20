using System.Windows;

namespace Group4333
{
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void btn4333_Galiev_Click(object sender, RoutedEventArgs e)
        {
            new _4333_Галиев().ShowDialog();
        }
    }
}