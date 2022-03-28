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
    public partial class ListViewDataBinding : ContentPage
    {
        public ListViewDataBinding()
        {
            //InitializeComponent();

            StackLayout stackLayout = new StackLayout();

            Color[] colors = new Color[]
            {
                Color.Red, Color.Green, Color.Blue,Color.Orange, Color.Black, Color.White, Color.SkyBlue
            };

            ListView listView = new ListView();

            listView.ItemsSource = colors;

            Binding binding = new Binding()
            {
                Source = listView,
                Path = "SelectedItem", Mode = BindingMode.TwoWay
            };

            stackLayout.SetBinding(StackLayout.BackgroundColorProperty, binding);

            stackLayout.Children.Add(listView);

            Content = stackLayout;

        }
    }
}