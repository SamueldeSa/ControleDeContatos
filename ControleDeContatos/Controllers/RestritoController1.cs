using ControleDeContatos.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    [PaginaUsuarioLogado]
    public class RestritoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
