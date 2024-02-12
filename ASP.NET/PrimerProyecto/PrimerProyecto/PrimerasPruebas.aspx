<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimerasPruebas.aspx.cs" Inherits="PrimerProyecto.PrimerasPruebas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 129px">
            <asp:Label ID="Label1" runat="server" Text="Número 1:"></asp:Label>
            <asp:TextBox ID="txtNumero1" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Numero 2:"></asp:Label>
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" Text="calcular" OnClick="btnCalcular_Click" Width="113px" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado:"></asp:Label>
            <br />
            <br />
            <br />
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Frutas" />
            <br />
            <br />
            <table style="width: 100%;" ID="table1">
                <tr>
                    <th class="auto-style1">Fruta</th>
                    <th class="auto-style">Precio</th>
                </tr>
                <tr>
                    <td class="auto-style1" id="1"></td>
                    <td class="auto-style1" id="1precio"></td>
                </tr>
                <tr>
                    <td class="auto-style1" id="2"></td>
                    <td class="auto-style1" id="2precio"></td>
                </tr>
                <tr>
                    <td class="auto-style1" id="3"></td>
                    <td class="auto-style1" id="3precio"></td>
                </tr>
                <tr>
                    <td class="auto-style1" id="4"></td>
                    <td class="auto-style1" id="4precio"></td>
                </tr>
                <tr>
                    <td class="auto-style1" id="5"></td>
                    <td class="auto-style1" id="5precio"></td>
                </tr>
                <tr>
                    <td class="auto-style1" id="6"></td>
                    <td class="auto-style1" id="6"></td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
</body>
</html>
