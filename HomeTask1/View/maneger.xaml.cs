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

namespace HomeTask1.View
{
    /// <summary>
    /// Логика взаимодействия для maneger.xaml
    /// </summary>
    public partial class maneger : Window
    {
        public maneger()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void New_Order_Button_Click(object sender, RoutedEventArgs e)
        {
            NewOrder window = new NewOrder();
            window.Show(); Close();
        }
    }
}
