using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.Model
{
    [ObservableObject]
    public partial class Preference
    {
        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        private string _preferencePrompt;
        [ObservableProperty]
        private string _preferenceValue;
    }
}
