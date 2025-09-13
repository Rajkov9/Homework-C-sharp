using Domain.Enums;

namespace Domain.Models
{
    public class Manager : Employee
    {
        private double _Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary)
            : base(firstName, lastName, RoleEnum.Manager, salary)
        {
            _Bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            if (bonus >= 0)
                _Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _Bonus;
        }
    }
}
