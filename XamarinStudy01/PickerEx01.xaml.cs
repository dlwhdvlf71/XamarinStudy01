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
    public partial class PickerEx01 : ContentPage
    {
        public PickerEx01()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker pk = (Picker)sender;

            var id = pk.Id;

            Debug.WriteLine(pk.SelectedItem);
            Debug.WriteLine(pk.SelectedIndex);

            if (id.Equals(pickerGrade.Id))
            {
                lbGrade.Text = $"Grade : {pk.SelectedItem}";
            }
            else if(id.Equals(pickerMajor.Id))
            {
                lbMajor.Text = $"Major : {pk.SelectedItem}";
            }
            else if(id.Equals(pickerGender.Id))
            {
                lbGender.Text = $"Gender : {pk.SelectedItem}";
            }

        }
    }
}