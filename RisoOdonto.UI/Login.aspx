<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RisoOdonto.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Seja Bem Vindo a Riso Odonto</title>
    <link href="src/css/style.css" rel="stylesheet" />
    <!-- bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
    <!-- boxicons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css">
</head>
<body>
    <!-- Nav -->
    <%--#region--%>
    <header>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
      <div class="container">
        <a class="navbar-brand" href="#Home">Riso<span class="logo">Odonto</span> </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">      
            <button class="btn-nav"  type="submit">Cadastrar</button>
        </div>
      </div>
    </nav>
    </header>
    <%--#endregion--%>

    <%--central region--%>
    <%--#region--%>
            <div class="box">
        <form id="form1" runat="server">
        <fieldset>
        <legend><b>Login</b></legend>
        <br><br>
        <div class="inputBox">
        <asp:TextBox type="text" name="email" id="txtEmail" class="inputUser" runat="server" required/>
        <label for="email" class="labelInput">Email</label>
        </div>
        <br><br>
        <div class="inputBox">
        <asp:TextBox type="text" name="senha" id="txtSenha" class="inputUser" runat="server" required/>
        <label for="senha" class="labelInput">Senha</label>
        </div>
        <br><br>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </fieldset>
        </form>
        </div>     
      <!-- #endregion -->

 <%--footer--%>
    <%--#region--%>
      <div class="container-footer">
      <div class="footer">
        <h1>RisoOdonto</h1>
        <p>&copy;2023 RisoOdonto</p>
        <p>Todos os direitos reservados.</p>
      </div>
      <div class="footer-socias">
        <ul>
          <li><a href=""><i class="fa-brands fa-whatsapp"></i></a></li>
          <li><a href=""><i class="fa-brands fa-instagram"></i></a></li>
          <li><a href=""><i class="fa-brands fa-youtube"></i></a></li>
        </ul>
      </div>
    </div>
    </footer>
    <%--#endregion--%>

    <%--Script--%>

    <!-- bootstrap -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
</body>
</html>
