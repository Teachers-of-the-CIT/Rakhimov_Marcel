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

namespace CosmetShop.Win
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.OrderPage());
        }

        private void SeeOrder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new Pages.Product());
        }

        private void AddProduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new Pages.OrderPage());
        }
    }
}
