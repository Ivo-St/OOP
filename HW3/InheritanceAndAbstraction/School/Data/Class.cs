namespace School.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Class
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string id;

        public Class(List<Teacher> teachers, List<Student> students, string id, string details = null)
        {
            this.Teachers = teachers;
            this.Students = students;
            this.Id = id;
            this.Details = details;
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Class must have atleast one teacher");
                }
                this.teachers = value;
            }
        }
        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Class must have atleast one student");
                }
                this.students = value;
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Class id cannot be null or empty");
                }
                this.id = value;
            }
        }
        public string Details { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.Id);
            result.AppendLine("Teachers:");
            foreach (var teacher in this.Teachers)
            {
                result.AppendLine(teacher.ToString());
            }
            result.AppendLine("Students:");
            foreach (var student in this.Students)
            {
                result.AppendLine(student.ToString());
            }
            if (!string.IsNullOrWhiteSpace(this.Details))
            {
                result.AppendLine(this.Details);
            }
            return result.ToString();
        }
    }
}
