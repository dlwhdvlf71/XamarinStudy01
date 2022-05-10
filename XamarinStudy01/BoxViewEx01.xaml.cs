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
    public partial class BoxViewEx01 : ContentPage
    {
        public BoxViewEx01()
        {
            InitializeComponent();
           
            //Console.WriteLine($"width : {Application.Current.MainPage.Height} / height : {Application.Current.MainPage.Height}");

            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;


            Console.WriteLine($"width : {mainDisplayInfo.Width} / height : {mainDisplayInfo.Height}");

            BoxView boxView = new BoxView()
            {
                Color = Color.Black,
                CornerRadius = 10,
                WidthRequest = 30,
                HeightRequest = 30
            };

            boxStackLayout.Children.Add(boxView);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Console.WriteLine(sender);

            BoxView boxView = (BoxView)sender;

            Color[] colors = new Color[] { Color.Red, Color.Accent, Color.Bisque, Color.White, Color.Black };

            Random random = new Random();

            boxView.Color = colors[random.Next(0, colors.Length)];
        }
    }
}