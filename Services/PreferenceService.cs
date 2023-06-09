﻿using ForgetMeNotChaoran.Interfaces;
using ForgetMeNotChaoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotChaoran.Services
{
    public class PreferenceService : IPreferenceService
    {
        public async Task<List<Preference>> GetPreferences()
        {
            return await GetPreferencesMock();
        }

        public async Task<List<Preference>> GetPreferencesMock()
        {
            List<Preference> preferences = new()
            {
                new Preference()
                {
                    PreferencePrompt = "Shirt Size",
                    PreferenceValue = ""
                },
                new Preference()
                {
                    PreferencePrompt = "Favorite Music Genre",
                    PreferenceValue = ""
                },
                new Preference()
                {
                    PreferencePrompt = "Favorite Color",
                    PreferenceValue = ""
                },
                new Preference()
                {
                    PreferencePrompt = "Favorite Food",
                    PreferenceValue = ""
                },
                new Preference()
                {
                    PreferencePrompt = "Favorite Movie",
                    PreferenceValue = ""
                }
            };

            return preferences;
        }
    }
}
