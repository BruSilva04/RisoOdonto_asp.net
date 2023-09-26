using RisoOdonto.BLL;
using RisoOdonto.DTO;
using RisoOdonto.UI.utilitarios;
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
        //instanciar os objetos DTO BLL
        UsuarioDTO usuario = new UsuarioDTO();
        UsuarioBLL objBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopularDDL();
            }
        }

        //popular ddl
        public void PopularDDL()
        {
            ddl1.DataSource = objBLL.CarregaTpUsuarioDDL();
            ddl1.DataBind();
        }

        //limpar labels de validacao
        private void NewMethod()
        {
            lblNome.Text = lblSenha.Text = lblEmail.Text  = lblCpf.Text = lblData.Text = lblEndereco.Text = lblEstado.Text = lblTel.Text = lblSenha.Text = string.Empty;
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
            else if (string.IsNullOrEmpty(txtData.Text))
            {
                NewMethod();
                lblData.Text = "Digite sua Data !!";
                txtTelefone.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtCpf.Text))
            {
                NewMethod();
                lblCpf.Text = "Digite o nome do Estado do nascimento !!";
                txtCpf.Focus();
                validator = false;
            }

            else if (string.IsNullOrEmpty(txtEstado.Text))
            {
                NewMethod();
                lblEstado.Text = "Digite o nome do Estado do nascimento !!";
                txtEstado.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                NewMethod();
                lblEndereco.Text = "Digite o Endereço e o numero da casa !!";
                txtEndereco.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                NewMethod();
                lblSenha.Text = "Digite a senha  !!";
                txtSenha.Focus();
                validator = false;
            }
            else
            {
                validator = true;

            }

            return validator;

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
                if (ValidaPage())
                {

                    //preenchendo dados
                    usuario = new UsuarioDTO();
                    usuario.Nome = txtNome.Text.Trim();
                    usuario.Email = txtEmail.Text.Trim();
                    usuario.Telefone = Convert.ToInt32(txtTelefone.Text.Trim());
                    //ajustar a data
                    DateTime dt;
                    if (DateTime.TryParse(txtData.Text, out dt))
                    {
                        usuario.DataNasciemento = dt;
                    }
                    else
                    {
                        lblData.Text = $"Data inválida !!";
                        txtData.Text = string.Empty;
                        txtData.Focus();
                        return;
                    }
                    usuario.CPF = txtCpf.Text.Trim();
                    usuario.Estado = txtEstado.Text.Trim();
                    usuario.Endereço = txtEndereco.Text.Trim();
                    usuario.Senha = txtSenha.Text.Trim();
                    
                    //ddl
                    usuario.TpUsuario = ddl1.SelectedValue;


                        //cadastrar
                        objBLL.Cadastrar(usuario);
                        Limpar.ClearControl(this);
                        btnCadastrar.Enabled = true;
                        lblMessage.Text = $"Usuário {usuario.Nome} cadastrado com sucesso !!";

                }
            }
    }
}