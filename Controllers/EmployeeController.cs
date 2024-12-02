using HW_ASP_8._2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP_8._2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employeeService.GetEmployees();
            return View(employees);
        }

        [HttpPost]
        public IActionResult UpdateSalaries(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                _employeeService.UpdateSalary(employee.Id, employee.Salary);
            }
            return RedirectToAction("Index");
        }
    }
}
