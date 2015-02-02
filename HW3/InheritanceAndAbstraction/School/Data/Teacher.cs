namespace School.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines, string details=null)
            :base(name,details)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Teacher cannot have zero disciplines");
                }
                this.disciplines = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Disciplines:");
            foreach (var discipline in this.Disciplines)
            {
                result.AppendLine(discipline.ToString());
            }
            return result.ToString();
        }
    }
}
