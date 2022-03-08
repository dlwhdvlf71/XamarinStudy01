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
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;

            if (id.Equals(btGoToSecond.Id))
            {
                await Navigation.PopAsync();
            }
            else if (id.Equals(btGoToMain.Id))
            {
                await Navigation.PopToRootAsync();
            }
        }
    }
}