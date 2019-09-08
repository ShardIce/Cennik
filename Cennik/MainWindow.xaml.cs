using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Cennik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> dishes;

        public MainWindow()
        {
            InitializeComponent();

            dishes = new ObservableCollection<string> { "iPhone 6S Plus", "Nexus 6P", "Galaxy S7 Edge" };
            dishesList.ItemsSource = dishes;
        }

        //Обработчик на кнопке
        private void Button_Click_Save(object seder, RoutedEventArgs e)
        {
            string dish = dishText.Text;
            // добавление нового объекта
            dishes.Add(dish);
        }

        private void Button_Click_Print(object seder, RoutedEventArgs e)
        {

        }
    }
}
