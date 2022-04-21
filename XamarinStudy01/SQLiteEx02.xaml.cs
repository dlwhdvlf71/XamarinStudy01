﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Xamarin.Essentials;
using XamarinStudy01.Class;

namespace XamarinStudy01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLiteEx02 : ContentPage
    {
        

        public SQLiteEx02()
        {
            InitializeComponent();

            /*  
             *  라이브러리 폴더 위치에 엑스스 할 수 있다.
             *  iOS 또는 Android에서 실행되는지 여부와 관계없이 libFolder에는 SQLite 데이터베이스와 같은 애플리케이션 생성 데이터에 대한 적절한 libFolder 위치가 포함된다.
             *  */
            var libFolder = FileSystem.AppDataDirectory;

            // SQLite 사용하여 로컬에 데이터 저장

            /*
             * SQLiteConnection 개체를 통해 SQLite 데이터베이스에 대한 연결을 설정한다.
             * 인스턴스화 할 때 데이터베이스 파일의 이름을 전달해야 한다.
             * 그러면 파일이 있는 경우 파일을 열고 없으면 파일을 만든다.
             * */

            SQLiteConnection connection = new SQLiteConnection(libFolder + "SQLite");

            User user = new User();

            connection.CreateTable<User>();

        }
    }
}