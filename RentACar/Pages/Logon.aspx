<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="RentACar.Pages.Logon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="https://kit.fontawesome.com/7adeb3fe3b.js"></script>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;600;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="../Content/Login.css" />
</head>
<body>

    <div class="split left">
  <div class="centered">
      <img src="../Images/carcity.svg" alt="Avatar man">
  </div>
</div>

<div class="split right">
  <div class="centered">
     <form id="form1" runat="server" class="form">
        <div class="box">
        <h1>  
      Ingresar</h1>  
            <table>  
                <tr>  
                    <td>  
          Usuario:</td>  
                    <td>  
                        <asp:TextBox ID="UserName" runat="server" CssClass="email" />  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"   
            ControlToValidate="UserName"  
            Display="Dynamic"   
            ErrorMessage="Cannot be empty."   
            runat="server" />  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
          Contraseña:</td>  
                    <td>  
                        <asp:TextBox ID="UserPass" TextMode="Password"   
             runat="server" CssClass="email"/>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"   
            ControlToValidate="UserPass"  
            ErrorMessage="Cannot be empty."   
            runat="server" />  
                    </td>  
                </tr>  
              
            </table>  
            <asp:Button ID="btnLogin" OnClick="btnLogin_Click" Text="Log In"   
       runat="server" CssClass="btn"/>  
            <p>  
                <asp:Label ID="Msg" ForeColor="red" runat="server" />  
            </p>
            
            </div>
    </form>
  </div>
</div>
   
</body>
</html>
