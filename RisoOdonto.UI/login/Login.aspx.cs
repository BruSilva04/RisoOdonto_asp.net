﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RisoOdonto.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "SEJA BEM A RISO ODONTO ";
            lblMessage.Font.Size = 50;
        }
            
            
            protected void btnEntrar_Click(object sender, EventArgs e)
            {
                try
                {
                    //instanciar os objetos DTO BLL
                    UsuarioDTO usuario = new UsuarioDTO();
                    UsuarioBLL objBLL = new UsuarioBLL();

                    //pegar os dados fornecidos pelo usuario
                    string objEmail = txtEmail.Text;
                    string objSenha = txtSenha.Text;

                    //chamar o metodo na BLL
                    usuario = objBLL.AuteticarUsuario(objEmail, objSenha);


                    //checar o tipo de usuario
                    if (usuario != null)
                    {

                        lblMessage.Text = $"Bem Vindo {usuario.Nome}";
                    }

                }
                catch (Exception)
                {

                    lblMessage.Text = $"Usuario {txtEmail.Text} não cadastrado!!! ";
                }
            }
    }
}