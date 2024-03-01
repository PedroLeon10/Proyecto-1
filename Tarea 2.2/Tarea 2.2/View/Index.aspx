<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Tarea_2._2.Model.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../css/Index.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Catálogo de Libros</h1><br />
            <asp:Table ID="TableLibros" runat="server" CssClass="table">
            </asp:Table>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnInsertar" runat="server" Text="Insertar Libro" OnClick="btnInsertar_Click" />
            <br />
        </div>
    </form>
</body>
</html>
