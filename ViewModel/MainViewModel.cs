using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ForgetMeNotChaoran.ViewModel
{
    [ObservableObject]
    public partial class MainViewModel
    {
        [ObservableProperty]
        private bool _flowerIsVisible = true;

        [ObservableProperty]
        private string _fullName = "Chaoran Lu";

        [ObservableProperty]
        private string _favoriteFlower = "flower.png";

        [RelayCommand]
        private void ImageTapped()
        {
            FlowerIsVisible = !FlowerIsVisible;
        }
    }
}
