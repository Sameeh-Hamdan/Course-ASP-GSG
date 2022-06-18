using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstProject
{
    public class Student
    {
        private string Id { get; set; }
        private string StudentName { get; set; }
        private int Age { get; set; }

        public Student(int id,string stdName,int age)
        {
            this.Id= id+"";
            this.StudentName= stdName;
            this.Age= age;
        }

        public string getDetails(Student std)
        {
            return "Student Number: "+std.Id+"\nStudent Name: "+std.StudentName+"\nAge: "+std.Age+"\n*************";
        }

    }
}
