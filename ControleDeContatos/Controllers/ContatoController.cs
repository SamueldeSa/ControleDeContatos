using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {

        private readonly IContatoRepositorio _contatoRepositorio;

        //injetar
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }


        public IActionResult Index()
        {


            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult RemoverConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }


    }
}
