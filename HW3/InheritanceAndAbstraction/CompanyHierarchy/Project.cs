namespace CompanyHierarchy
{
    using System;
    public class Project : IProject
    {
        private string projectName;
        private string details;

        public Project(string projectName, string details)
        {
            this.ProjectName = projectName;
            this.Details = details;
            this.ProjectStartDate = DateTime.Now;
            this.State = State.Open;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Project name cannot be null or empty");
                }
                this.projectName=value;
            }
        }

        public DateTime ProjectStartDate { get; private set; }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Details cannot be null or empty");
                }
                this.details = value;
            }
        }

        public State State { get; private set; }

        public void CloseProject()
        {
            this.State = State.Closed;
        }

        public override string ToString()
        {
            return this.ProjectName + " " + this.Details + " " + this.ProjectStartDate + " " + this.State;
        }
    }
}
