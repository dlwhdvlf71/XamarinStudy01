using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicResource : ContentPage
    {
        public DynamicResource()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;

            if(id == ChangedColorBlue.Id)
            {
                labelTitle.BackgroundColor = (Color)this.Resources["backgroundColorBlue"];
            }
            else if(id == ChangedColorGreen.Id)
            {
                labelTitle.BackgroundColor = (Color)this.Resources["backgroundColorGreen"];
            }
            else if(id == ChangedColorRed.Id)
            {
                labelTitle.BackgroundColor = (Color)this.Resources["backgroundColorRed"];
            }
            else if(id == ChangedFontSizeBig.Id)
            {
                labelTitle.FontSize = (double)this.Resources["fontSizeBig"];
            }
            else if (id == ChangedFontSizeNormal.Id)
            {
                labelTitle.FontSize = (double)this.Resources["fontSizeNormal"];
            }
            else if (id == ChangedFontSizeSmall.Id)
            {
                labelTitle.FontSize = (double)this.Resources["fontSizeSmall"];
            }
            else if (id == ChangedPaddingBig.Id)
            {
                labelTitle.Padding = (double)this.Resources["paddingBig"];
            }
            else if (id == ChangedPaddingNormal.Id)
            {
                labelTitle.Padding = (double)this.Resources["paddingNormal"];
            }
            else if (id == ChangedPaddingSmall.Id)
            {
                labelTitle.Padding = (double)this.Resources["paddingSmall"];
            }
        }
    }
}