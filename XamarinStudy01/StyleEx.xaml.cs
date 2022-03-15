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
    public partial class StyleEx : ContentPage
    {
        public StyleEx()
        {
            InitializeComponent();

            var csMainTitleStyle = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter
                    {
                        Property = Label.TextColorProperty,
                        Value = "#fff",
                    },
                    new Setter 
                    {
                        Property = BackgroundColorProperty,
                        Value = Color.Red
                    },
                    new Setter
                    {
                        Property = PaddingProperty,
                        Value = 5
                    }
                    
                }
            };

            var csSubTitleStyle = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter
                    {
                        Property = Label.TextColorProperty,
                        Value= "#fff",
                    },
                    new Setter
                    {
                        Property= BackgroundColorProperty,
                        Value = Color.FromHex("#900")
                    },
                    new Setter
                    {
                        Property = PaddingProperty,
                        Value = new Thickness(5)
                    }
                }
            };

            Label label01 = new Label();
            label01.Text = "cs Label 01";
            label01.Style = csMainTitleStyle;

            Label label02 = new Label();
            label02.Text = "cs Label 02";
            label02.Style = csSubTitleStyle;

            mainStackLayout.Children.Add(label01);
            mainStackLayout.Children.Add(label02);

        }
    }
}