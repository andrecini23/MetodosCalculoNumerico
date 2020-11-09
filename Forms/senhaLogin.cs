using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trabalho_Marcio
{

    public partial class senhaLogin : Form
    {
        public senhaLogin()
        {
            InitializeComponent();

        }

        private void btnConectar_Click(object sender, EventArgs ve)
        {

            Boolean temErro = false;
            errorProvider1.Clear();


            if (txtLogin.Text.Length == 0)
            {
                errorProvider1.SetError(txtLogin, "Preencha todos os campos!");
                temErro = true;
            }

            if (txtSenha.Text.Length == 0)
            {
                errorProvider1.SetError(txtSenha, "Preencha todos os campos!");
                temErro = true;
            }

            if (txtLogin.Text == "Admin" && txtSenha.Text == "12345")
            {
                MessageBox.Show("Bem Vindo ao nosso Trabalho!");

                Tutorial tela = new Tutorial();
                this.Hide();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
                txtLogin.Text = txtSenha.Text = "";
            }


        }

       
        private void txtLogin_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConectar.PerformClick();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConectar.PerformClick();
            }
        }
    }
}
