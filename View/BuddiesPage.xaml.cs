using CommunityToolkit.Mvvm.Input;
using ForgetMeNotChaoran.ViewModel;

namespace ForgetMeNotChaoran.View;

public partial class BuddiesPage : ContentPage
{
	private BuddiesViewModel _vm = new();
	public BuddiesPage()
	{
		BindingContext = _vm;
		InitializeComponent();
	}
}