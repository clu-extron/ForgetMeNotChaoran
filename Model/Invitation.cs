using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.Model
{
    [ObservableObject]
    public partial class Invitation
    {
        [ObservableProperty]
        private string _buddyCode;
        [ObservableProperty]    
        private int _buddyId;
    }
}
