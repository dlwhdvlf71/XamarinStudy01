using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Switch = Xamarin.Forms.Switch;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryEx : ContentPage
    {
        public EntryEx()
        {
            InitializeComponent();

            eImage.Source = ImageSource.FromUri(new Uri("https://noticon-static.tammolo.com/dgggcrkxq/image/upload/v1568175385/noticon/iodu1jssf0kwe4oie2dt.png"));
        }

        private void BtnConfirm_Clicked(object sender, EventArgs e)
        {
            try
            {
                string info = string.Format($"name : {eName.Text}, phone : {ePhone.Text}, mail : {eMail.Text}, id : {eID.Text}, age : {eAge.Text}, comment : {eComment.Text}");

                Debug.WriteLine(info);

                this.DisplayAlert("Student Info",info, "Close");

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void xWeight_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            try
            {
                eWeight.Text = ((Slider)sender).Value.ToString();


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void cbIsEmail_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                eMail.IsEnabled = ((CheckBox)sender).IsChecked;


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void wsIsPhone_Toggled(object sender, ToggledEventArgs e)
        {
            try
            {
                ePhone.IsEnabled  = ((Switch)sender).IsToggled;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private async void Alert_Clicked(object sender, EventArgs e)
        {
            try
            {
                var id = ((Button)sender).Id;

               if(id == btAlert1.Id)
                {
                    await DisplayAlert("Display Alert", "Popup 1", "Close");
                }
                else if (id == btAlert2.Id)
                {
                    bool result = await DisplayAlert("Display Alert", "Popup 1", "YES", "NO");

                    Debug.WriteLine($"display2 : {result}");
                }
                else if (id == btAlert3.Id)
                {
                    string result = await DisplayActionSheet("Select Choice", "Cancel", null, "east", "west", "south", "north");

                    Debug.WriteLine($"display2 : {result}");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private async void btPropt_Clicked(object sender, EventArgs e)
        {
            try
            {
                var id = ((Button)sender).Id;

                if(btPropt1.Id == id)
                {
                    string result = await DisplayPromptAsync("Question 1", "What's your name?");

                    Debug.WriteLine($"display2 : {result}");
                }
                else if(btPropt2.Id == id)
                {
                    string result = await DisplayPromptAsync("Question 2", "What's 5 + 5?", maxLength: 2, keyboard: Keyboard.Numeric);

                    Debug.WriteLine($"display2 : {result}");
                }
                else if( btPropt3.Id == id)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dtBirth_DateSelected(object sender, DateChangedEventArgs e)
        {
            try
            {
                var id = ((DatePicker)sender).Id;

                DateTime dateTime = e.NewDate;

                int year = dateTime.Year;
                int month = dateTime.Month;
                int day = dateTime.Day;

                char[] days = { '일', '월', '화', '수', '목', '금', '토' };

                char date = days[(int)dateTime.DayOfWeek];

                lbDate.Text = $"{date}요일";

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void BirthTime_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var id = ((TimePicker)sender).Id;

            Debug.WriteLine("id : ------------ " + id);

            if(e.PropertyName == "Time")
            {
                lbDate.Text = BirthTime.Time.ToString();
            }
        }
    }
}