<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frmindex.aspx.cs" Inherits="PROJETOMVCB35.UI.Frmindex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <title>Benefícios</title>
</head>
<body class="text-center align-content-center">
    <form id="form1" class="form-signin" runat="server">

        <h1 class="h3 mb-3 font-weight-normal">Confira seus benefícios</h1>

        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

        <br />
        <asp:Label ID="lblcpf" runat="server" Text="Cpf"></asp:Label>
        <asp:TextBox type="number" ID="txtCpfB35" class="form-control text-center" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lblName" runat="server" Text="Nome completo"></asp:Label>
        <asp:TextBox type="text" class="form-control text-center" ID="txtNomeB35" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblMotherName" runat="server" Text="Nome completo da mãe"></asp:Label>
        <asp:TextBox type="text" class="form-control text-center" ID="txtNomeMaeB35" runat="server"></asp:TextBox>

        <br />

        <br />
        <asp:Button ID="btnEntrar" Class="btn btn-lg btn-primary" runat="server" OnClick="Button1_Click" Text="Conferir benefícios" />

        <br />

    </form>
</body>
</html>
