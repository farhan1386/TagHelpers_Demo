using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TagHelpers_Demo.Data;

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

    }
}
