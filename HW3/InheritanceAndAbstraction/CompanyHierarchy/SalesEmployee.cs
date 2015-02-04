namespace CompanyHierarchy
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class SalesEmployee : Employee, ISalesEmployee
    {
        public SalesEmployee(string id, string firstName, string lastName, decimal salary, List<Sale> sales)
            :base(id,firstName,lastName,salary,Department.Sales)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            foreach (var sale in this.Sales)
            {
                result.AppendLine(" " + sale.ToString());
            }
            return result.ToString();
        }
    }
}
