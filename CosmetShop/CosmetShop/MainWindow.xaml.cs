using CosmetShop.Model;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CosmetShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow main = new MainWindow();
        public static Users currentuser = new Users();
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.Auth());
        }
        /// <summary>
        /// Метод для импорта фото
        /// </summary>
        public void ImportPhotos()
        {
            var images = Directory.GetFiles(@"C:\Users\JutsPC\Desktop\4438_ДЭ\Сессия\Товар_import");
            using (ParfumBDEntities db = new ParfumBDEntities())
            {
                foreach (var item in db.Product)
                {
                    try
                    {
                        item.Preview = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(item.Articul)));
                    }
                    catch
                    {
                        item.Preview = null;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
