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
    public partial class PhoneDialerEx01 : ContentPage
    {
        public PhoneDialerEx01()
        {
            InitializeComponent();
        }

        private void btnPhoneDialer_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string number = string.Empty;

            if (btn.Equals(btnPhoneDialer))
            {
                number = entryPhoneDialer.Text.Trim();
            }
            else if (btn.Equals(btn111))
            {
                number = "111";
            }
            else if (btn.Equals(btn112))
            {
                number = "112";
            }
            else if (btn.Equals(btn119))
            {
                number = "119";
            }
            else if (btn.Equals(btn120))
            {
                number = "120";
            }

            PhoneDialer.Open(number);
        }
    }
}