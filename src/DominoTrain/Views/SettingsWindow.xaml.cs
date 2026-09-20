using System.Windows;
using DominoTrain.Resources;
using DominoTrain.ViewModels;

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

    private void SelectSpanishLanguage(object sender, RoutedEventArgs e)
    {
        LocalizationViewModel.Instance.ChangeLanguage(SettingsDefaults.SpanishLanguageCode);
    }

    private void SelectEnglishLanguage(object sender, RoutedEventArgs e)
    {
        LocalizationViewModel.Instance.ChangeLanguage(SettingsDefaults.EnglishLanguageCode);
    }
}
