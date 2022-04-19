using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ClipBoardEx01();
            //MainPage = new NavigationPage(new MainPage()); // new MainPage();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
