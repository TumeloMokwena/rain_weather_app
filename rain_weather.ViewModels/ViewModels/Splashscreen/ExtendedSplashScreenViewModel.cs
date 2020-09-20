using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using rain_weather.ViewModels.ViewModels.Splashscreen;
using System;
using System.Collections.Generic;
using System.Text;

namespace rain_weather.ViewModels.ViewModels
{
    public class ExtendedSplashScreenViewModel : MvxViewModel
    {
        public CreateNewCommand CreateCommand { get; }

        public ExtendedSplashScreenViewModel(IMvxNavigationService navigationService)
        {
            CreateCommand = new CreateNewCommand(navigationService);
        }
    }
}
