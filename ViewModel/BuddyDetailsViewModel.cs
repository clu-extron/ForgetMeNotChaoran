using CommunityToolkit.Mvvm.ComponentModel;
using ForgetMeNotChaoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.ViewModel
{
    [ObservableObject]
    [QueryProperty(nameof(MyBuddy), "TheBuddy")]

    public partial class BuddyDetailsViewModel
    {
        [ObservableProperty]
        private string _id;
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string? _website;

        private Buddy _myBuddy;
        public Buddy MyBuddy
        {
            get => _myBuddy;
            set
            {
                Id = value.Id;
                Name = value.Name;
                Website = value.Website;
            }
        }
    }
}
