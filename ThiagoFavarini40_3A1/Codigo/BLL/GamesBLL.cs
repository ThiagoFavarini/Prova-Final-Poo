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
    class GamesBLL
    {
        BD conexao = new BD();
        string table = "Jogos";


        public void Inserir(GamesDTO gamesDTO)
        {
            string inserir = $"insert into {table} value (null, '{gamesDTO.Jogos}', '{gamesDTO.Valor}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(GamesDTO gamesDTO)
        {
            string alterar = $"update {table} set jogos = '{gamesDTO.Jogos}', valor = '{gamesDTO.Valor}'," +
                $" where code = '{gamesDTO.Code}'";
            conexao.ExecutarComando(alterar);
        }

        public void Exclui(GamesDTO gamesDTO)
        {
            string excluir = $"delete from {table} where code = '{gamesDTO.Code}'";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {table} order by code;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
