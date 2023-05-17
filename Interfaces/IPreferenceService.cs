using ForgetMeNotChaoran.Model;

namespace ForgetMeNotChaoran.Interfaces
{
    public interface IPreferenceService
    {
        Task<List<Preference>> GetPreferences();
    }
}