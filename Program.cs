// See https://aka.ms/new-console-template for more information


using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    id = 1010,
    FirstName = "Sandra",
    LastName = "morares",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M

};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmpoyee()
{
    id = 1010,
    FirstName = "Carlos",
    LastName = "Martinez",
    BirthDate = new Date(1997, 3, 13),
    HiringDate = new Date(2021, 4, 24),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};
//Console.WriteLine(employee2);
 
Employee employee3 = new HourlyEmployee()
{
    id = 3030,
    FirstName = "Carlos",
    LastName = "Martinez",
    BirthDate = new Date(1997, 3, 13),
    HiringDate = new Date(2021, 4, 24),
    IsActive = true,
    HourValue = 12345.54M,
    Hours = 123.3F
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    id = 3030,
    FirstName = "mario",
    LastName = "corrales",
    BirthDate = new Date(1997, 3, 13),
    HiringDate = new Date(2021, 4, 24),
    IsActive = true,
    Base= 823574.45M,
    Sales = 58000000M,
    CommissionPercentaje =0.015F

};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4


};
decimal payroll = 0;
foreach (Employee employee in employees) 
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                             =====================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "Iphone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6

};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F

};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
