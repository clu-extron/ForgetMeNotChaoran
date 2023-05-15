﻿using ForgetMeNotChaoran.View;

namespace ForgetMeNotChaoran;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("buddiespage", typeof(BuddiesPage));
		Routing.RegisterRoute("buddydetailspage", typeof(BuddyDetailsPage));
		Routing.RegisterRoute("aboutpage", typeof(AboutPage));
		Routing.RegisterRoute("preferencespage", typeof(PreferencesPage));
		Routing.RegisterRoute("loginpage", typeof(LoginPage));
		Routing.RegisterRoute("mainpage", typeof(MainPage));
	}
}
