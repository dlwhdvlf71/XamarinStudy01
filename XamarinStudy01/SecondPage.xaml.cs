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
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;

            if (id.Equals(btGoThird.Id))
            {
                await Navigation.PushAsync(new ThirdPage());
            }
            else if (id.Equals(btGoToMain.Id))
            {
                await Navigation.PopAsync();  //  현재 페이지 제거
            }
        }
    }
}