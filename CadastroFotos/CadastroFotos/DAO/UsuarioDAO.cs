using Microsoft.AspNetCore.Mvc;

namespace CadastroFotos.DAO
{
    public class UsuarioDAO : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
