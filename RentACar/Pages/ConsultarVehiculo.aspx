<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarVehiculo.aspx.cs" Inherits="RentACar.Pages.ConsultarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      
        
     

      <!-- VALIDACION -->
    <div class="container">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div class="col-md-8" style="background-color: #2e52db; color:#E6EBF4; border-radius: 15px; padding: 30px 10px 30px 40px">
                Ingrese la placa del vehículo a consultar
            </div>
        </div>
    </div>

    <div class="container"">
        <div class="row">
              <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px">
            <div class="col-md-5" style="font-size: 20px; font-weight: 400"">
                <label for="txtBuscar">Placa</label>
            </div>
                <div class="col-md-5 col-md-offset-1">
                        <input type="text" class="form-control" id="txtBuscar" runat="server" placeholder="Ingrese la placa del vehículo">
            </div>
        </div>
            </div>
     </div>

        <div class="container">
        
            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                    </div>
            </div>
            
             <div class="col-lg-12 col-md-offset-2" style="padding-bottom: 20px">
                        <asp:Button ID="btnConsultar" runat="server" Text="Consultar vehículo" CssClass="btn btn-primary btn-lg btn-block" BackColor="#1CCFF5 " BorderColor="#1CCFF5" ForeColor="White" OnClick="btnConsultar_Click" />
                    </div>

             <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblError" runat="server" Text="Se produjo un error,la placa no existe"></asp:Label></span>
        </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito"  role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblSuccess" runat="server" Text="La placa si existe"></asp:Label></span>
        </div>
            </div>

    <div class="container">

     <div class="row" style="margin-top: 30px" visible="true">
            <div class="col-md-12" style="padding: 20px 35px 0px 35px">
                <div style="width: 70%; height: 100px; overflow: auto;">
                    <asp:GridView ID="gvDatos" runat="server" CssClass="table" AutoGenerateColumns="False" GridLines="None" BorderStyle="None" SelectedRowStyle-ForeColor="#FF3399" Visible="False">
                        <Columns>
                            <asp:BoundField HeaderText="Placa" DataField="placa" />
                            <asp:BoundField HeaderText="Modelo" DataField="modelo" />
                            <asp:BoundField HeaderText="Marca" DataField="marca" />
                            <asp:BoundField HeaderText="Año" DataField="annio" />
                            <asp:BoundField HeaderText="Estado" DataField="estado" />
                            <asp:BoundField HeaderText="Color" DataField="color" />
                            <asp:BoundField HeaderText="Combustible" DataField="combustible" />
                            <asp:BoundField HeaderText="Costo Alquiler" DataField="costoalquiler" />
                            <asp:BoundField HeaderText="Tipo" DataField="tipo" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>

      </div>
</asp:Content>
