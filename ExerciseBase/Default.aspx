<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExerciseBase.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 4</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="400px" align="center">
                <tr valign="top">
                    <td align="right">
                        <asp:Label ID="lblList" runat="server" Text="" />
                    </td>
                    <td align="left">
                        
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="right">
                        <asp:Label ID="lblCounting" runat="server" Text="" />
                    </td>
                </tr>                
            </table>        
    </div>
    </form>
</body>
</html>
