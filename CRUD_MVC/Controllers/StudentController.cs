using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
