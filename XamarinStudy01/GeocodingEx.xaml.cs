using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeocodingEx : ContentPage
    {
        public GeocodingEx()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 주소로 위치좌표를 가져온다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btGeocoding_Clicked(object sender, EventArgs e)
        {
            try
            {
                //var address = "Microsoft Building 25 Redmond WA USA";
                var address = "서울특별시 종로구 청와대로 1";
                var locations = await Geocoding.GetLocationsAsync(address);

                var location = locations?.FirstOrDefault();
                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    label01.Text = $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}";
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }
        }

        /// <summary>
        /// 좌표값으로 위치정보를 가져온다. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btReverseGeocoding_Clicked(object sender, EventArgs e)
        {
            try
            {
                var lat = 37.586652;
                var lon = 126.9767701;

                var placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);

                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null)
                {
                    var geocodeAddress =
                        $"AdminArea:       {placemark.AdminArea}\n" +
                        $"CountryCode:     {placemark.CountryCode}\n" +
                        $"CountryName:     {placemark.CountryName}\n" +
                        $"FeatureName:     {placemark.FeatureName}\n" +
                        $"Locality:        {placemark.Locality}\n" +
                        $"PostalCode:      {placemark.PostalCode}\n" +
                        $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                        $"SubLocality:     {placemark.SubLocality}\n" +
                        $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                        $"Thoroughfare:    {placemark.Thoroughfare}\n";

                    Console.WriteLine(geocodeAddress);
                    label02.Text = geocodeAddress;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }
        }
    }
}