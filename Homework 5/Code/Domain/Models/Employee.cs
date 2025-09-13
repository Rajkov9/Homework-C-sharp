using Domain.Enums;

namespace Domain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public RoleEnum Role { get; set; }
        protected double Salary { get; set; }   

        public Employee() { }

        public Employee(string firstName, string lastName, RoleEnum role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} gets salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
