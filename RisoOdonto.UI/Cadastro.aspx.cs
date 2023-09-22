using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RisoOdonto.UI
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //limpar labels de validacao
        private void NewMethod()
        {
            lblNome.Text = lblSenha.Text = lblEmail.Text = lblData.Text = lblCpf.Text = lblEndereco.Text = lblEstado.Text = lblTel.Text = lblSenha.Text = string.Empty;
        }

        //validaPage
        public bool ValidaPage()
        {
            //criando variavel de retorno
            bool validator;

            //estrutura de checagem
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                NewMethod();
                lblNome.Text = "Digite seu nome completo !!";
                txtNome.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                NewMethod();
                lblEmail.Text = "Digite o email do usuário !!";
                txtEmail.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                NewMethod();
                lblTel.Text = "Digite seu telefone !!";
                txtTelefone.Focus();
                validator = false;
            }

            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                NewMethod();
                lblSenha.Text = "Digite a senha do usuário !!";
                txtSenha.Focus();
                validator = false;
            }

            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                NewMethod();
                lblSenha.Text = "Digite a senha do usuário !!";
                txtSenha.Focus();
                validator = false;
            }
            
            else if (string.IsNullOrEmpty(txtData.Text))
            {
                NewMethod();
                lblData.Text = "Digite a data de nascimento do usuário !!";
                txtData.Focus();
                validator = false;
            }
            else
            {
                validator = true;

            }

            return validator;

        }

    }
}