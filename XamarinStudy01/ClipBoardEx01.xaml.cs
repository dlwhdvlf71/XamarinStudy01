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
    public partial class ClipBoardEx01 : ContentPage
    {
        public ClipBoardEx01()
        {
            InitializeComponent();

            if (Clipboard.HasText)
            {
                btnGetClipboard_Clicked(null, null);
            }
        }

        private async void btnSetClipboard_Clicked(object sender, EventArgs e)
        {
            string memo = entryMemo.Text.Trim();

            await Clipboard.SetTextAsync(memo);

            this.DisplayAlert("Saveed to Clipboard", memo, "Confirm");
        }

        private async void btnGetClipboard_Clicked(object sender, EventArgs e)
        {
            var memo = await Clipboard.GetTextAsync();

            labelMemo.Text = memo;
        }

    }
}