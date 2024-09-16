using Microsoft.AspNetCore.Mvc;

namespace ReposicaoAula.Controllers
{
    public class VideogameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
