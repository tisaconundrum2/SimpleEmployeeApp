using Microsoft.AspNetCore.Mvc;
using SimpleEmployeeApp.Models.DataLayer;
using SimpleEmployeeApp.Models.DomainModels;

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
        public IActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
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
