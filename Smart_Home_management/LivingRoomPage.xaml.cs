using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for LivingRoomPage.xaml
	/// </summary>
	public partial class LivingRoomPage : Page {
		private readonly HomePage home;

		public LivingRoomPage(HomePage _home) {
			InitializeComponent();
			home = _home;
		}

		//CeilingLight
		private void CeilingLightOn(object sender, RoutedEventArgs e) {
			Light.Foreground = new SolidColorBrush(Colors.LightGreen);
			LightRect.Visibility = Visibility.Visible;
			home.lrLight.Visibility = Visibility.Visible;
		}

		private void CeilingLightOff(object sender, RoutedEventArgs e) {
			Light.Foreground = new SolidColorBrush(Colors.Black);
			LightRect.Visibility = Visibility.Hidden;
			home.lrLight.Visibility = Visibility.Hidden;
		}

		//ArrowBack
		private void BackButtonAction(object sender, RoutedEventArgs e) {
			NavigationService.Navigate(home);
		}

		private void TvOn(object sender, RoutedEventArgs e) {
			TV.Foreground = new SolidColorBrush(Colors.LightGreen);
			TvRect.Visibility = Visibility.Visible;
			home.lrTv.Visibility = Visibility.Visible;
		}

		private void TvOff(object sender, RoutedEventArgs e) {
			TV.Foreground = new SolidColorBrush(Colors.Black);
			TvRect.Visibility = Visibility.Hidden;
			home.lrTv.Visibility = Visibility.Hidden;
		}

		private void FloorLampOn(object sender, RoutedEventArgs e) {
			FloorLamp.Foreground = new SolidColorBrush(Colors.LightGreen);
			FloorLampRect.Visibility = Visibility.Visible;
			home.lrLamp.Visibility = Visibility.Visible;
		}

		private void FloorLampOff(object sender, RoutedEventArgs e) {
			FloorLamp.Foreground = new SolidColorBrush(Colors.Black);
			FloorLampRect.Visibility = Visibility.Hidden;
			home.lrLamp.Visibility = Visibility.Hidden;
		}

		private void HelpButtonAction(object sender, RoutedEventArgs e) {
			if (HelpBox.Visibility == Visibility.Visible)
				HelpBox.Visibility = Visibility.Hidden;
			else
				HelpBox.Visibility = Visibility.Visible;
		}
	}
}