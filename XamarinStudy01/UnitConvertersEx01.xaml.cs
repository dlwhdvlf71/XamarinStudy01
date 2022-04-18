using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UnitConvertersEx01 : ContentPage
    {
        public UnitConvertersEx01()
        {
            InitializeComponent();
        }

        private void btnCelsiusToFahrenheit_Clicked(object sender, EventArgs e)
        {
            string text = entryCelsiusToFahrenheit.Text;

            entryCelsiusToFahrenheit.Text = text + " >" + UnitConverters.CelsiusToFahrenheit(Convert.ToDouble(text));
        }

        private void btnCelsiusToKelvin_Clicked(object sender, EventArgs e)
        {
            string text = entryCelsiusToKelvin.Text;

            entryCelsiusToKelvin.Text = text + " >" + UnitConverters.CelsiusToKelvin(Convert.ToDouble(text));
        }

        private void btnMilesToMeters_Clicked(object sender, EventArgs e)
        {
            string text = entryMilesToMeters.Text;

            entryMilesToMeters.Text = text + " >" + UnitConverters.MilesToMeters(Convert.ToDouble(text));
        }

        private void btnMilesToKilometers_Clicked(object sender, EventArgs e)
        {
            string text = entryMilesToKilometers.Text;

            entryMilesToKilometers.Text = text + " >" + UnitConverters.MilesToKilometers(Convert.ToDouble(text));
        }
    }
}