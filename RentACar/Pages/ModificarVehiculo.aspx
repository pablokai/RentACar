<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarVehiculo.aspx.cs" Inherits="RentACar.Pages.ModificarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <!-- VALIDACION -->
    <div class="container">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div class="col-md-8" style="background-color: #2e52db; color:#E6EBF4; border-radius: 15px; padding: 30px 10px 30px 40px">
                Ingrese la placa del vehículo a modificar
            </div>
        </div>
    </div>

    <div class="container"">
        <div class="row">
              <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px">
            <div class="col-md-5" style="font-size: 20px; font-weight: 400"">
                <label for="txtModificar">Placa</label>
            </div>
                <div class="col-md-5 col-md-offset-1">
                        <input type="text" class="form-control" id="txtModificar" runat="server" placeholder="Ingrese la placa del vehículo">
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
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar vehículo" CssClass="btn btn-primary btn-lg btn-block" BackColor="#1CCFF5 " BorderColor="#1CCFF5" ForeColor="White" OnClick="btnBuscar_Click" />
                    </div>

             <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="Div1" role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="Label1" runat="server" Text="Se produjo un error,la placa no existe"></asp:Label></span>
        </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="Div2"  role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="Label2" runat="server" Text="La placa si existe"></asp:Label></span>
        </div>
            </div>

    <!-- VALIDACION -->

         <div class="container" id="titulo" runat="server">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div class="col-md-8" style="background-color: #2e52db; color: #f3f7fe; border-radius: 15px; padding: 30px 10px 30px 40px">
                Ingrese los nuevos datos del vehículo
            </div>
        </div>
    </div>
    <div class="container" id="bloque" runat="server" >
        <div class="row">
            <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px">
                

                <div class="col-md-6" >
<%--                    <div class="form-group">
                        <asp:Label ID="lblPlaca" runat="server" Text="Placa" CssClass="label"></asp:Label>   
                        <input type="text" class="form-control" id="txtPlaca" runat="server" placeholder="Ingrese la placa del vehiculo" required="required">
                    </div>--%>
                    <div class="form-group">
                        <asp:Label ID="lblModelo" runat="server" CssClass="lbl" Text="Modelo"  ForeColor="#000000" Font-Size="16px"></asp:Label>   
                        <%--<input type="text" class="form-control" id="txtModelo" runat="server" placeholder="Ingrese el modelo del vehiculo" required="required">--%>
                        <asp:DropDownList ID="ddlModelo" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblMarca" runat="server" Text="Marca" CssClass="lbl" ForeColor="#000000" Font-Size="16px"></asp:Label>
                       <%-- <input type="text" class="form-control" id="txtMarca" runat="server" placeholder="Ingrese la marca del vehiculo" required="required">--%>
                        <asp:DropDownList ID="ddlMarca" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl"></asp:DropDownList>
                    </div>


                    <div class="form-group">
                        <asp:Label ID="lblAnnio" runat="server" Text="Año" CssClass="lbl" ForeColor="#000000" Font-Size="16px"></asp:Label>
                        <input type="date" class="form-control" id="txtAnnio" runat="server" placeholder="Ingrese el año del vehículo" required="required">
                </div>

                       <div class="form-group">
                        <asp:Label ID="lblEstado" runat="server" Text="Estado" CssClass="lbl" ForeColor="#000000" Font-Size="16px"></asp:Label>
                        <asp:DropDownList ID="ddlEstado" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl">
                            <asp:ListItem>Seleccione...</asp:ListItem>
                            <asp:ListItem>Disponible</asp:ListItem>
                            <asp:ListItem>Ocupado</asp:ListItem>
                        </asp:DropDownList>                       
                   </div>


                    </div>

                <div class="col-md-6">


                 
                    
                    <div class="form-group">
                        <asp:Label ID="lblColor" runat="server" Text="Color" CssClass="lbl" ForeColor="#000000" Font-Size="16px"></asp:Label>
                       <%-- <input type="text" class="form-control" id="txtColor" runat="server" placeholder="Ingrese el color del vehiculo" required="required">--%>
                         <asp:DropDownList ID="ddlColor" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl"></asp:DropDownList>
                    </div>

                   
                      <div class="form-group">
                          <asp:Label ID="lblCosto" runat="server" Text="Costo" CssClass="lbl" ForeColor="#000000" Font-Size="16px"></asp:Label>
                        <input type="number" class="form-control" id="txtCosto" runat="server" placeholder="Ingrese el costo del vehiculo" required="required">
                    </div>

                       <div class="form-group">
                           <asp:Label ID="lblCombustible" runat="server" Text="Combustible" CssClass="lbl" ForeColor="#000000" Font-Size="16px"></asp:Label>
                        <asp:DropDownList ID="ddlCombustible" runat="server" BackColor="#1CCFF5" ForeColor="#F2F6FE"  CssClass="ddl">
                        </asp:DropDownList>                       
                    </div>

                       <div class="form-group">
                           <asp:Label ID="lblTipo" runat="server" Text="Tipo" CssClass="lbl" ForeColor="#000000" Font-Size="16px"></asp:Label>
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
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary btn-lg btn-block" BackColor="#2e52db" BorderColor="#2e52db" ForeColor="White" OnClick="btnModificar_Click" />
                    </div>
           


         <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblError" runat="server" Text="Se produjo un error , inténtelo de nuevo"></asp:Label></span>
        </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito"  role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblSuccess" runat="server" Text="Se han modificado los datos"></asp:Label></span>
        </div>

                  </div>
</asp:Content>
