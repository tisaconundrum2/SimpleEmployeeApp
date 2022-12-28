using Microsoft.AspNetCore.Mvc;
using SimpleEmployeeApp.Models.DataLayer;
using SimpleEmployeeApp.Models.DomainModels;
using SimpleEmployeeApp.Models.DTOs;

namespace SimpleEmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext context;

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
            if (!DateTime.TryParse(emp.dateOfBirth, out DateTime dateOfBirth))
            {
                ModelState.AddModelError("dateOfBirth", "Your date of birth is not a valid date, please check your date and try again.");
            }

            if (ModelState.IsValid)
            {
                context.Employees.Add(new Employee(emp));
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var entity = context.Employees.Find(Id);
            if (entity != null)
            {
                context.Employees.Remove(entity);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
