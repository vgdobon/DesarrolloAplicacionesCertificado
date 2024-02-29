<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTabla.aspx.cs" Inherits="ControlesListas.frmTabla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <table>
        <tr>
            <td>
                <strong></strong>
            </td>
            <td>
                <asp:CheckBoxList runat="server"
                    ID="cblFontStyle" AutoPostBack="true" CellPadding="5" OnInit="cblFontStyle_Init">

                </asp:CheckBoxList>
            </td>   
        </tr>
    </table>
</body>
</html>
