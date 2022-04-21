using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinStudy01.Class
{
    [Table("user")]
    public class User
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public int Id { get; set; }
        [MaxLength(30), NotNull]
        public string UserName { get; set; }
    }
}
