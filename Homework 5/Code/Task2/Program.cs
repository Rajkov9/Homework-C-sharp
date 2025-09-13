using Domain.Models;

Manager manager1 = new Manager("Bob","Bobski",1000);
Manager manager2 = new Manager("Petko", "Petkovski", 1000);
Contractor contractor1 = new Contractor("Ana", "Adamovska", 40 ,20, manager1);
Contractor contractor2 = new Contractor("Sara", "Spirovska", 40, 20, manager2);
SalesPerson salesPerson = new SalesPerson("Lea", "Asprova",0);
salesPerson.AddSuccessRevenue(5000);

Employee[] company = new Employee[]
{
    contractor1 ,
    contractor2 ,
    manager1,
    manager2,
    salesPerson
};

CEO ceoName = new CEO("Jovan", "Jovanovski", 1500, 70, company);
ceoName.AddSharesPrice(20);

ceoName.PrintInfo();
ceoName.PrintEmployees();
ceoName.GetSalary();