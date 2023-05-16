using ForgetMeNotChaoran.ViewModel;

namespace ForgetMeNotChaoran.View;

public partial class BuddyDetailsPage : ContentPage
{
	BuddyDetailsViewModel _vm = new();
	public BuddyDetailsPage()
	{
		BindingContext = _vm;
		InitializeComponent();
	}
}