using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiagoFavarini40_3A1.Codigo.DAL;
using ThiagoFavarini40_3A1.Codigo.DTO;

namespace ThiagoFavarini40_3A1.Codigo.BLL
{
    class LoginBLL
    {
        BD conexao = new BD();
        string table = "conta";
        public bool RealizarLogin(LoginDTO loginDTO)
        {
            string sql = $"select * from {table} where conta_nome = '{loginDTO.Usuario}' and conta_senha = '{loginDTO.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

    }
}
