﻿using ForgetMeNotChaoran.ViewModel;

namespace ForgetMeNotChaoran.View;

public partial class MainPage : ContentPage
{
	private MainViewModel _vm = new MainViewModel();
	public MainPage()
	{
        BindingContext = _vm;
        InitializeComponent();	
	}
}

