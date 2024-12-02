using HW_ASP_8._2.Models;
using System.Collections.Generic;
using System.Linq;

namespace HW_ASP_8._2
{
    public class EmployeeService
    {
        private readonly List<Employee> _employees = new()
    {
        new Employee { Id = 1, FullName = "Alice Johnson", Salary = 50000 },
        new Employee { Id = 2, FullName = "Bob Smith", Salary = 45000 },
        new Employee { Id = 3, FullName = "Charlie Brown", Salary = 60000 }
    };

        public IEnumerable<Employee> GetEmployees() => _employees;

        public void UpdateSalary(int id, decimal newSalary)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employee.Salary = newSalary;
            }
        }
    }
}
