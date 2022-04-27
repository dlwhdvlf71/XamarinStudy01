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

            MainPage = new SQLiteEx02();
            //MainPage = new NavigationPage(new MainPage()); // new MainPage();

        }

        /// <summary>
        /// 애플리케이션이 시작될 때 호출 된다.
        /// </summary>
        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
        }

        /// <summary>
        /// 애플리케이션이 백그라운드로 이동할 때 호출된다.
        /// </summary>
        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
        }

        /// <summary>
        /// 애플리케이션이 백그라운드에서 다시 시작할 때 호출된다.
        /// </summary>
        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
    }
}
