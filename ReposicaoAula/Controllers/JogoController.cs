using Microsoft.AspNetCore.Mvc;

namespace ReposicaoAula.Controllers
{
    public class JogoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
