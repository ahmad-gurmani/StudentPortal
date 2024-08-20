using Microsoft.AspNetCore.Mvc;

namespace StudentPortal.Web.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
