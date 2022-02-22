using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ContSelf.Controllers
{
    public class TesteController : Controller
    {
        //
        // GET: /Funcionario/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /Funcionario/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}