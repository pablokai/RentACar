<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Combustible.aspx.cs" Inherits="RentACar.Pages.Combustible" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
     <div class="container">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div class="col-md-8" style="background-color: #2e52db; color:#E6EBF4; border-radius: 15px; padding: 30px 10px 30px 40px">
                Gestión de Combustible
            </div>
        </div>
    </div>

    <div class="container" style="margin-top: 30px;">
        <div class="row">
              <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px">
            <div class="col-md-5" style="font-size: 20px; font-weight: 400"">
                <label for="txtBuscar">Nuevo Combustible</label>
            </div>
                <div class="col-md-5 col-md-offset-1">
                        <input type="text" class="form-control" id="txtBuscar" runat="server" placeholder="Ingrese el nuevo combustible">
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
                        <asp:Button ID="btnInsertar" runat="server" Text="Insertar combustible" CssClass="btn btn-primary btn-lg btn-block" BackColor="#1CCFF5 " BorderColor="#1CCFF5" ForeColor="White" OnClick="btnInsertar_Click"   />
                    </div>

             <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblError" runat="server" Text="Se produjo un error, intentelo de nuevo"></asp:Label></span>
        </div>

            <div class="col-lg-12 col-md-offset-2 alert alert-success close" id="lblExito"  role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblSuccess" runat="server" Text="Se ha ejecutado correctamente"></asp:Label></span>
        </div>
            </div>


     <div class="container" style="margin-top: 50px;">
        <div class="row">
              <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px">
            <div class="col-md-6" style="font-size: 20px; font-weight: 400"">

                  <div class="form-group">
                <label for="txtBuscar">Combustibles Disponibles</label>
                      </div>
                  <div class="form-group" style="margin-top: 50px;">
                  <asp:Button ID="btnModificar" runat="server" Text="Modificar combustible" CssClass="btn btn-primary btn-lg btn-block" BackColor="#32E0C4 " BorderColor="#32E0C4" ForeColor="White" OnClick="btnModificar_Click"   />

                      </div>
            </div>
                <div class="col-md-5 col-md-offset-1" >

                      <div class="form-group">
                        <asp:DropDownList ID="ddlCombustible" runat="server" BackColor="#2e52db"  ForeColor="#F2F6FE"  CssClass="ddl2" ></asp:DropDownList>
                          </div>

                      <div class="form-group" style="margin-top: 50px;">

                           <asp:Button ID="btnEliminar" runat="server" Text="Eliminar combustible" CssClass="btn btn-primary btn-lg btn-block" BackColor="#FF004D " BorderColor="#FF004D" ForeColor="White" OnClick="btnEliminar_Click"  />
                          </div>
            </div>
        </div>
            </div>
     </div>



    <div class="container" style="margin-top: 50px;">
        <div class="row">
              <div class="col-md-8" style="background-color: transparent;border-radius: 15px; padding: 40px 50px 40px 40px">
            <div class="col-md-5" style="font-size: 20px; font-weight: 400"">
                <label  runat="server" id="titulo">Digite el nuevo combustible</label>
            </div>
                <div class="col-md-5 col-md-offset-1">
                        <input type="text" class="form-control" id="txtModificar" runat="server" placeholder="Ingrese el nuevo combustible">
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
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar combustible" CssClass="btn btn-primary btn-lg btn-block" BackColor="#2e52db " BorderColor="#2e52db" ForeColor="White" OnClick="btnActualizar_Click"  />
                    </div>

 
            </div>
</asp:Content>
