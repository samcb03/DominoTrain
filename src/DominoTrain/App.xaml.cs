using System.Globalization;
using System.Windows;
using DominoTrain.Resources;
using DominoTrain.Resources.Localization;

namespace DominoTrain;

public partial class App : Application
{
    public App()
    {
        UiStrings.Culture = CultureInfo.GetCultureInfo(SettingsDefaults.DefaultLanguageCode);
    }
}
