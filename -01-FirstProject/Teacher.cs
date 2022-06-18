using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstProject
{
    public class Teacher
    {
        private int Id { get; set; }
        private string TeacherName { get; set; }
        private string Bio { get; set; }

        public Teacher(int id,string teacherName,string bio)
        {
            this.Id = id;
            this.TeacherName = teacherName;
            this.Bio = bio;
        }
        public string getDetails(Teacher teacher)
        {
            return "Teacher Number: " + teacher.Id + "\nTeacher Name: " +TeacherName + "\nBio: " + teacher.Bio + "\n*************";
        }
    }
}
