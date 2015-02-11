namespace StudentClass
{
    using System;
    public class TestStudentClass
    {
        static void Main()
        {
            Student testStudent = new Student("Pesho", 21);

            testStudent.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
            };

            testStudent.Name = "Gosho";

        }
    }
}
