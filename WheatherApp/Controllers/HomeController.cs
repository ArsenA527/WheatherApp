using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WheatherApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}