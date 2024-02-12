<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fechas.aspx.cs" Inherits="PrimerProyecto.Fechas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 216px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Añadir dias" />
            <br />
            <asp:Label ID="lblSalida" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
