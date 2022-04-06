using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeachEx : ContentPage
    {
        //public CancellationTokenSource cts;

        public TextToSpeachEx()
        {
            InitializeComponent();
        }
        
        public async Task SpeakNowDefaultSettings()
        {
            await TextToSpeech.SpeakAsync("Hello World");
        }

        private async void btTextToSpeach_Clicked(object sender, EventArgs e)
        {
            await SpeakNowDefaultSettings();
        }

        public async Task SpeakNow()
        {
            var settings = new SpeechOptions()
            {
                Volume = .75f,
                Pitch = 1.0f
            };

            await TextToSpeech.SpeakAsync("Hello World SpeakNow", settings);
        }

        private async void btTTSSetting_Clicked(object sender, EventArgs e)
        {
            await SpeakNow();
        }

        private async void btLabel01TTS_Clicked(object sender, EventArgs e)
        {
            string text = lb01.Text.Trim();

            await TextToSpeech.SpeakAsync(text);
        }

        private async void btLabel02TTS_Clicked(object sender, EventArgs e)
        {
            string text = lb02.Text.Trim();

            cts = new CancellationTokenSource();

            await TextToSpeech.SpeakAsync(text, cancelToken: cts.Token);

        }

        private void btCts_Clicked(object sender, EventArgs e)
        {
            if (cts?.IsCancellationRequested ?? true)
                return;

            cts.Cancel();
        }
    }
}