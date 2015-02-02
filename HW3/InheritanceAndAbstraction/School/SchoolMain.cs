namespace School
{
    using System;
    using System.Collections.Generic;
    using Data;
    public class SchoolMain
    {
        static void Main()
        {
            Student st = new Student("Ivo", "A49", "Test student");
            List<Student> listStudent = new List<Student>(){st};
            Discipline dis = new Discipline("DIS", 30, listStudent);
            List<Discipline> listDiscipline = new List<Discipline>(){dis};
            Teacher th = new Teacher("Spiridon", listDiscipline);
            List<Teacher> listTeacher = new List<Teacher>(){th};
            Class testClass = new Class(listTeacher, listStudent, "A1");
            Console.WriteLine(testClass);
        }
    }
}
