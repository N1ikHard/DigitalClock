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

namespace DigitalClock
{
    /// <summary>
    /// Логика взаимодействия для Digit.xaml
    /// </summary>
    public partial class Digit : UserControl
    {
        public Digit()
        {
            InitializeComponent();
        }
        public Digit(int num) : this()
        {
            SetDigit(num);
        }
        public void SetDigit(int num)
        {
            SetOff();
            switch (num) 
            {
                case 0:
                    SetOn(A);
                    SetOn(B);
                    SetOn(C);
                    SetOn(D);
                    SetOn(E);
                    SetOn(F);
                    break;
                case 1:
                    SetOn(A);
                    SetOn(B);
                    break;
                case 8:
                    SetOn(A);
                    SetOn(B);
                    SetOn(C);
                    SetOn(D);
                    SetOn(E);
                    SetOn(F);
                    SetOn(G);
                    break;
                case 2:
                    SetOn(A);
                 
                    SetOn(C);
                    SetOn(D);
                    SetOn(F);
                    SetOn(G);
                    break;
                case 3:
                    SetOn(A);
                    SetOn(B);
                    SetOn(C);
                    SetOn(G);
                    SetOn(F);
                    break;
                case 4:
                    SetOn(A);
                    SetOn(B);
                    SetOn(E);
                    SetOn(G);
                    break;
                case 5:
                    SetOn(B);
                    SetOn(C);
                    SetOn(G);
                    SetOn(E);
                    SetOn(F);
                    break;
                case 6:
                    SetOn(B);
                    SetOn(C);
                    SetOn(D);
                    SetOn(E);
                    SetOn(G);
                    SetOn(F);
                    break;
                case 7:
                    SetOn(A);
                    SetOn(B);
                    SetOn(F);
                    break;
                case 9:
                    SetOn(A);
                    SetOn(B);
                    SetOn(E);
                    SetOn(F);
                    break;

            }
        }
        private void SetOff()
        {
            A.Fill = new SolidColorBrush(Colors.Transparent);
            B.Fill = new SolidColorBrush(Colors.Transparent);
            C.Fill = new SolidColorBrush(Colors.Transparent);
            D.Fill = new SolidColorBrush(Colors.Transparent);
            E.Fill = new SolidColorBrush(Colors.Transparent);
            F.Fill = new SolidColorBrush(Colors.Transparent);
            G.Fill = new SolidColorBrush(Colors.Transparent);
        }
        private void SetOn(Path A)
        {
            Brush brush = new SolidColorBrush(Colors.Red);
            A.Fill = brush;
        }
    }
}
