using ForgetMeNotChaoran.ViewModel;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Messaging;

namespace ForgetMeNotChaoran.View;

public partial class LoginPage : ContentPage
{
	public static ProgressBar LoginProgressBar;
	private LoginViewModel _vm = new LoginViewModel();
	public LoginPage()
	{
		LoginProgressBar = new ProgressBar();
        InitializeComponent();
		LoginStackLayout.Children.Add(LoginProgressBar);
        BindingContext = _vm;
		WeakReferenceMessenger.Default.Register<ConstructMessage>(this, async (m, e) => 
		{
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            var message = "Your account was created";
            var dismissalText = "Click Here to Close the SnackBar";
            TimeSpan duration = TimeSpan.FromSeconds(10);

            Action action = async () => await DisplayAlert(
                "Snackbar Dismissed!",
                "The user has dismissed the snackbar",
                "OK");

            var snackbarOptions = new SnackbarOptions
            {
                BackgroundColor = Colors.Red,
                TextColor = Colors.Yellow,
                ActionButtonTextColor = Colors.Black,
                CornerRadius = new CornerRadius(20),
                Font = Microsoft.Maui.Font.SystemFontOfSize(14),
                ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14)
            };

            var snackbar = Snackbar.Make(
                message,
                action,
                dismissalText,
                duration,
                snackbarOptions);

            await snackbar.Show(cancellationTokenSource.Token);

            _vm.ActivityIndicatorIsRunning = false;
        });
    }

	private async void OnForgotPassword(object sender, EventArgs e)
	{
		CreateAccount.Text = (await DisplayActionSheet(
			"How can we solve this?",
			"Cancel",
			null,
			"Get new password",
			"Show me my hint",
			"Delete account"));
	}
}