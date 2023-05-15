using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.Model
{
    [ObservableObject]
    public partial class Occasion
    {
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private DateTime _date;
        [ObservableProperty]
        private int _numDaysToNotify;
    }
}
