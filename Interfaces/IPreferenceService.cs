using ForgetMeNotChaoran.Model;

namespace ForgetMeNotChaoran.Interfaces
{
    public interface IPreferenceService
    {
        public Task<List<Preference>> GetPreferences();
        public Task<List<Preference>> GetPreferencesMock();
    }
}