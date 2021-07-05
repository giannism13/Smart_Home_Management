using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for Kitchen.xaml
	/// </summary>

	public partial class Kitchen : Page {
        private readonly HomePage home;

        public Kitchen(HomePage _home) {
            InitializeComponent();
            home = _home;
        }

        //refrigerator
        private void refrigeratorOn(object sender, RoutedEventArgs e) {
            refrigerator.Foreground = new SolidColorBrush(Colors.LightGreen);
            refrigeratorRect.Visibility = Visibility.Visible;
        }

        private void refrigeratorOff(object sender, RoutedEventArgs e) {
            refrigerator.Foreground = new SolidColorBrush(Colors.Black);
            refrigeratorRect.Visibility = Visibility.Hidden;
        }

        //coffee maker
        private void coffee_makerOn(object sender, RoutedEventArgs e) {
            coffeeMaker.Foreground = new SolidColorBrush(Colors.LightGreen);
            coffeMakerRect.Visibility = Visibility.Visible;
        }

        private void coffee_makerOff(object sender, RoutedEventArgs e) {
            coffeeMaker.Foreground = new SolidColorBrush(Colors.Black);
            coffeMakerRect.Visibility = Visibility.Hidden;
        }

        //light bulb
        private void LightOn(object sender, RoutedEventArgs e) {
            Light.Foreground = new SolidColorBrush(Colors.LightGreen);
            LightRect.Visibility = Visibility.Visible;
        }

        private void LightOff(object sender, RoutedEventArgs e) {
            Light.Foreground = new SolidColorBrush(Colors.Black);
            LightRect.Visibility = Visibility.Hidden;
        }

        //oven
        private void ovenOn(object sender, RoutedEventArgs e) {
            Oven.Foreground = new SolidColorBrush(Colors.LightGreen);
            ovenRect.Visibility = Visibility.Visible;
        }

        private void ovenOff(object sender, RoutedEventArgs e) {
            Oven.Foreground = new SolidColorBrush(Colors.Black);
            ovenRect.Visibility = Visibility.Hidden;
        }

        //ArrowBack
        private void BackButtonAction(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(home);
        }

        //helpButton
        private void HelpButtonAction(object sender, RoutedEventArgs e) {
            if (HelpBox.Visibility == Visibility.Visible)
                HelpBox.Visibility = Visibility.Hidden;
            else
                HelpBox.Visibility = Visibility.Visible;
        }
    }
}