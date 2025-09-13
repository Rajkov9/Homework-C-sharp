using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares {  get; set; }
        public double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, int shares, Employee[] employees)
            :base(firstName, lastName, RoleEnum.Other, salary)
        {
            Employees = employees;
            Shares = shares;
            SharesPrice = 0;
        }
        public void AddSharesPrice(double price)
        {
            if (price >= 0)
            {
                SharesPrice = price;
            }
        }
        public void PrintEmployees()
        {
            Console.WriteLine("Employees: ");
            foreach (var employee in Employees) 
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("CEO:");
            Console.WriteLine($"{FirstName} {LastName} gets salary: {GetSalary()}");
        }
    }
}
