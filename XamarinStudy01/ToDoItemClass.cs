using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinStudy01
{
    [Table("ToDoItems")]
    public class ToDoItemClass
    {
        [PrimaryKey, AutoIncrement, Column("ToDoItemId")]
        public int Id { get; set; }
        public DateTime TimeTodo { get; set; }
        public string Title { get; set; }
    }
}
