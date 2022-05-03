using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinStudy01.Class;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewEx01 : ContentPage
    {
        public CarouselViewEx01()
        {
            InitializeComponent();

            List<User> users = new List<User>()
            {
                new User() { Id = 1, UserName = "홍길동" }
                , new User() { Id = 2, UserName = "고구려" }
                , new User() { Id = 3, UserName = "태종" }
                , new User() { Id = 4, UserName = "세종대왕" }
            };

            cvUsers.ItemsSource = users;


        }

        private void cvUsers_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            Console.WriteLine((e.CurrentItem as User).Id);
            //Console.WriteLine((e.PreviousItem as User).Id);
        }
    }
}