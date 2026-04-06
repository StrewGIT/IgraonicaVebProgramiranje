<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IgraonicaVebProgramiranje_StefanAndrejevic.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log in korisnika</title>
    <link rel="stylesheet" type="text/css" href="moj_css.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:100%;">
             <div style="width:35%; float:left;">
                 &nbsp;
             </div>
            <div style="width:30%; float:left;">
                <h1>Ulogujte se :</h1>
                <table style="width:100%" >
                    <tr>
                        <td style="text-align:right;">Unesite Vasu Elektronsku postu :</td>
                        <td style="text-align:left;"><asp:TextBox ID="txt_email" runat="server" TextMode="Email"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align:right;">Unesite Vasu lozinku :</td>
                        <td style="text-align:left;">
                            <asp:TextBox ID="txt_lozinka" runat="server" TextMode="Password"></asp:TextBox>
                         </td>
                    </tr>
                     <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btn_login" runat="server" Text="Log in" OnClick="btn_login_Click" />
                            <asp:Button ID="btn_register" runat="server" Text="Register" OnClick="btn_register_Click" />
                         </td>
                     </tr>
                </table>
                
            </div>
            
            <div style="width:35%; float:left;">
                &nbsp;
            </div>
        </div>
    </form>
</body>
</html>

