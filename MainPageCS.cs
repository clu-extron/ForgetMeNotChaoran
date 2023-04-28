using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Markup;

namespace ForgetMeNotChaoran
{
    class MainPageCS : ContentPage
    {
        private readonly Button _counterBtn = new Button 
        { 
            Text = "Click Me",
            HorizontalOptions = LayoutOptions.Center,
        }.SemanticHint("Counts the number of times you click, which is created by C# code");

        public MainPageCS()
        {
            _counterBtn.Clicked += _OnCounterClicked;

            Content = new VerticalStackLayout
            {
                Spacing = 30,
                Padding = new Thickness(30, 0),
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Image()
                    {
                        Source = "dotnet_bot.png",
                        HeightRequest = 200,
                        HorizontalOptions =
                        LayoutOptions.Center,
                    }.SemanticDescription("Cute dot net bot waving hi to you!"),

                    new Label()
                    {
                        Text = "Hello World",
                        FontSize = 32,
                        HorizontalOptions =
                        LayoutOptions.Center,
                    }.SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                    new Label()
                    {
                        Text = "Welcome to .NET Multiplatform App UI Created By C# code Directly",
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.Center,
                    }.SemanticHeadingLevel(SemanticHeadingLevel.Level2).SemanticDescription("Welcome to dot net Multi platform App UI"),

                    _counterBtn,
                }
            };
        }

        private int _count = 0;

        private void _OnCounterClicked(object sender, EventArgs e)
        {
            _count++;

            if (_count == 1)
                _counterBtn.Text = $"Clicked {_count} time";
            else
                _counterBtn.Text = $"Clicked {_count} times";
            SemanticScreenReader.Announce(_counterBtn.Text);
        }
        
    }
}
