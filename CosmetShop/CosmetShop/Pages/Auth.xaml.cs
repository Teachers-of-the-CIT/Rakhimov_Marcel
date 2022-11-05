using CosmetShop.Model;
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

namespace CosmetShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registr_MouseDown(object sender, MouseButtonEventArgs e)
        {
            using (ParfumBDEntities db = new ParfumBDEntities())
            {
                var client = db.Users.FirstOrDefault(x => x.Password == PasswordPB.Password.ToString() && x.Login == LoginTB.Text);
                if (client != null && client.Role == "Клиент")
                {
                    MainWindow.currentuser = client;
                    Win.ClientWindow a = new Win.ClientWindow();
                    a.Show();
                    MainWindow.main.Hide();
                    
                }
                else if (client != null & client.Role == "Администратор")
                {
                    MainWindow.currentuser = client;
                    Win.AdminWindow a = new Win.AdminWindow();
                    a.Show();
                    MainWindow.main.Hide();
                }
                else if (client != null & client.Role == "Менеджер")
                {
                    MainWindow.currentuser = client;
                    Win.ManagerWindow a = new Win.ManagerWindow();
                    a.Show();
                    MainWindow.main.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль.");
                }
            }
        }
    }
}
