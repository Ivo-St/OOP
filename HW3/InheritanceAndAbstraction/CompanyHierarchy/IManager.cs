namespace CompanyHierarchy
{
    using System.Collections.Generic;
    public interface IManager
    {
        List<Employee> Employees { get; }
    }
}
