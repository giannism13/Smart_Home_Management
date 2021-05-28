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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Grid_MouseDown(object sender, MouseButtonEventArgs e) {
			if (e.LeftButton == MouseButtonState.Pressed)
				DragMove();
		}

		private void UsernameField_GotFocus(object sender, RoutedEventArgs e) {
			if (usernameField.Text == "Username") {
				usernameField.Text = string.Empty;
				usernameField.Foreground = new SolidColorBrush(Colors.Black);
			}
		}

		private void UsernameField_LostFocus(object sender, RoutedEventArgs e) {
			if (usernameField.Text == string.Empty) {
				usernameField.Text = "Username";
				usernameField.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA08787"));
			}
		}

		private void passwordField_GotFocus(object sender, RoutedEventArgs e) {
			if (passwordField.Text == "Password") {
				passwordField.Text = string.Empty;
				passwordField.Foreground = new SolidColorBrush(Colors.Black);
			}
		}

		private void passwordField_LostFocus(object sender, RoutedEventArgs e) {
			if (passwordField.Text == string.Empty) {
				passwordField.Text = "Password";
				passwordField.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA08787"));
			}
		}
	}
}
