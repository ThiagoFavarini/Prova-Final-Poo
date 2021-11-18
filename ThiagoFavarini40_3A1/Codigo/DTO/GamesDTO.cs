using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiagoFavarini40_3A1.Codigo.DTO
{
    class GamesDTO
    {
        private int _code;
        private string _jogos;
        private double _valor;

        public int Code { get => _code; set => _code = value; }
        public string Jogos { get => _jogos; set => _jogos = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}
