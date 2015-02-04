namespace CompanyHierarchy
{
    using System;
    public interface ISale
    {
        string ProductName { get; }
        DateTime Date { get; }
        decimal Price { get; }
    }
}
