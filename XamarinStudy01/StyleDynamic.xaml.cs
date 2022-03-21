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
    public partial class StyleDynamic : ContentPage
    {
        bool isOriginalStyle = true;

        public StyleDynamic()
        {
            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            if(isOriginalStyle)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
            }

            isOriginalStyle = !isOriginalStyle;

        }
    }
}