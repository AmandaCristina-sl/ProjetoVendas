using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProjetoVenda.controle
{
    internal static class Sessao
    {
        // o "?" significa que ele poderá receber um usuário ou um campo vazio.
        public static Funcionario? usuarioAutenticado;   
       
    }
}
