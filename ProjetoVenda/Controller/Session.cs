using ProjetoVenda.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProjetoVenda.Controller
{
    internal static class Session
    {
        // o "?" significa que ele poderá receber um usuário ou um campo vazio.
        public static Employee? userAuth;
        public static bool isMaster = false;
       
           
       
    }
}
