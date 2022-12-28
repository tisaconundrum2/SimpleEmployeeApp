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
            var entity = context.Employees.Find(Id);

            var emp = new EmployeeDTO()
            {
                firstName = entity.firstName,
                middleInitial = entity.middleInitial,
                lastName = entity.lastName,
                address = entity.address,
                dateOfBirth = entity.dateOfBirth.ToString("MM-dd-yyyy"),
                socialSecurityNumber = entity.socialSecurityNumber
            };
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(int Id, EmployeeDTO emp)
        {
            /*
             * The way this has been built definitely needs to be optimized and cleaned up
             * There is repeated code for the Entity portion, and we could be easily utilizing 
             * what already exists in the Employee Model to do that "Transfer" but for now
             * I'm foregoing this as it is causing more headache to resolve especially for a 
             * small non-production app that is simply being used for showcasing purposes.
             */
            if (!DateTime.TryParse(emp.dateOfBirth, out DateTime dateOfBirth))
            {
                ModelState.AddModelError("dateOfBirth", "Your date of birth is not a valid date, please check your date and try again.");
            }

            if (ModelState.IsValid)
            {
                var entity = context.Employees.Find(Id);

                if (entity != null)
                {
                    entity.firstName = emp.firstName;
                    entity.middleInitial = emp.middleInitial;
                    entity.lastName = emp.lastName;
                    entity.address = emp.address;
                    entity.dateOfBirth = DateTime.Parse(emp.dateOfBirth);
                    entity.socialSecurityNumber = emp.socialSecurityNumber;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            return View(emp);
        }
    }
}
