using ControleDeContatos.Models;
using System;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {

        UsuarioModel BuscarPorLogin(string login);

        UsuarioModel BuscarEmailELogin(string email, string Login);

        UsuarioModel ListarPorId(int id);

        List<UsuarioModel> BuscarTodos();

        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel Atualizar(UsuarioModel usuario);

        bool Remover(int id);


    }
}
