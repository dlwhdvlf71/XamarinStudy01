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
    public partial class DeviceDisplayEx : ContentPage
    {
        Label label = new Label();
        Button button;

        public DeviceDisplayEx()
        {
            //InitializeComponent();

            this.Padding = 20;

            // Get Metrics
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            // Orientation (Landscape, Portrait, Square, Unknown)
            var orientation = mainDisplayInfo.Orientation;

            // Rotation (0, 90, 180, 270)
            var rotation = mainDisplayInfo.Rotation;

            // Width (in pixels)
            var width = mainDisplayInfo.Width;

            // Height (in pixels)
            var height = mainDisplayInfo.Height;

            // Screen density
            var density = mainDisplayInfo.Density;

            string strInfo = $@"Metrics : {mainDisplayInfo} \r Orientation : {orientation} \r Rotation : {rotation} \r Width : {width} \r height : {height} \r density : {density}";


            label = new Label()
            {
                Text = strInfo,
                FontSize = 12,
                FontAttributes = FontAttributes.Bold
            };

            button = new Button
            {
                Text = "Button"
            };

            button.Clicked += (sender, args) =>
            {
                DeviceDisplay.KeepScreenOn = !DeviceDisplay.KeepScreenOn;
            };

            Content = new StackLayout
            {
                Children =
                {
                    label, button
                }
            };

            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged; 

        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            var displayInfo = e.DisplayInfo;

            label.Text += $"displayInfo : {displayInfo}";
        }
    }
}