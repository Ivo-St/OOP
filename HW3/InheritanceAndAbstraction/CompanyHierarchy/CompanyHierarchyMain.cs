namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    class CompanyHierarchyMain
    {
        static void Main()
        {
            SalesEmployee saleEmployee = new SalesEmployee("ghgfdsa", "First", "Employee", 900m, new List<Sale>
                    {
                        new Sale("Some product", 140m),
                        new Sale("Some other product", 199.99m)
                    });
            Developer test = new Developer("A442", "Test", "Developer", 3000m, new List<Project>() { new Project("Test Project", "test") });
            Manager manager1 = new Manager("01asdf", "First", "Manager", 1350m, Department.Accounting, new List<Employee>
            {
                saleEmployee,
                new Developer("01", "First", "Developer", 1000m, new List<Project>
                    {
                        new Project("Some project", "random details about the project"),
                        new Project("Some other project","random details about the project")
                    })
            });

            test.Projects[0].CloseProject();

            List<Person> testList = new List<Person>()
            {
                saleEmployee,
                test,
                manager1
            };

            foreach (var person in testList)
            {
                Console.WriteLine(person);
            }
        }
    }
}
