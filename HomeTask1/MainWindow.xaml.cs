using HomeTask1.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeTask1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string Login = "login1";
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (LoginBox.Text == Login && PasswordBox.Password == "tuptup")
                {
                    maneger window = new maneger();
                    window.Show();
                }
                else throw new Exception("Пользователя не существует ");

            }
            catch(Exception ex)
            {
                MessageBox.Show("неправильный логин или пароль", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            
            Close();
        }
    }
}
