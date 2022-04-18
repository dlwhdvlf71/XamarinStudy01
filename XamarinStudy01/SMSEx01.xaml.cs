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
    public partial class SMSEx01 : ContentPage
    {
        public SMSEx01()
        {
            InitializeComponent();
        }

        private async void btnSMS_Clicked(object sender, EventArgs e)
        {
            try
            {
                string[] recipients = new string[] { entryRecipient.Text };
                string message = entryMessage.Text.Trim();

                await Sms.ComposeAsync(new SmsMessage(message, recipients));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}