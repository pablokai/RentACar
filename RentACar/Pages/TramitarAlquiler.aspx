<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TramitarAlquiler.aspx.cs" Inherits="RentACar.Pages.TramitarAlquiler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="../Content/Tramite.css" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;600;700&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <div style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
                <div class="titulo" style="background-color: transparent; color: white; border-radius: 15px; padding: 30px 10px 30px 40px">
                    Trámite de alquiler
                </div>
            </div>
        </div>

        <div class="nav">

            <div class="col-md-6">

                <label for="txtCosto" style="color: black !important; margin-bottom: 20px;">Ingrese el id del cliente si ya está registrado</label>
                <%--<input type="text" class="form-control" id="txtMarca" runat="server" placeholder="Ingrese la marca del vehiculo" required="required">--%>

                <input type="text" class="center" id="txtBuscarID" runat="server" placeholder="Ingrese el id del cliente" />

                <asp:Button ID="btnValidar" runat="server" Text="Validar cliente" CssClass="btn" ForeColor="White" BackColor="#1CCFF5" BorderColor="#1CCFF5" OnClick="btnValidar_Click" />

                <asp:Button ID="btnAgregarNuevo" runat="server" Text="Agregar nuevo cliente" CssClass="btn" ForeColor="White" OnClick="btnAgregarNuevo_Click" />

            </div>
        </div>

        <div class="col-lg-12 col-md-offset-2">
            <asp:Button ID="btnAvanzar" runat="server" Text="Avanzar" CssClass="button" ForeColor="White" OnClick="btnAvanzar_Click" />
        </div>

        <div class="container">

            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                </div>
            </div>

            <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" >
                <span aria-hidden="true"><asp:Label ID="lblError" runat="server" Text="Se produjo un error , no existe el cliente" BackColor="#FF004D" CssClass="mensaje"></asp:Label></span>
            </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito" role="alert" runat="server" visible="false" style="margin-top: 20px" >
                <span aria-hidden="true"><asp:Label ID="lblSuccess" runat="server" Text="El usuario si existe " BackColor="#4DD599" CssClass="mensaje"></asp:Label></span>
            </div>

        </div>


        <div class="titulo" style="background-color: transparent; color: white; border-radius: 15px; padding: 30px 10px 30px 40px; text-align: center;" id="titulo" runat="server">
            Registrar Cliente
        </div>

        <div class="row" id="bloque" runat="server">

            <div class="column" style="background-color: #aaa;">


                <label for="txtCedula" id="lblCedula" runat="server">Cédula</label>
                <input type="text" class="in" id="txtCedula" runat="server" placeholder="Ingrese la cédula" />
                <%--<asp:DropDownList ID="ddlModelo" runat="server"   CssClass="ddl"></asp:DropDownList>--%>


                <label for="txtNombre">Nombre</label>
                <input type="text" class="in" id="txtNombre" runat="server" placeholder="Ingrese el nombre" />

                <%--<asp:DropDownList ID="ddlMarca" runat="server"   CssClass="ddl"></asp:DropDownList>--%>



                <label for="txtPrimer">Primer Apellido</label>
                <%--     <input type="text" class="form-control" id="txtMarca" runat="server" placeholder="Ingrese la marca del vehiculo" required="required">--%>

                <input type="text" class="in" id="txtPrimer" runat="server" placeholder="Ingrese el primer apellido" />




                <label for="txtSegundo">Segundo Apellido</label>
                <%--     <input type="text" class="form-control" id="txtMarca" runat="server" placeholder="Ingrese la marca del vehiculo" required="required">--%>

                <input type="text" class="in" id="txtSegundo" runat="server" placeholder="Ingrese el segundo apellido" />




                <label for="txtFecha">Fecha de Nacimiento</label>
                <input type="date" class="in" id="txtFecha" runat="server" />

                <label for="ddlTipo">Tipo de cliente</label>

                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="ddl">
                    <asp:ListItem>Nacional</asp:ListItem>
                    <asp:ListItem>Extranjero</asp:ListItem>
                </asp:DropDownList>

            </div>
            <div class="column" style="background-color: #bbb;">
                <label for="txtResidencia">Residencia</label>
                <input type="text" class="in" id="txtResidencia" runat="server" placeholder="Ingrese la residencia"  />


                <label for="txtDireccion">Dirección</label>
                <input type="text" class="in" id="txtDireccion" runat="server" placeholder="Ingrese la dirección"  />


                <label for="txtNumTarjeta">Tarjeta</label>
                <input type="text" class="in" id="txtNumTarjeta" runat="server" placeholder="Ingrese el número de tarjeta"  />

                <label for="txtExpiracion">Fecha Expiración</label>
                <input type="date" class="in" id="txtExpiracion" runat="server" />

                <label for="ddlTipoTarjeta">Tipo de tarjeta</label>

                <asp:DropDownList ID="ddlTipoTarjeta" runat="server" CssClass="ddl">
                    <asp:ListItem>Mastercard</asp:ListItem>
                    <asp:ListItem>Visa</asp:ListItem>
                </asp:DropDownList>

                <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="button2" ForeColor="White" OnClick="btnInsertar_Click" />


            </div>
        </div>

        <div class="container">

            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                </div>
            </div>

            <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="LblError2" role="alert" runat="server" visible="false" style="margin-top: 20px" >
                <span aria-hidden="true"><asp:Label ID="lblErr" runat="server" Text="Se produjo un error , intentelo de nuevo" BackColor="#FF004D" CssClass="mensaje"></asp:Label></span>
            </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito2" role="alert" runat="server" visible="false" style="margin-top: 20px">
                <span aria-hidden="true"><asp:Label ID="lblEx" runat="server" Text="El usuario se ha registrado, puede avanzar " BackColor="#4DD599" CssClass="mensaje"></asp:Label></span>
            </div>

        </div>



    </form>

</body>
</html>
