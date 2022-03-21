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
    public partial class MVVMPatternEx : ContentPage
    {
        public MVVMPatternEx()
        {
            InitializeComponent();


            Device.StartTimer(TimeSpan.FromSeconds(1), Timer);


        }

        private bool Timer()
        {
            lbDateTime.Text = DateTime.Now.ToString();
            lbYear.Text = DateTime.Now.Year.ToString();
            lbMonth.Text = DateTime.Now.Month.ToString();
            lbDay.Text = DateTime.Now.Day.ToString();
            lbTime.Text = DateTime.Now.TimeOfDay.ToString();

            return true;
        }
    }
}