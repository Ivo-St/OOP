namespace CompanyHierarchy
{
    public interface IEmployee
    {
        decimal Salary { get; }
        Department Department { get; }
    }
}
