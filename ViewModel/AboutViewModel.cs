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
    public partial class AboutViewModel
    {
        [ObservableProperty]
        private string _apiVersion;

        public AboutViewModel()
        {
            _apiVersion = "1.0";
        }

        [RelayCommand]
        public async Task OpenPreferences()
        {
            await Shell.Current.GoToAsync($"userpreferences");

        }
    }
}
