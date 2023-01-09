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

        public IActionResult Editar(int id)
        {
           ContatoModel contato =_contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        
        public IActionResult RemoverConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Remover(int id)
        {
            _contatoRepositorio.Remover(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            _contatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");
        }
    }
}
