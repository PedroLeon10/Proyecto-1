<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarLibros.aspx.cs" Inherits="Tarea_2._2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../css/AgregarLibros.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-style: italic; margin-left: 40px;">
            <h1>Agregar Libro</h1><br />
            <br />
            Isbn<asp:TextBox ID="txtIsbn" runat="server" MaxLength="13" CssClass="input"></asp:TextBox>
            <br />
            <br />
            Título<asp:TextBox ID="txtTitulo" runat="server" MaxLength="45" CssClass="input"></asp:TextBox>
            <br />
            <br />
            Número edición<asp:TextBox ID="txtNumEdicion" runat="server" CssClass="input"></asp:TextBox>
            <br />
            <br />
            Año de publicación<asp:TextBox ID="txtAnio" runat="server" MaxLength="4" CssClass="input"></asp:TextBox>
            <br />
            <br />
            Autores<asp:TextBox ID="txtAutores" runat="server" MaxLength="150" CssClass="input"></asp:TextBox>
            <br />
            <br />
            País de publicación<asp:TextBox ID="txtPais" runat="server" MaxLength="45" CssClass="input"></asp:TextBox>
            <br />
            <br />
            Sinópsis<asp:TextBox ID="txtSinopsis" runat="server" MaxLength="150" CssClass="input"></asp:TextBox>
            <br />
            <br />
            Carrera<asp:TextBox ID="txtCarrera" runat="server" MaxLength="45" CssClass="input"></asp:TextBox>
            <br />
            <br />
            Materia<asp:TextBox ID="txtMateria" runat="server" MaxLength="45" CssClass="input"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInsentar" runat="server" OnClick="btnInsentar_Click" Text="Insertar" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Catálogo" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbMensaje" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
