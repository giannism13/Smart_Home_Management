using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for loginPage.xaml
	/// </summary>
	public partial class LoginPage : Page {
		public LoginPage() {
			InitializeComponent();
		}

		//private void UsernameField_GotFocus(object sender, RoutedEventArgs e) {
		//	if (usernameField.Text == " Username ") {
		//		usernameField.Text = string.Empty;
		//		usernameField.Foreground = new SolidColorBrush(Colors.Black);
		//	}
		//}

		//private void UsernameField_LostFocus(object sender, RoutedEventArgs e) {
		//	if (usernameField.Text == string.Empty) {
		//		usernameField.Text = " Username ";
		//		usernameField.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA08787"));
		//	}
		//}

		//private void PasswordField_GotFocus(object sender, RoutedEventArgs e) {
		//	if (passwordField.Text == " Password ") {
		//		passwordField.Text = string.Empty;
		//		passwordField.Foreground = new SolidColorBrush(Colors.Black);
		//	}
		//}

		//private void PasswordField_LostFocus(object sender, RoutedEventArgs e) {
		//	if (passwordField.Text == string.Empty) {
		//		passwordField.Text = " Password ";
		//		passwordField.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA08787"));
		//	}
		//}

		private void LoginButton_MouseEnter(object sender, MouseEventArgs e) {
			loginbutton.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF4C70"));
		}

		private void LoginButton_MouseLeave(object sender, MouseEventArgs e) {
			loginbutton.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FE6584"));
		}

		private void LoginButton_Click(object sender, RoutedEventArgs e) {
			if (usernameField.Text == " Username " || passwordField.Password.ToString() == "")
				errorText.Text = "Username and password fields cannot be empty!";
			else if (usernameField.Text == "user" && passwordField.Password.ToString() == "123") {
				MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
				objMainWindows.Main.Navigate(new HomePage(this));
			}
			else
				errorText.Text = "Wrong username or password!";
		}
	}
}
