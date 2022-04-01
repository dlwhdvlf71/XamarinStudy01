using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinStudy01
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection();
    }
}
