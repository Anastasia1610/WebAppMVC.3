using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC._3.Models;

namespace WebAppMVC._3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(int n1, int n2, int n3)
        {
            List<int> l = new List<int> { n1, n2, n3 };
            int num = 1;
          
            for (int i = 1; i <= l.Min(); i++)
               if(n1%i==0 && n2 % i == 0 && n3 % i == 0)
                    num = i;

            return View(num);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}