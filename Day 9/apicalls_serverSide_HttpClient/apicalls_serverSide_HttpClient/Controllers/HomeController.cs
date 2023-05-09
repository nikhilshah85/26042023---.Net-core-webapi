using apicalls_serverSide_HttpClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace apicalls_serverSide_HttpClient.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult ShowComments()
        {
            CommentsModel modelObj = new CommentsModel();
            ViewBag.data = modelObj.getComments(); // this will make a HttpClient call and get the data
            return View();
        }
    }
}













