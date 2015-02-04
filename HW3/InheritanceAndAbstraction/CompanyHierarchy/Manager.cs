namespace CompanyHierarchy
{
    using System.Collections.Generic;
    using System.Text;
    public class Manager : Employee, IManager
    {
        public Manager(string id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            foreach(var employee in this.Employees)
            {
                result.AppendLine(" " + employee.ToString());
            }
            return result.ToString();
        }
    }
}
