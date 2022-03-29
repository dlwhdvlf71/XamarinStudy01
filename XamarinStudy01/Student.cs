using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinStudy01
{
    public class Student
    {
        string id, name, major;
        char gender;
        int grade, age;

        public Student(string id, string name, string major, char gender, int grade, int age)
        {
            this.Id = id; this.Name = name; this.Major = major; this.Gender = gender; this.Age = age; this.Grade = grade; 
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Major
        {
            get
            {
                return major;
            }

            set
            {
                major = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public int Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

    }
}
