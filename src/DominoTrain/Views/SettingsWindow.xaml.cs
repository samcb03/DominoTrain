using System.Windows;

namespace DominoTrain.Views;

public partial class SettingsWindow : Window
{
    public SettingsWindow()
    {
        InitializeComponent();
    }

    private void CloseSettings(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
