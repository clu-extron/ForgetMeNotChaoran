﻿using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using ForgetMeNotChaoran.Interfaces;
using ForgetMeNotChaoran.Services;
using ForgetMeNotChaoran.ViewModel;
using Microsoft.Extensions.Logging;

namespace ForgetMeNotChaoran;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<IPreferenceService, PreferenceService>();

		builder.Services.AddTransient<AboutViewModel>();
        builder.Services.AddTransient<BuddyDetailsViewModel>();
        builder.Services.AddTransient<PreferencesViewModel>();
        builder.Services.AddTransient<LoginViewModel>();

        return builder.Build();
	}
}
