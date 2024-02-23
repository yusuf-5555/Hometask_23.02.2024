using Microsoft.VisualBasic;

namespace Domain.Models;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
}