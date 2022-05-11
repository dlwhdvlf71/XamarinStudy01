using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy01
{
    public partial class App : Application
    {
        const string displayText = "displayText";

        public string DisplayText { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new OptionSettingPage();
            //MainPage = new NavigationPage(new MainPage()); // new MainPage();
        }

        /// <summary>
        /// 애플리케이션이 시작될 때 호출 된다.
        /// </summary>
        protected override void OnStart()
        {
            Console.WriteLine("OnStart");

            if (Properties.ContainsKey(displayText))
            {
                DisplayText = (string)Properties[displayText];
            }
        }

        /// <summary>
        /// 애플리케이션이 백그라운드로 이동할 때 호출된다.
        /// </summary>
        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");

            // Properties 사전을 통해 Xamarin.Form 코드 어느곳에서나 액세스 할 수 있다.
            // 로그인 후 ID 같은 정보들을 저장해두었다가 사용하면 좋다.
            // 정적으로 쓰이는 데이터 경우 사용하면 좋다.
            Properties[displayText] = DisplayText;

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
