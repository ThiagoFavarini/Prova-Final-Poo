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


namespace ThiagoFavarini40_3A1.Formulario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        LoginDTO entrarDTO = new LoginDTO();
        LoginBLL entrarBLL = new LoginBLL();

      

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            entrarDTO.Usuario = txt_usuario.Text;
            entrarDTO.Senha = txt_senha.Text;

            if (entrarBLL.RealizarLogin(entrarDTO) == true)
            {
                Form1 frmEPA = new Form1();
                frmEPA.ShowDialog();
            }



        }
    }
}
