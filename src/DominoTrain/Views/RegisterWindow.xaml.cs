using System.Windows;

namespace DominoTrain.Views;
public partial class RegisterWindow : Window
{
    public RegisterWindow()
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
}
