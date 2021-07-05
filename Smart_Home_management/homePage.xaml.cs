using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for homePage.xaml
	/// </summary>
	public partial class HomePage : Page {
		private readonly BathroomPage brpage;

		public HomePage() {
			InitializeComponent();
			brpage = new BathroomPage(this);
		}

		private void KitchenButton_MouseEnter(object sender, MouseEventArgs e) {
			kitchen.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF4C70");
			KitchenBorder.Visibility = Visibility.Visible;
		}

		private void KitchenButton_MouseLeave(object sender, MouseEventArgs e) {
			kitchen.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FE6584");
			KitchenBorder.Visibility = Visibility.Hidden;
		}


		private void LivingRoomButton_MouseEnter(object sender, MouseEventArgs e) {
			livingRoom.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF4C70");
			LivingRoomBorder.Visibility = Visibility.Visible;
		}

		private void LivingRoomButton_MouseLeave(object sender, MouseEventArgs e) {
			livingRoom.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FE6584");
			LivingRoomBorder.Visibility = Visibility.Hidden;
		}

		private void Bedroom1Button_MouseEnter(object sender, MouseEventArgs e) {
			bedroom1.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF4C70");
			Bedroom1Border.Visibility = Visibility.Visible;
		}

		private void Bedroom1Button_MouseLeave(object sender, MouseEventArgs e) {
			bedroom1.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FE6584");
			Bedroom1Border.Visibility = Visibility.Hidden;
		}


		private void Bedroom2Button_MouseEnter(object sender, MouseEventArgs e) {
			bedroom2.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF4C70");
			Bedroom2Border.Visibility = Visibility.Visible;
		}

		private void Bedroom2Button_MouseLeave(object sender, MouseEventArgs e) {
			bedroom2.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FE6584");
			Bedroom2Border.Visibility = Visibility.Hidden;
		}


		private void BathroomButton_MouseEnter(object sender, MouseEventArgs e) {
			bathroom.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF4C70");
			BathroomBorder.Visibility = Visibility.Visible;
		}

		private void BathroomButton_MouseLeave(object sender, MouseEventArgs e) {
			bathroom.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FE6584");
			BathroomBorder.Visibility = Visibility.Hidden;
		}

		private void GotoBathroom(object sender, RoutedEventArgs e) {
			NavigationService.Navigate(brpage);
		}
	}
}
