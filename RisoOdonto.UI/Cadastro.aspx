<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="RisoOdonto.UI.Cadastro" %>

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
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
      <div class="container">
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
    <form id="form1" runat="server">
        <div>
            <div class="container-center" style="background-color:#7b37ac88; color:black;">
                <h1 style="text-align:center; ">Cadastra-se aqui</h1>
                <div class="container-center" style="display:flex; justify-content:center; flex-direction:row; align-items:center;">
                <ul >
                    <li >
                        <asp:Label ID="txtNome" runat="server" Text="Nome:"></asp:Label>
                    </li>
                    <li>
                        <asp:TextBox ID="TextBox1" runat="server" Placeholder="Nome"></asp:TextBox></li>
                    <li>
                        <asp:Label ID="Label2" runat="server" Text="CPF:"></asp:Label>
                        <li>
                            <asp:TextBox ID="TextBox2" runat="server" Placeholder="cpf"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="Label3" runat="server" Text="E-mail:"></asp:Label>
                        </li>
                        <li>
                            <asp:TextBox ID="TextBox3" runat="server" Placeholder="email"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="Label4" runat="server" Text="Plano de saude:"></asp:Label>
                        </li>
                        <li>
                            <asp:TextBox ID="TextBox4" runat="server" Placeholder="plano de saude"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="Label9" runat="server" Text="Celular:"></asp:Label>
                        </li>
                        <li>
                            <asp:TextBox ID="TextBox10" runat="server" Placeholder="cel"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="Label1" runat="server" Text="Cidade:"></asp:Label>
                        </li>
                        <li>
                            <asp:TextBox ID="TextBox5" runat="server" Placeholder="cidade"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="Label5" runat="server" Text="Bairro:"></asp:Label>
                        </li>
                        <li>
                            <asp:TextBox ID="TextBox6" runat="server" Placeholder="bairro"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="Label6" runat="server" Text="CEP:"></asp:Label>
                        </li>
                        <li>
                            <asp:TextBox ID="TextBox7" runat="server" Placeholder="cep"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="Label7" runat="server" Text="Logradouro:"></asp:Label>
                        </li>
                        <li>
                            <asp:TextBox ID="TextBox8" runat="server" Placeholder="logradouro"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="Label8" runat="server" Text="Numero:"></asp:Label>
                        </li>
                        <li>
                            <asp:TextBox ID="TextBox9" runat="server" Placeholder="nro"></asp:TextBox>
                        </li>
                        <li>
                            <input type="date" name="" id="">
                        </li>

                        <select name="select">
                          <option value="valor1">-- Selecione Sexo --</option>
                          <option value="valor2" >Masculino </option>
                          <option value="valor3"> Feminino </option>
                        </select>
                </ul>
                    </div>
            </div>
        </div>
    </form>

        <!-- footer -->
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
