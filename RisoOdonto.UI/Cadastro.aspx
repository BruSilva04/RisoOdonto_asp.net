<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="RisoOdonto.UI.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="src/css/style.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <!-- bootstrap -->
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
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
            <button class="btn-nav" type="submit">Cadastrar</button>
            <button class="btn-nav" type="submit">Login</button>
        </div>
      </div>
    </nav>
    </header>
    <!-- endregion -->
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
