<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegresarVehiculo.aspx.cs" Inherits="RentACar.Pages.RegresarVehiculo" MaintainScrollPositionOnPostback="true"   %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/RegresarVehiculo.css" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;600;700&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
                <div class="titulo" style="background-color: transparent; color: white; border-radius: 15px; padding: 30px 10px 30px 40px">
                    Regresar vehículo de alquiler
                </div>
            </div>
        </div>

        <div class="nav">

            <div class="col-md-6">

                <label for="txtCosto" style="color: black !important; margin-bottom: 20px;">Ingrese el id del cliente para ver sus alquileres</label>
                <%--<input type="text" class="form-control" id="txtMarca" runat="server" placeholder="Ingrese la marca del vehiculo" required="required">--%>

                <input type="text" class="center" id="txtBuscarID" runat="server" placeholder="Ingrese el id del cliente" />

                <asp:Button ID="btnValidar" runat="server" Text="Buscar alquileres" CssClass="btn" ForeColor="White" BackColor="#1CCFF5" BorderColor="#1CCFF5" OnClick="btnValidar_Click" />


            </div>
        </div>





        <div class="container">

            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                </div>
            </div>

            <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="LblError2" role="alert" runat="server" visible="false" style="margin-top: 20px">
                <span aria-hidden="true"><asp:Label ID="lblErr" runat="server" Text="Error , no hay alquileres del cliente" BackColor="#FF004D" CssClass="mensaje"></asp:Label></span>
            </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito2" role="alert" runat="server" visible="false" style="margin-top: 20px">
                <span aria-hidden="true"><asp:Label ID="lblEx" runat="server" Text="El cliente si tiene registros " BackColor="#4DD599" CssClass="mensaje"></asp:Label></span>
            </div>

        </div>




        <div class="container">
            
                <div id="titulo" class="titulo" style="background-color: transparent; color: white; border-radius: 15px; padding: 30px 10px 30px 40px;text-align: center;" runat="server">
                    Alquileres en trámite
                </div>
        </div>
        <div class="container">
            <label style="text-align: center; color: white;" runat="server" id="instruccion">Seleccione el alquiler que desea regresar:</label>
            <div class="row" style="margin-top: 30px" visible="true">
                <asp:GridView ID="gvAlquiler" runat="server" CssClass="tabla" AutoGenerateColumns="False" GridLines="Both" SelectedRowStyle-ForeColor="#FF3399" Visible="False" AutoGenerateSelectButton="True" Height="35px" Width="350px" BorderStyle="Solid" BorderWidth="5px" OnSelectedIndexChanged="gvAlquiler_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField HeaderText="ID Alquiler" DataField="consecutivo" />
                        <asp:BoundField HeaderText="ID cliente" DataField="idcliente" />
                        <asp:BoundField HeaderText="Placa" DataField="placa" />
                        <asp:BoundField HeaderText="Fecha Salida" DataField="fechasalida" />
                        <asp:BoundField HeaderText="Fecha Entrega" DataField="fechaentrega" />
                        <asp:BoundField HeaderText="Costo" DataField="costo" />
                        <asp:BoundField HeaderText="Número Tarjeta" DataField="numTarjeta" />
                        <asp:BoundField HeaderText="ID Seguro (si tiene)" DataField="seguro" />
                    </Columns>

                    <SelectedRowStyle ForeColor="#FF3399"></SelectedRowStyle>
                </asp:GridView>
                <div class="col-md-12" style="padding: 20px 35px 0px 35px">
                </div>
            </div>

        </div>

        <div class="container">

            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                </div>
            </div>

            <div class="col-lg-12 col-md-offset-2">
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar Vehículo" CssClass="button" ForeColor="White" OnClick="btnRegresar_Click"  />
            </div>


        </div>

         <div class="container">

            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                </div>
            </div>

            <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblError" role="alert" runat="server" visible="false" style="margin-top: 20px">
                <span aria-hidden="true"><asp:Label ID="lblErr2" runat="server" Text="Error, inténtelo de nuevo" BackColor="#FF004D" CssClass="mensaje"></asp:Label></span>
            </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito" role="alert" runat="server" visible="false" style="margin-top: 20px">
                <span aria-hidden="true"><asp:Label ID="lblEx2" runat="server" Text="Se ha regresado el vehículo " BackColor="#4DD599" CssClass="mensaje"></asp:Label></span>
            </div>

        </div>

        <div class="nav">
            <asp:Button ID="btnSalir" runat="server" Text="Salir" CssClass="btn" ForeColor="White" BackColor="#FF004D" BorderColor="#FF004D" OnClick="btnSalir_Click" />
        </div>

    </form>
</body>
</html>
