using Domain.Models;

namespace Infrustructure.Services;

public class EmployeeService
{
    List<Employee> _employees = new List<Employee>();

    public List<Employee> GetEmployee()
    {
        return _employees;
    }
    public void CreateEmployee(Employee employee)
    {
        _employees.Add(employee);
    }
      public int CountEmployees()
    {
        return _employees.Count;
    }
}

