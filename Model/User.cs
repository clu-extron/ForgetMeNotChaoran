using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.Model
{
    [ObservableObject]
    public partial class User
    {
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _id;
        [ObservableProperty]
        private List<Buddy> _buddies;
        [ObservableProperty]
        private List<Invitation> _invitations;
        [ObservableProperty]
        private List<Preference> _preferences;
    }
}
