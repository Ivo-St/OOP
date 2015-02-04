namespace HumanStudentWorker
{
    using System;
    class Student : Human
    {
        private string facultyNumber;

        public Student(string name, string lastName, string facultyNumber)
            :base(name,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentNullException("Faculty number cannot be null or empty");
                }
                if(value.Length<5 || value.Length>10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number cannot be less then 5 or greater then 10 digits ");
                }
                this.facultyNumber=value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.FacultyNumber;
        }
    }
}
