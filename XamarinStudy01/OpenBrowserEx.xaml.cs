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
    public partial class OpenBrowserEx : ContentPage
    {
        public OpenBrowserEx()
        {
            InitializeComponent();
        }

        private async void btnOpenBrowser_Clicked(object sender, EventArgs e)
        {
            try
            {
                string uri = entryUrl.Text.Trim();

                if(!uri.Contains("http://") && !uri.Contains("https://"))
                {
                    uri = "https://" + uri;
                }

                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }
    }
}