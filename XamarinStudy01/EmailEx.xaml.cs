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
    public partial class EmailEx : ContentPage
    {
        /// <summary>
        /// 기본 GMail 로 연결된다.
        /// </summary>
        public EmailEx()
        {
            InitializeComponent();
        }

        private async void btnSend_Clicked(object sender, EventArgs e)
        {
            try
            {
                string subject = entrySubject.Text;
                string body = entryBody.Text;
                List<string> recipients = new List<string> { entryRecipient.Text };

                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients,
                    //Cc = ccRecipients,
                    //Bcc = bccRecipients
                };

                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                // Email is not supported on this device
            }
            catch (Exception ex)
            {
                // Some other exception occurred
            }
        }
    }
}