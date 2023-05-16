using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.ViewModel
{
    [ObservableObject]
    public partial class UserPreferencesViewModel
    {
        [ObservableProperty]
        private string _displayName;
        [ObservableProperty]
        private string _themeSelection;
        [ObservableProperty]
        private bool _wifiOnly;
        public string ThemeGroupName => "Theme";

        [RelayCommand]
        public async Task SavePreferences()
        {
            Preferences.Default.Set("DisplayName", _displayName);
            Preferences.Default.Set("ThemeSelection", _themeSelection);
            Preferences.Default.Set("WifiOnly", _wifiOnly);
        }
    }
}
