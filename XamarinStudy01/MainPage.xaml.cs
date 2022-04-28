using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinStudy01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            entryInput.Text = (Application.Current as App).DisplayText;
        }

        private async void btGoToSecond_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new SecondPage());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void entryInput_Completed(object sender, EventArgs e)
        {
            (Application.Current as App).DisplayText = entryInput.Text;

            Console.WriteLine("entryInput_Completed");
        }
    }
}
