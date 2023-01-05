using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public  IActionResult Editar()
        {
            return View();
        }

        public IActionResult RemoverConfirmacao()
        {
            return View();
        }
    }
}
