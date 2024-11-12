using Microsoft.AspNetCore.Http;
using System;

namespace CadastroFotos.Models
{
    public class UsuarioViewModel : PadraoViewModel
    {
       public string Nome { get; set; }
       public string Login { get; set;}
       public string Senha { get; set;}
    }
}
