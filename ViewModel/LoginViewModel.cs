using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ForgetMeNotChaoran.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.ViewModel
{
    [ObservableObject]
    internal partial class LoginViewModel
    {
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private bool activityIndicatorIsRunning = true;

        [RelayCommand]
        private async void Submit()
        {
            for (var i = 0.0; i < 1.0; i += 0.1)
            {
                await LoginPage.LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
            }

            await Application.Current.MainPage.DisplayAlert(
                "Submit",
                $"you entered {Name} and {Password}",
                "OK");
        }

        [RelayCommand]
        private void Create()
        {
            WeakReferenceMessenger.Default.Send(new CreateMessage());
        }
    }
}
