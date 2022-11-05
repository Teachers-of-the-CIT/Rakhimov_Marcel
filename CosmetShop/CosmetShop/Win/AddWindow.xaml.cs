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
using System.Windows.Shapes;
using CosmetShop.Pages;

namespace CosmetShop.Win
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private Orders _orders;
        public OrderPage a = new OrderPage();
        public AddWindow(OrderPage orderPage, Orders ord = null)
        {
            InitializeComponent();
            InitializeComponent();
            _orders = ord;
            a = orderPage;
            if (_orders != null) //Если переданный объект не пустой, то заполняем поля для ввода значениями этого объекта
            {
                DDTB.Text = _orders.DateDelivery.ToString();
                DateOTB.Text = _orders.DateOrder.ToString();
                POITB.Text = _orders.Id_Point_Of_Issue.ToString();

                NameTB.Text = Convert.ToString(_orders.FirstNameClient);
                SecondNameTB.Text = Convert.ToString(_orders.SecondName);
                PatronymicTB.Text = Convert.ToString(_orders.Patronymic);
                StatusTB.Text = _orders.Status;
                RCTB.Text = _orders.Receipt_Сode.ToString();

                LabelOfBorder.Text = "Изменить";
                lbl.Content = "Изменение объекта";
            }
            else
            {
                LabelOfBorder.Text = "Добавить";
                lbl.Content = "Добавление объекта";
            }
        }
        /// <summary>
        /// Обработчик событий для изменения или добавления данных
        /// В зависимости он значения параметра конструктора cityObj проводится 
        /// либо изменение выбранных данных
        /// либо добавление новых.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            
            if (!String.IsNullOrEmpty(DDTB.Text) && !String.IsNullOrEmpty(DateOTB.Text) && !String.IsNullOrEmpty(POITB.Text) &&
                !String.IsNullOrEmpty(NameTB.Text) && !String.IsNullOrEmpty(SecondNameTB.Text) && !String.IsNullOrEmpty(StatusTB.Text) && !String.IsNullOrEmpty(RCTB.Text)

                )
            {
                if (_orders == null)
                {
                    using (ParfumBDEntities db = new ParfumBDEntities())
                    {
                        Orders s = new Orders()
                        {
                            FirstNameClient = NameTB.Text,
                            SecondName = SecondNameTB.Text,
                            Status = StatusTB.Text,
                            Patronymic = PatronymicTB.Text,
                            Receipt_Сode = Convert.ToInt32(RCTB.Text),
                            DateDelivery = Convert.ToDateTime(DDTB.Text),
                            DateOrder = Convert.ToDateTime(DateOTB.Text),
                            Id_Point_Of_Issue = Convert.ToInt32(POITB.Text),
                        };
                        db.Orders.Add(s);
                        db.SaveChanges();
                        a.RefreshObj();
                        this.Hide();
                        MessageBox.Show("Данные добавлены");
                    }
                }
                if (_orders != null)
                {
                    using (ParfumBDEntities db = new ParfumBDEntities())
                    {
                        var dbCityObject = db.Orders.FirstOrDefault(p => p.Id == _orders.Id);
                        dbCityObject.FirstNameClient = NameTB.Text;
                        dbCityObject.Status = StatusTB.Text;
                        dbCityObject.SecondName = SecondNameTB.Text;
                        dbCityObject.Patronymic = PatronymicTB.Text;
                        dbCityObject.DateOrder = Convert.ToDateTime(DateOTB.Text);
                        dbCityObject.DateDelivery = Convert.ToDateTime(DDTB.Text);
                        dbCityObject.Id_Point_Of_Issue = Convert.ToInt32(POITB.Text);
                        dbCityObject.Receipt_Сode = 
                        db.SaveChanges();
                        a.RefreshObj();
                        this.Hide();
                        MessageBox.Show("Данные добавлены");
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!\n Возможно, данный владелец не найден.");
            }
        }
    }
}
