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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab16Wpf
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            //doubleAnimation.From = 150;
            doubleAnimation.To = 500;
            //doubleAnimation.By = 20; при каждом нажатии увеличивается на 20
            doubleAnimation.Duration= TimeSpan.FromSeconds(2); //new Duration(TimeSpan.FromSeconds(5))
            //doubleAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(6)); // будет 6 секунд повторяться анимация. new RepeatBehavior(2) - анимация повторится 2 раза
            //doubleAnimation.AccelerationRatio = 0.5; //увеличение скорости до середины анимации
            //doubleAnimation.SpeedRatio = 0.5; //управление скоростью
            //doubleAnimation.AutoReverse =true; //анимация туда-обратно
            doubleAnimation.FillBehavior =FillBehavior.Stop; //возврат к исходному состоянию
            btn.BeginAnimation(Button.WidthProperty, doubleAnimation);
            btn.BeginAnimation(Button.HeightProperty, doubleAnimation);

            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.Red;
            colorAnimation.To = Colors.Green;
            colorAnimation.Duration = TimeSpan.FromSeconds(2);
            btn.Background=new SolidColorBrush(Colors.Red);
            btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }
    }
}
