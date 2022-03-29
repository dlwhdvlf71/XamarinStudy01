using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListviewObservalEx01 : ContentPage
    {
        string[] idArr = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] nameArr = new string[] { "홍","길","동" };
        string[] majorArr = new string[] { "국어","영어","수학","사회","과학","컴퓨터","미술" };

        char[] genderArr = new char[] { 'M', 'W' };

        int[] gradeArr = new int[] { 1,2,3,4,};
        int[] ageArr = new int[] { 19,20,21,22,23,24,25,26,27,28,29,30 };


        public ListviewObservalEx01()
        {
            InitializeComponent();

            ObservableCollection<Student> students = new ObservableCollection<Student>();

            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                Random rnd = new Random();

                students.Add(new Student("2020-"+idArr[rnd.Next(0, idArr.Length-1)]
                    , nameArr[rnd.Next(0, nameArr.Length-1)]
                    , majorArr[rnd.Next(0, majorArr.Length-1)]
                    , genderArr[rnd.Next(0, genderArr.Length-1)]
                    , gradeArr[rnd.Next(0, gradeArr.Length-1)]
                    , ageArr[rnd.Next(0, ageArr.Length-1)]
                    ));

                return true;
            });

            lv01.ItemsSource = students;
        }
    }
}