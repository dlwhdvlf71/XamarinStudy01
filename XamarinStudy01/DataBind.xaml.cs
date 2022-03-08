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