namespace CompanyHierarchy
{
    using System;

    public interface IProject
    {
        string ProjectName { get; }
        DateTime ProjectStartDate { get; }
        string Details { get; }
        State State { get; }
        void CloseProject();
    }
}
