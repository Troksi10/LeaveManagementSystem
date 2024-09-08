using LeaveManSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC",
                DateOfBirth = new DateTime(1975,05,05)
            };
            return View(data);
        }
    }
}
