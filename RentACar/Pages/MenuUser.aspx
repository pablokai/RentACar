<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuUser.aspx.cs" Inherits="RentACar.Pages.MenuUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="https://kit.fontawesome.com/7adeb3fe3b.js"></script>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;600;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="../Content/MenuUsuario.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <h1>Seleccione una opción</h1>

        </div>
             <div class='container'>
                <a href="Alquiler.aspx">
                    <div class="box" style="background-color: #1CCFF5;">
                        <div class="icon"> <i  class="fas fa-car-side" aria-hidden="true"></i></div>

                            <h3>Alquilar Vehículo</h3>
                    </div>
                </a>
                <a href="RegresarVehiculo.aspx">
                    <div class="box" style="background-color: #FF004D;">
                        <div class="icon"> <i  class="fas fa-exchange-alt" aria-hidden="true"></i></div>
                        <div class="content">
                            <h3>Regresar Vehículo</h3>
                        </div>
                    </div>
                </a>  
            </div>
    </form>
</body>
</html>
