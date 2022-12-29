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
        public IActionResult Add(EmployeeDTO dto)
        {
            if (!DateTime.TryParse(dto.dateOfBirth, out DateTime dateOfBirth))
            {
                ModelState.AddModelError("dateOfBirth", "Your date of birth is not a valid date, please check your date and try again.");
            }

            if (ModelState.IsValid)
            {
                var emp = new Employee();
                emp = emp.Transfer(dto, emp);
                
                context.Employees.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
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

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            EmployeeDTO dto = new EmployeeDTO();
            var emp = context.Employees.Find(Id);
            dto = emp.Transfer(emp, dto);
            return View(dto);
        }

        [HttpPost]
        public IActionResult Edit(int Id, EmployeeDTO dto)
        {
            if (!DateTime.TryParse(dto.dateOfBirth, out DateTime dateOfBirth))
            {
                ModelState.AddModelError("dateOfBirth", "Your date of birth is not a valid date, please check your date and try again.");
            }

            if (ModelState.IsValid)
            {
                var emp = context.Employees.Find(Id);

                if (emp != null)
                {
                    emp = emp.Transfer(dto, emp);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            return View(dto);
        }
    }
}
