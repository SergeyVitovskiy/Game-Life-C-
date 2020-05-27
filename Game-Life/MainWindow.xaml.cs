using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
namespace Game_Life
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DispatcherTimer timer = new DispatcherTimer();//Задаем таймер
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(0.1);//Интервал таймера
            timer.Tick += timerFunc;//Присваиваем функцию          
        }

        private int increment = 0;
        private void timerFunc(object sender, EventArgs e)
        {
            increment++;

            TimerLabel.Content = increment.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();//Запускаем таймер
        }      
    }
}
//public MainWindow()
//{
//    InitializeComponent();
//    ellipse.Width = 20;
//    ellipse.Height = 20;
//    ellipse.Fill = Brushes.Black;

//    myCanvas.Children.Add(ellipse);
//}

//Ellipse ellipse = new Ellipse();
//private void Button_Click(object sender, RoutedEventArgs e)
//{
//    Canvas.SetLeft(ellipse, 50);
//    Canvas.SetTop(ellipse, 70);

//}