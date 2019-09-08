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

namespace Cennik
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

        //Обработчик на кнопке
        private void Button_Click_Save(object seder, RoutedEventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели блюдо!");
            }
            else
            {
                MessageBox.Show("Вы добавили блюдо:" + textBoxName.Text);
            }
        }
        private void Button_Click_Print(object seder, RoutedEventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели блюдо!");
            }
            else
            {
                MessageBox.Show("Вы добавили блюдо:" + textBoxName.Text);
            }
        }
    }
}
