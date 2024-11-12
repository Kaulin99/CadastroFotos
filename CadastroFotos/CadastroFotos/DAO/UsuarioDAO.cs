using CadastroFotos.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace CadastroFotos.DAO
{
    public class UsuarioDAO : PadraoDAO<UsuarioViewModel>
    {
        protected override SqlParameter[] CriaParametros(UsuarioViewModel enviar)
        {
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("Nome", enviar.Nome);
            parametros[1] = new SqlParameter("Login", enviar.Login);
            parametros[2] = new SqlParameter("Senha", enviar.Senha);

            return parametros;
        }

        protected override UsuarioViewModel MontaModel(DataRow registro)
        {
            UsuarioViewModel receber = new UsuarioViewModel();
            receber.Nome = Convert.ToString(registro["Nome"]);
            receber.Senha = Convert.ToString(registro["Senha"]);
            receber.Login = Convert.ToString(registro["Login"]);

            return receber;
        }

        protected override void SetTabela()
        {
            Tabela = "Usuarios";
            NomeSpListagem = "spListagemUsuarios";
        }
    }
}
