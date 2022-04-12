using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapEx : ContentPage
    {
        /// <summary>
        /// Map 클래스를 이용하여 구글 Map을 열 수 있다.
        /// </summary>
        public MapEx()
        {
            InitializeComponent();
        }

        private async void btnMapLocation_Clicked(object sender, EventArgs e)
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                // No map application available to open
            }
        }

        private async void btnPlaceMark_Clicked(object sender, EventArgs e)
        {
            var placemark = new Placemark
            {
                CountryName = "United States",
                AdminArea = "WA",
                Thoroughfare = "Microsoft Building 25",
                Locality = "Redmond"
            };
            var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

            try
            {
                await Map.OpenAsync(placemark, options);
            }
            catch (Exception ex)
            {
                // No map application available to open or placemark can not be located
            }
        }

        private async void btnNavigation_Clicked(object sender, EventArgs e)
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };

            await Map.OpenAsync(location, options);
        }
    }
}