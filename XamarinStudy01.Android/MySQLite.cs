using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinStudy01.Droid;

[assembly: Dependency(typeof(MySQLite))]
namespace XamarinStudy01.Droid
{
    public class MySQLite : ISQLite
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documents, "MySQLite.db");           

            return new SQLiteAsyncConnection(path);
        }
    }
}