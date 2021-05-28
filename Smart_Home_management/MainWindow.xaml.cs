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
			if (usernameField.Text == " Username ") {
				usernameField.Text = string.Empty;
				usernameField.Foreground = new SolidColorBrush(Colors.Black);
			}
		}

		private void UsernameField_LostFocus(object sender, RoutedEventArgs e) {
			if (usernameField.Text == string.Empty) {
				usernameField.Text = " Username ";
				usernameField.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA08787"));
			}
		}

		private void passwordField_GotFocus(object sender, RoutedEventArgs e) {
			if (passwordField.Text == " Password ") {
				passwordField.Text = string.Empty;
				passwordField.Foreground = new SolidColorBrush(Colors.Black);
			}
		}

		private void passwordField_LostFocus(object sender, RoutedEventArgs e) {
			if (passwordField.Text == string.Empty) {
				passwordField.Text = " Password ";
				passwordField.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA08787"));
			}
		}

		private void closeApp(object sender, MouseButtonEventArgs e) {
			Close();
		}

		private void minimizeApp(object sender, MouseButtonEventArgs e) {
			WindowState = WindowState.Minimized;
		}

		private void closeButtonHover(object sender, MouseEventArgs e) {
			closeButton.Fill = new SolidColorBrush(Colors.DarkRed);
		}

		private void closeButtonUnhover(object sender, MouseEventArgs e) {
			closeButton.Fill = new SolidColorBrush(Colors.Red);
		}

		private void minimizeButtonHover(object sender, MouseEventArgs e) {
			minimizeButton.Fill = new SolidColorBrush(Colors.LimeGreen);
		}

		private void minimizeButtonUnhover(object sender, MouseEventArgs e) {
			minimizeButton.Fill = new SolidColorBrush(Colors.LightGreen);
		}

		private void loginbutton_MouseEnter(object sender, MouseEventArgs e) {
			loginbutton.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF4C70"));
		}

		private void loginbutton_MouseLeave(object sender, MouseEventArgs e) {
			loginbutton.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FE6584"));
		}

		private void loginbutton_Click(object sender, RoutedEventArgs e) {
			if (usernameField.Text == " Username " || passwordField.Text == " Password ")
				errorText.Text = "Username and password fields cannot be empty!";
			else if (usernameField.Text == "user" && passwordField.Text == "123")
				errorText.Text = "login success!";
			else
				errorText.Text = "Wrong username or password!";
		}
	}
}
