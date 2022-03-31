using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorPicker : ContentPage
    {
        Dictionary<string, Color> colors = new Dictionary<string, Color>()
        {
            {"Accent", Color.Accent}, {"Red", Color.Red}, {"Green", Color.Green}, {"Blue", Color.Blue}, {"AliceBlue", Color.AliceBlue},
            {"Aqua", Color.Aqua}, {"Beige", Color.Beige}, {"Brown", Color.Brown}, {"Chocolate", Color.Chocolate}, {"DeepPink", Color.DeepPink}
            , {"Cyan", Color.Cyan}, {"BlanchedAlmond", Color.BlanchedAlmond}, {"DarkKhaki", Color.DarkKhaki}
            , {"GreenYellow", Color.GreenYellow}, {"MistyRose", Color.MistyRose}, {"Gold", Color.Gold}, {"Gray", Color.Gray}
            , {"OldLace", Color.OldLace}
        };

        public ColorPicker()
        {
            InitializeComponent();

            foreach(string name in colors.Keys)
            {
                picker01.Items.Add(name);
            }

        }

        private void picker01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(picker01.SelectedIndex == -1)
            {
                boxView.Color = Color.Black;
            }
            else
            {
                boxView.Color = colors[picker01.SelectedItem.ToString()];
            }
        }
    }
}