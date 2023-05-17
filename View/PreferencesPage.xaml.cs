using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ForgetMeNotChaoran.ViewModel;

namespace ForgetMeNotChaoran.View;

public partial class PreferencesPage : ContentPage
{
	private PreferencesViewModel _vm;
	public PreferencesPage(PreferencesViewModel preferencesVM)
	{
		_vm = preferencesVM;
		BindingContext = _vm;
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await _vm.Init();
	}

	public void SavePreferences(object sender, EventArgs e)
	{
		ShowToast();
	}

	private async Task ShowToast()
	{
		var cancellationTokenSource = new CancellationTokenSource();
		var message = "Your preferences are saved";
		ToastDuration duration = ToastDuration.Short;
		var fontSize = 14;
		var toast = Toast.Make(message, duration, fontSize);
		await toast.Show(cancellationTokenSource.Token);
	}
}