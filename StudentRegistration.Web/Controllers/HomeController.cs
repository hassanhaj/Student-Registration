using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentRegistration.Web.Models;
using System.Diagnostics;

namespace StudentRegistration.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return CustomView("<html><body><h1>Hello World</h1><p>Some text</p></body></html>");
        }

        private ContentResult CustomView(string modelData)
        {
            var result = new ContentResult
            {
                Content = modelData,
                ContentType = "text/html",
            };
            return result;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
