namespace CompanyHierarchy
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Developer : Employee, IDeveloper
    {
        public Developer(string id, string firstName, string lastName, decimal salary, List<Project> projects)
            : base(id, firstName, lastName, salary, Department.Production)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            foreach (var project in this.Projects)
            {
                result.AppendLine(" "+project.ToString());
            }
            return result.ToString();
        }
    }
}
