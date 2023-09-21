﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="RisoOdonto.UI.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="src/css/Cadastro.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <!-- bootstrap -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
    <!-- boxicons -->
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css">
    <title>Faça seu Cadastro</title>
</head>
<body>
        <!-- Nav -->
    <header>
    <nav class="navbar navbar-expand-lg bg-body-tertiary ">
      <div class="container d-flex justify-content-between align-items-center " >
        <a class="navbar-brand" href="#Home">Riso<span class="logo">Odonto</span> </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <button class="btn-nav" type="submit">Login</button>
        </div>
      </div>
    </nav>
    </header>
    <!-- endregion -->
    <div class="box">
        <form id="form1" runat="server">
           <fieldset>
                    <legend><b>Cadastro</b></legend>
                    <br><br>
                    <div class="inputBox">
                        <asp:TextBox type="text" name="nome" id="txtNome" class="inputUser" runat="server" required/>
                        <label for="nome" class="labelInput">Nome completo</label>
                    </div>
                    <br><br>
                    <div class="inputBox">
                        <asp:TextBox type="text" name="email" id="txtEmail" class="inputUser" runat="server" required/>
                        <label for="email" class="labelInput">Email</label>
                    </div>
                    <br><br>
                    <div class="inputBox">
                        <asp:TextBox type="tel" name="telefone" id="txtTelefone" class="inputUser" runat="server" required/>
                        <label for="telefone" class="labelInput">Telefone</label>
                    </div>
                    <p>Sexo:</p>
                    <input type="radio" id="feminino" name="genero" value="feminino" required>
                    <label for="feminino">Feminino</label>
                    <br>
                    <input type="radio" id="masculino" name="genero" value="masculino" required>
                    <label for="masculino">Masculino</label>
                    <br>
                    <input type="radio" id="outro" name="genero" value="outro" required>
                    <label for="outro">Outro</label>
                    <br><br>
                    <label for="data_nascimento"><b>Data de Nascimento:</b></label>
                    <input type="date" name="data_nascimento" id="data_nascimento" required>
                    <br><br><br>
                    <div class="inputBox">
                        <asp:TextBox type="text" name="cpf" id="txtCpf" class="inputUser" runat="server" required/>
                        <label for="cpf" class="labelInput">CPF</label>
                    </div>
                    <br><br>
                    <div class="inputBox">
                        <asp:TextBox type="text" name="estado" id="txtEstado" class="inputUser" runat="server" required/>
                        <label for="estado" class="labelInput">Estado</label>
                    </div>
                    <br><br>
                    <div class="inputBox">
                        <asp:TextBox type="text" name="endereco" id="txtEndereco" class="inputUser" runat="server" required/>
                        <label for="endereco" class="labelInput">Endereço</label>
                    </div>
                    <br><br>
                     <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar"  />
                      <asp:Label ID="lblMessage" runat="server"></asp:Label>

                </fieldset>
        </form>
    </div>                 <!-- footer -->
     <footer>
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
    </footer >
    <!-- endregion -->


    <%--script--%>
    <!-- bootstrap -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
</body>
</html>
