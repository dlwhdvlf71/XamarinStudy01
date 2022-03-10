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
    public partial class DataBind : ContentPage
    {
        public DataBind()
        {
            InitializeComponent();

            InitProperty();

            xLabel09.BindingContext = xSlider05;
            xLabel10.BindingContext = xSlider05;

            xLabel09.SetBinding(Label.PaddingProperty, "Value");
            xLabel10.SetBinding(Label.FontSizeProperty, "Value");


            Binding binding1 = new Binding()
            {
                Source = xSlider06,
                Path = "Value"
            };

            Binding binding2 = new Binding()
            {
                Source = xSlider06,
                Path = "Value"
            };

            xLabel11.SetBinding(Label.PaddingProperty, binding1);
            xLabel12.SetBinding(Label.FontSizeProperty, binding1);

        }

        private void xSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            xLabel01.Padding = (int)xSlider01.Value;
            xLabel02.FontSize = (int)xSlider01.Value;
        }

        private void InitProperty()
        {
            xLabel01.Padding = (int)xSlider01.Value;
            xLabel02.FontSize = (int)xSlider01.Value;
        }
    }
}