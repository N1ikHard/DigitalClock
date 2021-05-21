using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;
namespace DigitalClock
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Digit[] digit = new Digit[4];
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;
            timer.Start();
            for(int i = 0; i < digit.Length; i++)
            {
                 digit[i] = new Digit(8);
                digit[i].SetValue(Grid.ColumnProperty, i < 2 ? i : i + 1);
                digit[i].SetValue(Grid.RowSpanProperty, 2);
                MainGrid.Children.Add(digit[i]);
            }
        }
      

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Second % 2 == 0)
            {
                PointA.Fill = new SolidColorBrush(Colors.Transparent);
                PointB.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else
            {
                PointA.Fill = new SolidColorBrush(Colors.Red);
                PointB.Fill = new SolidColorBrush(Colors.Red);
            }
            digit[0].SetDigit(DateTime.Now.Hour / 10);
            digit[1].SetDigit(DateTime.Now.Hour % 10);
            digit[2].SetDigit(DateTime.Now.Minute / 10);
            digit[3].SetDigit(DateTime.Now.Minute%10);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
