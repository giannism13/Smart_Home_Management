using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Smart_Home_management {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			Main.Content = new LoginPage();
		}

		private void Grid_MouseDown(object sender, MouseButtonEventArgs e) {
			if (e.LeftButton == MouseButtonState.Pressed)
				DragMove();
		}

		private void CloseApp(object sender, MouseButtonEventArgs e) {
			Close();
		}

		private void MinimizeApp(object sender, MouseButtonEventArgs e) {
			WindowState = WindowState.Minimized;
		}

		private void CloseButtonHover(object sender, MouseEventArgs e) {
			closeButton.Fill = new SolidColorBrush(Colors.DarkRed);
		}

		private void CloseButtonUnhover(object sender, MouseEventArgs e) {
			closeButton.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FC6586"));
		}

		private void MinimizeButtonHover(object sender, MouseEventArgs e) {
			minimizeButton.Fill = new SolidColorBrush(Colors.LimeGreen);
		}

		private void MinimizeButtonUnhover(object sender, MouseEventArgs e) {
			minimizeButton.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#3DDDC2"));
		}
	}
}
