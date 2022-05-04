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
    public partial class BoxViewEx01 : ContentPage
    {
        public BoxViewEx01()
        {
            InitializeComponent();
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