using Microsoft.AspNetCore.Mvc;

namespace CadastroFotos.DAO
{
    public class FotosDAO : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
