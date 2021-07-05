using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for Bedroom1Page.xaml
	/// </summary>
	public partial class Bedroom1Page : Page {
		private readonly HomePage home;

		public Bedroom1Page(HomePage _home) {
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

		private void Bl1on(object sender, RoutedEventArgs e) {
			Bedlight1.Foreground = new SolidColorBrush(Colors.LightGreen);
			bl1ell.Visibility = Visibility.Visible;
		}

		private void Bl1off(object sender, RoutedEventArgs e) {
			Bedlight1.Foreground = new SolidColorBrush(Colors.Black);
			bl1ell.Visibility = Visibility.Hidden;
		}

		private void Bl2on(object sender, RoutedEventArgs e) {
			Bedlight2.Foreground = new SolidColorBrush(Colors.LightGreen);
			bl2ell.Visibility = Visibility.Visible;
		}

		private void Bl2off(object sender, RoutedEventArgs e) {
			Bedlight2.Foreground = new SolidColorBrush(Colors.Black);
			bl2ell.Visibility = Visibility.Hidden;
		}

		private void TVon(object sender, RoutedEventArgs e) {
			TV.Foreground = new SolidColorBrush(Colors.LightGreen);
			TvRect.Visibility = Visibility.Visible;
		}

		private void TVoff(object sender, RoutedEventArgs e) {
			Bedlight2.Foreground = new SolidColorBrush(Colors.Black);
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