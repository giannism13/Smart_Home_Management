using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for BathroomPage.xaml
	/// </summary>
	public partial class BathroomPage : Page {
		private readonly HomePage home;

		public BathroomPage(HomePage _home) {
			InitializeComponent();
			home = _home;
		}

		private void BackButtonAction(object sender, RoutedEventArgs e) {
			NavigationService.Navigate(home);
		}

		private void LightOn(object sender, RoutedEventArgs e) {
			Light.Foreground = new SolidColorBrush(Colors.LightGreen);
			LightRect.Visibility = Visibility.Visible;
			home.bathLight.Visibility = Visibility.Visible;
		}

		private void LightOff(object sender, RoutedEventArgs e) {
			Light.Foreground = new SolidColorBrush(Colors.Black);
			LightRect.Visibility = Visibility.Hidden;
			home.bathLight.Visibility = Visibility.Hidden;
		}

		private void WmOn(object sender, RoutedEventArgs e) {
			WashingM.Foreground = new SolidColorBrush(Colors.LightGreen);
			WmRect.Visibility = Visibility.Visible;
			home.bathWm.Visibility = Visibility.Visible;
		}

		private void WmOff(object sender, RoutedEventArgs e) {
			WashingM.Foreground = new SolidColorBrush(Colors.Black);
			WmRect.Visibility = Visibility.Hidden;
			home.bathWm.Visibility = Visibility.Hidden;
		}

		private void HelpButtonAction(object sender, RoutedEventArgs e) {
			if (HelpBox.Visibility == Visibility.Visible)
				HelpBox.Visibility = Visibility.Hidden;
			else
				HelpBox.Visibility = Visibility.Visible;
		}
	}
}
