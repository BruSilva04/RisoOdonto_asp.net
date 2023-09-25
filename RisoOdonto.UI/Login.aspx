<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RisoOdonto.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="src/css/style.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Faça seu Cadastro</title>
</head>
<body >
          
    <!-- endregion -->
    <div class="box">
        <form id="form1" runat="server">
           <fieldset>
                    <legend><b>Cadastro</b></legend>
                    <br><br>
           
                    <div class="inputBox">
                        <asp:TextBox type="text" name="email" id="txtEmail" class="inputUser" runat="server" required/>
                        <label for="email" class="labelInput">Email</label>
                          <br />
                        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                    </div>
                    <br><br>
                    
               <div class="inputBox">
                        <asp:TextBox type="password" name="senha" id="txtSenha" class="inputUser" runat="server" required/>
                        <label for="senha" class="labelInput">Senha</label>
                                                   <br />
                        <asp:Label ID="lblSenha" runat="server" Text=""></asp:Label>
                    </div>
                    <br><br>
                     <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar"  />
                      <asp:Label ID="lblMessage" runat="server"></asp:Label>

                </fieldset>
        </form>
    </div> 


    <%--scripts--%>

     <%--jquery--%>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.0/jquery.min.js" integrity="sha512-3gJwYpMe3QewGELv8k/BX9vcqhryRdzRMxVfq6ngyWXwo03GFEzjsUm8Q7RZcHPHksttq7/GFoxjCVUjkjvPdw==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <%--jqueryMask--%>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.16/jquery.mask.min.js" integrity="sha512-pHVGpX7F/27yZ0ISY+VVjyULApbDlD0/X0rgGbTqCE7WFW5MezNTWG/dnhtbBuICzsd0WQPgpE4REBLv+UqChw==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script src="src/js/index.js"></script>
</body>
</html>
