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




namespace ModernUserInterface
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
        //Метод для перетаскивания приложения по рабочему столу с помощью мыши
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }   
        }
        private void websiteButton_click(object sender, EventArgs e)
        {
            
        }
 
        //Полное закрытие приложения
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void websiteButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
     //Метод на случай отсутствия подключения к интернету, либо других ошибок при навигации
        private void Application_NavigationFailed(object sender,
       System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            if (e.Exception is System.Net.WebException)
            {
                MessageBox.Show("Сайт " + e.Uri.ToString() + " не доступен :(");
                // Нейтрализовать ошибку, чтобы приложение продолжило свою работу
                e.Handled = true;
            }
        }
    //Метод перехода на другую страницу внутри приложения
        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page1();
            
        }
    }
}
