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

namespace MTKatarzyna_Karakow
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

        private void btnViewHockey_Click(object sender, RoutedEventArgs e)
        {
            HockeyWindow hockeyWindow = new HockeyWindow();
            hockeyWindow.Background = Brushes.Beige;
            hockeyWindow.ShowDialog();
        }


        private void btnViewBasketball_Click(object sender, RoutedEventArgs e)
        {
            BasketballWindow basketballWindow = new BasketballWindow();
            basketballWindow.Background = Brushes.AliceBlue;
            basketballWindow.ShowDialog();
        }

        private void btnViewBaseball_Click(object sender, RoutedEventArgs e)
        {
            BaseballWindow baseballWindow = new BaseballWindow();
            baseballWindow.Background = Brushes.LightBlue;
            baseballWindow.ShowDialog();
        }
    }
}
