namespace HumanStudentWorker
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    class ProjectMain
    {
        static void Main(string[] args)
        {
            CreateAndSortStudents();
            Console.WriteLine();
            CreateAndSortWorkers();
            Console.WriteLine();
            MergeWorkersAndStudents();
        }

        static void CreateAndSortStudents()
        {
            Student ivo = new Student("Ivo", "Petkov", "A456667");
            Student gosho = new Student("Gosho", "Ivanov", "A12451");
            Student pesho = new Student("Pesho", "Bychvarov", "A12347");
            Student kiro = new Student("Kiro", "Kaloyanov", "A9987");
            Student miro = new Student("Miro", "Georgiev", "A23457");
            Student ivan = new Student("ivan", "ivanov", "A145687");
            Student mihail = new Student("mihail", "petrov", "B147415");
            Student ganka = new Student("ganka", "gancheva", "20146547");
            Student doncho = new Student("doncho", "donchev", "A0145612");
            Student misho = new Student("misho", "mishev", "A0142589");


            List<Student> students = new List<Student>() 
            {
                ivo,
                gosho,
                pesho,
                kiro,
                mihail,
                miro,
                ivan,
                misho,
                ganka,
                doncho
            };

            var sortedStudents = students.OrderBy(st => st.FacultyNumber);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }

        static void CreateAndSortWorkers()
        {
            Worker kosta = new Worker("kosta", "kostadinov", 282m, 8);
            Worker sancho = new Worker("sancho", "pansa", 382m, 6.5);
            Worker penka = new Worker("penka", "kostadinova", 243m, 4.75);
            Worker dimitrichka = new Worker("dimitrichka", "doynova", 152m, 2.75);
            Worker darina = new Worker("darina", "stamatova", 182m, 5.5);
            Worker zlatomir = new Worker("zlatomir", "zlatev", 242m, 7.5);
            Worker petar = new Worker("petar", "donchev", 482m, 6);
            Worker pencho = new Worker("pencho", "kubadinski", 578m, 9);
            Worker marko = new Worker("marko", "totev", 439m, 8);
            Worker kostadin = new Worker("kostadin", "haralambov", 658m, 9);

            List<Worker> listWorker = new List<Worker>(){ kosta, sancho, penka, dimitrichka, darina, zlatomir, petar, pencho, marko, kostadin};

            var sortedListWorkers = listWorker.OrderByDescending(x => x.MoneyPerHour());

            foreach (var worker in sortedListWorkers)
            {
                Console.WriteLine(worker);
            }
        }

        static void MergeWorkersAndStudents()
        {
            Student ivo = new Student("Ivo", "Petkov", "A456667");
            Student gosho = new Student("Gosho", "Ivanov", "A12451");
            Student pesho = new Student("Pesho", "Bychvarov", "A12347");
            Student kiro = new Student("Kiro", "Kaloyanov", "A9987");
            Student miro = new Student("Miro", "Georgiev", "A23457");
            Student ivan = new Student("ivan", "ivanov", "A145687");
            Student mihail = new Student("mihail", "petrov", "B147415");
            Student ganka = new Student("ganka", "gancheva", "20146547");
            Student doncho = new Student("doncho", "donchev", "A0145612");
            Student misho = new Student("misho", "mishev", "A0142589");
            List<Student> students = new List<Student>() 
            {
                ivo,
                gosho,
                pesho,
                kiro,
                mihail,
                miro,
                ivan,
                misho,
                ganka,
                doncho
            };

            Worker kosta = new Worker("kosta", "kostadinov", 282m, 8);
            Worker sancho = new Worker("sancho", "pansa", 382m, 6.5);
            Worker penka = new Worker("penka", "kostadinova", 243m, 4.75);
            Worker dimitrichka = new Worker("dimitrichka", "doynova", 152m, 2.75);
            Worker darina = new Worker("darina", "stamatova", 182m, 5.5);
            Worker zlatomir = new Worker("zlatomir", "zlatev", 242m, 7.5);
            Worker petar = new Worker("petar", "donchev", 482m, 6);
            Worker pencho = new Worker("pencho", "kubadinski", 578m, 9);
            Worker marko = new Worker("marko", "totev", 439m, 8);
            Worker kostadin = new Worker("kostadin", "haralambov", 658m, 9);
            List<Worker> listWorker = new List<Worker>() { kosta, sancho, penka, dimitrichka, darina, zlatomir, petar, pencho, marko, kostadin };

            List<Human> listHumans = new List<Human>();
            listHumans.AddRange(students);
            listHumans.AddRange(listWorker);

            var sortedList = listHumans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach(var human in sortedList)
            {
                Console.WriteLine(human);
            }
        }
    }
}
