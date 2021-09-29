<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="RentACar.Pages.UserPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Usuario</title>

        <script src="https://kit.fontawesome.com/7adeb3fe3b.js"></script>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;600;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="../Content/Usuario.css" />
</head>

 
<body>
    <form id="form1" runat="server">


          <div >
            <h1>Sistema de Rent A Car </h1>

        </div>
             <div class='container'>
                <a href="Pages/Logon.aspx">
                    <div class="box" style="background-color: #f3f7fe;">
                        <div class="icon"> <i  class="fas fa-user-lock" aria-hidden="true"></i></div>

                            <h3>Administrador</h3>
                    </div>
                </a>
                <a href="Pages/MenuUser.aspx">
                    <div class="box" style="background-color: #f3f7fe;">
                        <div class="icon"> <i  class="fas fa-user" aria-hidden="true"></i></div>
                        <div class="content">
                            <h3>Usuario</h3>
                        </div>
                    </div>
                </a>  
            </div>
    </form>
</body>
</html>
