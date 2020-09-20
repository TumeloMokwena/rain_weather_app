using MvvmCross.Navigation;
using rain_weather.ViewModels.ViewModels.WeatherHome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace rain_weather.ViewModels.ViewModels.Splashscreen
{
    public class CreateNewCommand : CommandBaseAsync
    {
        private IMvxNavigationService _navigationService;

        public CreateNewCommand(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public async override Task ExecuteImplementationAsync(object parameter)
        {
            await _navigationService.Navigate<WeatherHomeViewModel>();
        }
    }
}
