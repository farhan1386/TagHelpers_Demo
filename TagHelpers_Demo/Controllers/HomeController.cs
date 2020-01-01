using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using TagHelpers_Demo.Data;
using TagHelpers_Demo.Models;

namespace TagHelpers_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Id"] = new SelectList(dbContext.Departments, "Id", "DepartmentName");
            return View();
        }

        public IActionResult GenderAndDepartment()
        {
            var model = new Employee();
            model.Departments.ToList();
            return View(model);

        }
    }
}
