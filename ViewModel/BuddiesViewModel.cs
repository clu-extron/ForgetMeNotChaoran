using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ForgetMeNotChaoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.ViewModel
{
    [ObservableObject]
    public partial class BuddiesViewModel
    {
        [ObservableProperty]
        private Buddy _rodrigo = new Buddy
        {
            Id = "002",
            Name = "Rodrigo Juarez",
            Website = "https://jesseliberty.com"
        };
        [RelayCommand]
        private async Task GoToDetails()
        {
            var navigationParameter = new Dictionary<string, object>
            {
                {"TheBuddy", Rodrigo }
            };
            await Shell.Current.GoToAsync($"buddydetailspage", navigationParameter);
        }
    }
}
