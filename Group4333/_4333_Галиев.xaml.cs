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
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;

namespace Group4333
{
    /// <summary>
    /// Логика взаимодействия для _4333_Галиев.xaml
    /// </summary>
    public partial class _4333_Галиев : Window
    {
        public _4333_Галиев()
        {
            InitializeComponent();
        }
        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Готов к импорту");
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Готов к экспорту");
        }
    }
}
