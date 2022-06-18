using System;
using System.Collections.Generic;

namespace _01_FirstProject
{
    internal class Program
    {

        public static List<Teacher> teachers=new List<Teacher>();
        public static List<Student> students=new List<Student>();
        static void Main(string[] args)
        {
            var newClassroom=new Classroom();
            newClassroom.Id = "A1";
            newClassroom.Name = "ASP.NET";
            

            var newTeacher = new Teacher(1, "Osama Khalil", "Master of Programming");
            Console.WriteLine(newTeacher.getDetails(newTeacher));
            teachers.Add(newTeacher);

            var newStudent = new Student(120220001,"Ahmed Hamed",18);
            Console.WriteLine(newStudent.getDetails(newStudent));
            students.Add(newStudent);

            var newStudent2 = new Student(120220002, "Emad Kamil", 18);
            Console.WriteLine(newStudent2.getDetails(newStudent2));
            students.Add(newStudent2);

            var newStudent3 = new Student(120220003, "Sameeh Hamdan", 18);
            Console.WriteLine(newStudent3.getDetails(newStudent3));
            students.Add(newStudent3);

            newClassroom.teachers = teachers;
            newClassroom.students=students;
            Console.WriteLine(newClassroom.GetDetailsForClassroom(newClassroom));

        }
    }
}
