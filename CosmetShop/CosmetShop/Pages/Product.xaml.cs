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
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        public Product()
        {
            InitializeComponent();
            using(var db = new ParfumBDEntities())
            {
                var currentTours = db.Product.ToList();
                LViewTours.ItemsSource = currentTours;
                UpdateTours();

            }
            
        }
        /// <summary>
        /// Обновление листвью
        /// </summary>
        public void UpdateTours()
        {
            using (var db = new ParfumBDEntities())
            {
                var currentComps =
                   db.Product.ToList();

                currentComps = currentComps.Where(p => p.Name.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
                LViewTours.ItemsSource = currentComps;
            }

        }
        /// <summary>
        /// Удаление данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(MainWindow.currentuser.Role == "Администратор")
            {
                MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить выбранные данные?", "Удаление объекта", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    using (ParfumBDEntities db = new ParfumBDEntities())
                    {
                        Model.Product s = (sender as ListBoxItem).DataContext as Model.Product;
                        var comp = db.Product.FirstOrDefault(p => p.Id == s.Id);
                        db.Product.Remove(comp);
                  
                        db.SaveChanges();
                        UpdateTours();
                        MessageBox.Show("Данные удалены");
                    }
                }
            }
        }
      
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTours();
        }
    }
}
