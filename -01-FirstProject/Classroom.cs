using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstProject
{
    public class Classroom
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public List<Teacher>teachers { get; set; }
        public List<Student> students { get; set; }

        //Teacher
        private Teacher Teacher { get; set; }

        //Student
        private Student Student { get; set; }


        public void AddNewTeacherToClassroom(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddNewStudentToClassroom(Student student)
        {
            students.Add(student);
        }
        public string GetDetailsForClassroom(Classroom cr)
        {
            string teachersD = "";
            foreach(Teacher teacher in teachers)
            {
                teachersD+= teacher.getDetails(teacher)+"\n";
            }
            string studentsD = "";
            foreach (Student student in students)
            {
                studentsD += student.getDetails(student) + "\n";
            }
            return "---------\nID: "+cr.Id + "\nName: " + cr.Name + "\nTeacher/s:\n" + teachersD+"\nStudents:\n"+studentsD + "\n----------";
        }

        
    }

}
