using First_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_App.Controllers
{
    //localhost yazarsam               home/index
    //localhost/home yazarsam          home/index
    //localhost/home/index yazarsam    home/index   gelecek sebebi controller ve action metodu olarak aynı metodu çağırırlar
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View(Repository.Courses);
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
