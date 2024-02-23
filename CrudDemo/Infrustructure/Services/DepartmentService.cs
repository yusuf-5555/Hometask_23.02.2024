using Domain.Models;
namespace Infrustructure.Services;

public class DepartmentService
{
    List<Department> _department = new List<Department>();
    public List<Department> GetDepartments()
    {
        return _department;
    }
    public void AddDepartment(Department department)
    {
        _department.Add(department);
    }

    public int CountDepartments()
    {
        return _department.Count;
    }
}