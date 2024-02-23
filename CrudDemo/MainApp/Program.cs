using Domain.Models;
using Infrustructure.Services;

var employee1 = new Employee();
employee1.FirstName = "Yusuf";
employee1.LastName = "Rahmon";
employee1.BirthDate = new DateTime(10/19/2021);
employee1.Salary = 5000;
employee1.Department = "Humo";
var employee2 = new Employee();
employee2.FirstName = "Muhammad";
employee2.LastName = "Rajabov";
employee2.BirthDate = new DateTime();
employee2.Salary = 9500;
employee2.Department = "Alif";

var emService = new EmployeeService();
emService.CreateEmployee(employee1);
emService.CreateEmployee(employee2);

//var groups = emService.GetGroups();
foreach (var item in emService.GetEmployee())
{
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.BirthDate);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine(item.Department);
    System.Console.WriteLine("-----------------------------------------");
}

System.Console.WriteLine($"We have {emService.CountEmployees()} employer \n----------------------------------");

var department1 = new Department();
department1.Name = "Marketing";
department1.Description = "Building brand awareness.";

var department2 = new Department();
department2.Name = "Production";
department2.Description = "Manufacturing the company's product.";

var depService = new DepartmentService();
depService.AddDepartment(department1);
depService.AddDepartment(department2);

foreach (var item in depService.GetDepartments())
{
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine("--------------------------------");
}

System.Console.WriteLine($"We have {depService.CountDepartments()} department");