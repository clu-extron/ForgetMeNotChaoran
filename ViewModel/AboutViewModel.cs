using CommunityToolkit.Mvvm.ComponentModel;
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
    }
}
