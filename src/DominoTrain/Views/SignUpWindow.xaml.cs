using System.Windows;

namespace DominoTrain.Views;
public partial class SignUpWindow : Window
{
    public SignUpWindow()
    {
        InitializeComponent();
    }

    private void OpenSettings(object sender, RoutedEventArgs e)
    {
        SettingsWindow settingsWindow = new SettingsWindow
        {
            Owner = this
        };
        settingsWindow.ShowDialog();
    }

    private void NavigateToLogin_Click(object sender, RoutedEventArgs e)
    {
        LogInWindow loginWindow = new LogInWindow();

        loginWindow.Show();
        this.Close();
    }
}
