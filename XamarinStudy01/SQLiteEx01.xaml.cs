using SQLite;
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
    public partial class SQLiteEx01 : ContentPage
    {
        SQLiteAsyncConnection conn;
        ObservableCollection<ToDoItemClass> toDoItems = new ObservableCollection<ToDoItemClass>();

        public SQLiteEx01()
        {
            InitializeComponent();

            conn = DependencyService.Get<ISQLite>().GetConnection();
        }

        public ObservableCollection<ToDoItemClass> ToDoItems
        {
            get { return this.toDoItems; }
            set { this.toDoItems = value; }
        }

        /// <summary>
        /// 화면이 갱신될 때 호출되는 메서드
        /// </summary>
        protected override async void OnAppearing()
        {
            // 테이블이 없다면 생성한다.
            await conn.CreateTableAsync<ToDoItemClass>();

            var tds = await conn.Table<ToDoItemClass>().ToListAsync();

            this.toDoItems = new ObservableCollection<ToDoItemClass>(tds);

            lvToDoList.ItemsSource = this.toDoItems;

            base.OnAppearing();
        }

        private void btAddToDo_Clicked(object sender, EventArgs e)
        {
            var todo = new ToDoItemClass()
            {
                TimeTodo = DateTime.Now,
                Title = entryTitle.Text
            };

            conn.InsertAsync(todo);
            OnAppearing();

            entryTitle.Text = string.Empty;
        }

        private async void btMod_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            ToDoItemClass todoItem = (ToDoItemClass)(btn.BindingContext);

            todoItem.TimeTodo = DateTime.Now;

            int result = await conn.UpdateAsync(todoItem);

            if (result == 1)
            {
                await DisplayAlert("Modify", "수정되었습니다", "닫기");
                OnAppearing();
            }
            else
            {
                await DisplayAlert("Modify", "수정 실패", "닫기");
            }

        }

        private async void btDel_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            ToDoItemClass todoItem = (ToDoItemClass)(btn.BindingContext);

            Task<bool> result = this.DisplayAlert("Delete", "정말로 삭제하겠습니까?", "YES", "NO");

            if(await result)
            {
                await conn.DeleteAsync(todoItem);
                OnAppearing();
            }

        }

       
    }
}