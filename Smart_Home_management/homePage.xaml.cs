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

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for homePage.xaml
	/// </summary>
	public partial class HomePage : Page {
		public HomePage() {
			InitializeComponent();
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
	}
}
