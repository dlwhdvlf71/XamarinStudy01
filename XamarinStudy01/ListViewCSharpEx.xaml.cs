using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCSharpEx : ContentPage
    {
        public ListViewCSharpEx()
        {
            //InitializeComponent();

            this.Padding = 15;

            StackLayout stackLayout = new StackLayout();

            string[] strArr = new string[]
            {
                "C", "C#", "Xamarin", "Java", "ASP", "Docker", "Node", "UWP", "ASP.NET", ".NET Core", "IOS", "Android"
                ,"C", "C#", "Xamarin", "Java", "ASP", "Docker", "Node", "UWP", "ASP.NET", ".NET Core", "IOS", "Android"
                ,"C", "C#", "Xamarin", "Java", "ASP", "Docker", "Node", "UWP", "ASP.NET", ".NET Core", "IOS", "Android"
            };

            ListView listView = new ListView();

            listView.ItemsSource = strArr;

            stackLayout.Children.Add(listView);

            Content = stackLayout;
        }
    }
}