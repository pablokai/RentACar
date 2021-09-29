<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarVehiculo.aspx.cs" Inherits="RentACar.Pages.EliminarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


      <!-- VALIDACION -->
    <div class="container">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div class="col-md-8" style="background-color: #2e52db; color:#E6EBF4; border-radius: 15px; padding: 30px 10px 30px 40px">
                Ingrese la placa del vehículo a eliminar
            </div>
        </div>
    </div>

    <div class="container"">
        <div class="row">
              <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px">
            <div class="col-md-5" style="font-size: 20px; font-weight: 400"">
                <label for="txtEliminar">Placa</label>
            </div>
                <div class="col-md-5 col-md-offset-1">
                        <input type="text" class="form-control" id="txtEliminar" runat="server" placeholder="Ingrese la placa del vehículo">
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
                        <asp:Button ID="btnConsultar" runat="server" Text="Eliminar vehículo" CssClass="btn btn-primary btn-lg btn-block" BackColor="#1CCFF5 " BorderColor="#1CCFF5" ForeColor="White" OnClick="btnConsultar_Click" />
                    </div>

             <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblError" runat="server" Text="Se produjo un error,la placa no existe"></asp:Label></span>
        </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito"  role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblSuccess" runat="server" Text="Se ha eliminado el registro"></asp:Label></span>
        </div>
            </div>

</asp:Content>
