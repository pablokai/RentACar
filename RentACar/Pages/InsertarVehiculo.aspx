<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarVehiculo.aspx.cs" Inherits="RentACar.Pages.InsertarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <div class="container">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div class="col-md-8" style="background-color: #2e52db; color: #f3f7fe; border-radius: 15px; padding: 30px 10px 30px 40px">
                Ingrese los datos del vehículo
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px">
                

                <div class="col-md-6"  >
                    <div class="form-group">
                        <label for="txtPlaca" id="txtPlaca" style="font-weight: bold !important;">Placa </label>
                        <input type="text" class="form-control" id="txtPlaca" runat="server" placeholder="Ingrese la placa del vehiculo" required="required">
                    </div>
                    <div class="form-group">
                        <label for="txtModelo">Modelo </label>
                        <%--<input type="text" class="form-control" id="txtModelo" runat="server" placeholder="Ingrese el modelo del vehiculo" required="required">--%>
                         <asp:DropDownList ID="ddlModelo" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        
                        <label for="txtMarca">Marca</label>
                        <%--<input type="text" class="form-control" id="txtMarca" runat="server" placeholder="Ingrese la marca del vehiculo" required="required">--%>

                         <asp:DropDownList ID="ddlMarca" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl"></asp:DropDownList>
                    </div>


                    <div class="form-group">
                        <label for="txtAnnio">Año</label>
                        <input type="date" class="form-control" id="txtAnnio" runat="server" placeholder="Ingrese el año del vehículo" required="required">
                </div>

                  

                    </div>

                <div class="col-md-6">


                    <div class="form-group">
                        <label for="ddlEstado">Estado</label>
                        <asp:DropDownList ID="ddlEstado" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl">
                            <asp:ListItem>Seleccione...</asp:ListItem>
                            <asp:ListItem>Disponible</asp:ListItem>
                            <asp:ListItem>Ocupado</asp:ListItem>
                        </asp:DropDownList>                       
                   </div>
               
                    
                    <div class="form-group">
                        <label for="txtColor">Color</label>
                      <%--  <input type="text" class="form-control" id="txtColor" runat="server" placeholder="Ingrese el color del vehiculo" required="required">--%>
                         <asp:DropDownList ID="ddlColor" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl"></asp:DropDownList>
                    </div>

                   
                      <div class="form-group">
                        <label for="txtCosto">Costo</label>
                        <input type="number" class="form-control" id="txtCosto" runat="server" placeholder="Ingrese el costo del vehiculo" required="required">
                    </div>

                       <div class="form-group">
                        <label for="txtCombustible">Combustible</label>
                        <asp:DropDownList ID="ddlCombustible" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl" >                        
                        </asp:DropDownList>                       
                    </div>

                       <div class="form-group">
                        <label for="ddlTipo">Tipo</label>

                        <asp:DropDownList ID="ddlTipo" runat="server" BackColor="#1CCEF4" ForeColor="#F2F6FE" CssClass="ddl">
                             </asp:DropDownList>
                    </div>

                    
                </div>
       

        </div>

            

            </div>
        </div>


             <div class="container">
        
            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                    </div>
            </div>
            
             <div class="col-lg-12 col-md-offset-2">
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary btn-lg btn-block" BackColor="#2e52db" BorderColor="#2e52db" ForeColor="White" OnClick="btnIngresar_Click" />
                    </div>
           


         <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblError" runat="server" Text="Se produjo un error , intentelo de nuevo"></asp:Label></span>
        </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito"  role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblSuccess" runat="server" Text="Se ha ingresado un nuevo vehículo"></asp:Label></span>
        </div>

                  </div>
</asp:Content>
