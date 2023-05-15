using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.ViewModel
{
    public partial class BuddiesViewModel
    {
        [RelayCommand]
        private async Task GoToDetails()
        {
            await Shell.Current.GoToAsync("buddydetailspage");
        }
    }
}
