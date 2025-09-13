using Domain.Enums;

namespace Domain.Models
{
    public class SalesPerson : Employee
    {
        private double _SuccessSaleRevenue {  get; set; }

        public SalesPerson(string firstName, string lastName, double successSaleRevenue)
            :base(firstName, lastName, RoleEnum.Sales, 500)
        {
            _SuccessSaleRevenue = successSaleRevenue;
        }

        public void AddSuccessRevenue(double amount)
        {
            _SuccessSaleRevenue += amount;
        }

        public override double GetSalary()
        {
            if (_SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }else if(_SuccessSaleRevenue > 2000 &&  _SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }
        }
    }
}
