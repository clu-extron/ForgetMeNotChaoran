using CommunityToolkit.Mvvm.ComponentModel;
using ForgetMeNotChaoran.Interfaces;
using ForgetMeNotChaoran.Model;
using ForgetMeNotChaoran.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.ViewModel
{
    [ObservableObject]
    public partial class PreferencesViewModel
    {
        [ObservableProperty]
        private List<Preference> _preferenceList;

        private readonly IPreferenceService _service;

        public PreferencesViewModel(IPreferenceService service)
        {
            _service = service;
        }

        public async Task Init()
        {
            PreferenceList = await _service.GetPreferences();
        }
    }
}
