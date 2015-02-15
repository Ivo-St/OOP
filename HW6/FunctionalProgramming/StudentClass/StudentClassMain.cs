namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StudentClassMain
    {
        static void Main()
        {
            Student student1 = new Student("Pesho", "Markov", 19, 445014, 2, "+35988765", "peshoM@email.jg", new List<int> { 4, 2, 6, 2, 5 });
            Student student2 = new Student("Ivan", "Kolev", 23, 445014, 3, "+35980962", "ivanK@email.jg", new List<int> { 4, 4, 3, 3, 6 });
            Student student3 = new Student("Dragan", "Peshov", 17, 445013, 5, "+359 281261", "draganP@email.jg", new List<int> { 2, 5, 2, 3, 5 });
            Student student4 = new Student("Peshka", "Nikolova", 28, 445012, 1, "+359288237", "peshkaN@email.jg", new List<int> { 5, 5, 6, 6, 5 });
            Student student5 = new Student("Pesho", "Ivanov", 24, 445011, 2, "0273565", "peshoI@abv.bg", new List<int> { 3, 5, 5, 3, 5 });

            List<Student> students = new List<Student> { student1, student2, student3, student4, student5 };

            //Problem 04
            var studentsByGroup = from student in students
                                  where student.GroupNumber == 2
                                  orderby student.FirstName
                                  select student;

            foreach (var student in studentsByGroup)
            {
                Console.WriteLine("{0}\n", student);
            }

            Console.WriteLine("-------------------------End of Problem 04--------------------------------------");

            //Problem 05
            var studentsByName = from student in students
                                 where student.FirstName.CompareTo(student.LastName) < 0
                                 select student;

            foreach (var x in studentsByName)
            {
                Console.WriteLine("{0}\n", x);
            }

            Console.WriteLine("-------------------------End of Problem 05--------------------------------------");

            //Problem 06
            var studentsByAge = from student in students
                                where student.Age >= 18 && student.Age <= 24
                                select new { FirstName = student.FirstName, LastName = student.LastName, Age = student.Age };

            foreach (var student in studentsByAge)
            {
                Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\n", student.FirstName, student.LastName, student.Age);
            }

            Console.WriteLine("-------------------------End of Problem 06--------------------------------------");

            var studentsByFirstAndLastName = students.OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName);

            foreach (var x in studentsByFirstAndLastName)
            {
                Console.WriteLine("{0}\n", x);
            }

            Console.WriteLine("//////////////////////The same with Linq//////////////////////\n");

            var studentsByFirstAndLastNameLinq = from student in students
                                                 orderby student.FirstName descending, student.LastName descending
                                                 select student;
            foreach (var x in studentsByFirstAndLastNameLinq)
            {
                Console.WriteLine("{0}\n", x);
            }

            Console.WriteLine("-------------------------End of Problem 07--------------------------------------");

            var studentsByEmail = from student in students
                                  where student.Email.EndsWith("@abv.bg")
                                  select student;

            foreach (var x in studentsByEmail)
            {
                Console.WriteLine("{0}\n", x);
            }

            Console.WriteLine("-------------------------End of Problem 08--------------------------------------");

            var studentsByPhone = from student in students
                                  where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") ||
                                  student.Phone.StartsWith("+359 2")
                                  select student;

            foreach (var x in studentsByPhone)
            {
                Console.WriteLine("{0}\n",x);
            }

            Console.WriteLine("-------------------------End of Problem 09--------------------------------------");

            var fullnameAndMarks = from student in students
                                   select new { Fullname = student.FirstName + " " + student.LastName, Marks = student.Marks };

            var excellentSudents = from student in fullnameAndMarks
                                   where student.Marks.Contains(6)
                                   select student;

            foreach (var x in excellentSudents)
            {
                Console.WriteLine("{0}\n", x.Fullname);
            }

            Console.WriteLine("-------------------------End of Problem 10--------------------------------------");

            var weakStudents = fullnameAndMarks.Where(x => x.Marks.Count(y => y == 2) == 2);

            foreach (var x in weakStudents)
            {
                Console.WriteLine("{0}\n", x.Fullname);
            }

            Console.WriteLine("-------------------------End of Problem 11--------------------------------------");

            var studentsByFacultyId = from student in students
                                      where student.FacultyNumber % 100 == 14
                                      select student;


            foreach (var x in studentsByFacultyId)
            {
                Console.WriteLine("{0}\n", x);
            }

            Console.WriteLine("-------------------------End of Problem 12--------------------------------------");

        }
    }
}
