using CosmetShop.Model;
using CosmetShop.Win;
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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            using (var db = new ParfumBDEntities())
            {
                ObjectsDG.ItemsSource = db.Orders.ToList();
            }
        }
        /// <summary>
        /// Обновление ListVIew
        /// </summary>
        public  void RefreshObj()
        {
            ObjectsDG.ItemsSource = null;
            ObjectsDG.Items.Clear();
            using (var db = new ParfumBDEntities())
            {
                ObjectsDG.ItemsSource = db.Orders.ToList();
            }
        }
        private void AddObject_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddWindow a = new AddWindow(this);
            a.Show();
        }

        private void BtnForEdit_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddWindow addObjectWindow = new AddWindow(this, (sender as Border).DataContext as Orders);
            addObjectWindow.Show();
        }
    }
}
