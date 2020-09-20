using Plugin.Connectivity;

namespace rain_weather.ViewModels.Helpers
{
    public class NetworkHelper
    {
        public bool IsConnected { get; set; }

        public NetworkHelper()
        {
            IsConnected = CrossConnectivity.Current.IsConnected;
        }
    }
}
