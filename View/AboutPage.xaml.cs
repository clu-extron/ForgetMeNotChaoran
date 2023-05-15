using ForgetMeNotChaoran.ViewModel;

namespace ForgetMeNotChaoran.View;

public partial class AboutPage : ContentPage
{
	private AboutViewModel _vm = new();
	public AboutPage()
	{
		BindingContext = _vm;
		InitializeComponent();
	}
}