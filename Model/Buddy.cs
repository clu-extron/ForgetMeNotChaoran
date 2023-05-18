using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.Model
{
    public partial class Buddy : User
    {
        [ObservableProperty]
        private string _emailAddress;
        [ObservableProperty]
        private string? _phoneNumber;
        [ObservableProperty]
        private string? _mailingAddressLine1;
        [ObservableProperty]
        private string? _mailingAddressLine2;
        [ObservableProperty]
        private string? _website;
        [ObservableProperty]
        private string? _twitter;
        [ObservableProperty]
        private string? _facebook;
        [ObservableProperty]
        private string? _instagram;
        [ObservableProperty]
        private string? _linkedIn;
        [ObservableProperty]
        private string? _venmoName;
        //[ObservableProperty]
        //private InvitationStatus _status;
        //[ObservableProperty]
        //private List<OccasionModel> _occations;
        [ObservableProperty]
        private DateTime _buddySince;
    }
}
