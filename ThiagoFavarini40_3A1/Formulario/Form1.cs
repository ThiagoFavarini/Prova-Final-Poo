using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiagoFavarini40_3A1.Codigo.BLL;
using ThiagoFavarini40_3A1.Codigo.DTO;
    

namespace ThiagoFavarini40_3A1
{
    public partial class Form1 : Form
    {

        GamesDTO gamesDTO = new GamesDTO();
        GamesBLL gamesBLL = new GamesBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            gamesDTO.Jogos = txt_jogos.Text;
            gamesDTO.Valor = double.Parse(txt_valor.Text);

            gamesBLL.Inserir(gamesDTO);
            MessageBox.Show("Feito!");
            gamesBLL.Listar();

        }

        private void btn_mudar_Click(object sender, EventArgs e)
        {
            gamesDTO.Code = int.Parse(txt_code.Text);
            gamesDTO.Jogos = txt_jogos.Text;
            gamesDTO.Valor = double.Parse(txt_valor.Text);

            gamesBLL.Editar(gamesDTO);
            MessageBox.Show("Feito!");
            gamesBLL.Listar();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            gamesDTO.Code = int.Parse(txt_code.Text);
            gamesBLL.Exclui(gamesDTO);
            MessageBox.Show("Feito!");
            gamesBLL.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DTG_jogos.DataSource = gamesBLL.Listar();
        }
    }
}
