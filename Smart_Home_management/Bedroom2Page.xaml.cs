using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for Bedroom2Page.xaml
	/// </summary>
	public partial class Bedroom2Page : Page {
		private readonly HomePage home;

		public Bedroom2Page(HomePage _home) {
			InitializeComponent();
			home = _home;
		}

		private void BackButtonAction(object sender, RoutedEventArgs e) {
			NavigationService.Navigate(home);
		}

		private void LightOn(object sender, RoutedEventArgs e) {
			Light.Foreground = new SolidColorBrush(Colors.LightGreen);
			LightRect.Visibility = Visibility.Visible;
		}

		private void LightOff(object sender, RoutedEventArgs e) {
			Light.Foreground = new SolidColorBrush(Colors.Black);
			LightRect.Visibility = Visibility.Hidden;
		}

		private void TVon(object sender, RoutedEventArgs e) {
			TV.Foreground = new SolidColorBrush(Colors.LightGreen);
			TvRect.Visibility = Visibility.Visible;
		}

		private void TVoff(object sender, RoutedEventArgs e) {
			TV.Foreground = new SolidColorBrush(Colors.Black);
			TvRect.Visibility = Visibility.Hidden;
		}

		private void HelpButtonAction(object sender, RoutedEventArgs e) {
			if (HelpBox.Visibility == Visibility.Visible)
				HelpBox.Visibility = Visibility.Hidden;
			else
				HelpBox.Visibility = Visibility.Visible;
		}
	}
}