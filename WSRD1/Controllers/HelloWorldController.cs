using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WSRD1.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
    }
}