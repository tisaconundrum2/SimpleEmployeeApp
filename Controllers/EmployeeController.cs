using Microsoft.AspNetCore.Mvc;
using SimpleEmployeeApp.Models.DataLayer;
using SimpleEmployeeApp.Models.DomainModels;
using SimpleEmployeeApp.Models.DTOs;

namespace SimpleEmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext context;

        // public EmployeeController(EmployeeContext ctx) => context = ctx;
        public EmployeeController(EmployeeContext context) => this.context = context;
        public IActionResult Index()
        {
            IQueryable<Employee> query = context.Employees.OrderBy(m => m.Id);
            return View(query.ToList());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(EmployeeDTO emp)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(new Employee(emp));
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
