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

namespace Smart_Home_management
{
    /// <summary>
    /// Interaction logic for LivingRoomPage.xaml
    /// </summary>
    public partial class LivingRoomPage : Page{
        private readonly HomePage home;

        public LivingRoomPage(HomePage _home)
        {
            InitializeComponent();
            home = _home;
        }

        //CeilingLight
        private void CeilingLightOn(object sender, RoutedEventArgs e)
        {
            Light.Foreground = new SolidColorBrush(Colors.LightGreen);
            LightRect.Visibility = Visibility.Visible;
        }

        private void CeilingLightOff(object sender, RoutedEventArgs e)
        {
            Light.Foreground = new SolidColorBrush(Colors.Black);
            LightRect.Visibility = Visibility.Hidden;
        }

        //ArrowBack
        private void BackButtonAction(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(home);
        }

        private void TvOn(object sender, RoutedEventArgs e)
        {
            TV.Foreground = new SolidColorBrush(Colors.LightGreen);
            TvRect.Visibility = Visibility.Visible;
        }

        private void TvOff(object sender, RoutedEventArgs e)
        {
            TV.Foreground = new SolidColorBrush(Colors.Black);
            TvRect.Visibility = Visibility.Hidden;
        }

        private void FloorLampOn(object sender, RoutedEventArgs e)
        {
            FloorLamp.Foreground = new SolidColorBrush(Colors.LightGreen);
            FloorLampRect.Visibility = Visibility.Visible;
        }

        private void FloorLampOff(object sender, RoutedEventArgs e)
        {
            FloorLamp.Foreground = new SolidColorBrush(Colors.Black);
            FloorLampRect.Visibility = Visibility.Hidden;
        }

        private void HelpButtonAction(object sender, RoutedEventArgs e)
        {
            if (HelpBox.Visibility == Visibility.Visible)
                HelpBox.Visibility = Visibility.Hidden;
            else
                HelpBox.Visibility = Visibility.Visible;
        }
    }
}