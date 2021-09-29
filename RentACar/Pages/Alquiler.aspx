<%@ Page Language="C#" AutoEventWireup="true"  MaintainScrollPositionOnPostback="true" CodeBehind="Alquiler.aspx.cs" Inherits="RentACar.Pages.Alquiler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="../Content/Alquiler.css" />
     <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;600;700&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div class="titulo" style="background-color: transparent; color: white; border-radius: 15px; padding: 30px 10px 30px 40px">
                Alquiler de vehículos
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px; text-align: center;">
                

                <div class="col-md-6"  >
                    <div class="form-group">
                        <label for="txtModelo">Modelo </label>
                        <%--<input type="text" class="form-control" id="txtModelo" runat="server" placeholder="Ingrese el modelo del vehiculo" required="required">--%>
                         <asp:DropDownList ID="ddlModelo" runat="server"   CssClass="ddl"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        
                        <label for="txtMarca">Marca</label>
                        <%--<input type="text" class="form-control" id="txtMarca" runat="server" placeholder="Ingrese la marca del vehiculo" required="required">--%>

                         <asp:DropDownList ID="ddlMarca" runat="server"   CssClass="ddl"></asp:DropDownList>
                    </div>


                     <div class="form-group">
                        
                        <label for="txtCosto">Costo Mínimo</label>
                        <%--<input type="text" class="form-control" id="txtMarca" runat="server" placeholder="Ingrese la marca del vehiculo" required="required">--%>

                          <input type="number" class="in"  id="txtCosto" runat="server" placeholder="Ingrese el costo del vehículo"/>
                    </div>
                   

                    <div class="form-group">
                        <label for="txtAnnio">Año</label>
                        <asp:DropDownList ID="ddlAnnio" runat="server"  CssClass="ddl">

                            <asp:ListItem>2021</asp:ListItem>
                            <asp:ListItem>2020</asp:ListItem>
                            <asp:ListItem>2019</asp:ListItem>
                            <asp:ListItem>2018</asp:ListItem>
                            <asp:ListItem>2017</asp:ListItem>
                            <asp:ListItem>2016</asp:ListItem>
                            <asp:ListItem>2015</asp:ListItem>
                            <asp:ListItem>2014</asp:ListItem>
                            <asp:ListItem>2013</asp:ListItem>
                            <asp:ListItem>2012</asp:ListItem>
                            <asp:ListItem>2011</asp:ListItem>
                            <asp:ListItem>2010</asp:ListItem>
                            <asp:ListItem>2009</asp:ListItem>
                            <asp:ListItem>2008</asp:ListItem>
                            <asp:ListItem>2007</asp:ListItem>
                            <asp:ListItem>2006</asp:ListItem>
                            <asp:ListItem>2005</asp:ListItem>
                            <asp:ListItem>2004</asp:ListItem>

                            <asp:ListItem>2003</asp:ListItem>
                            <asp:ListItem>2002</asp:ListItem>
                            <asp:ListItem>2001</asp:ListItem>
                            <asp:ListItem>2000</asp:ListItem>
                            <asp:ListItem>1999</asp:ListItem>
                            <asp:ListItem>1998</asp:ListItem>
                            <asp:ListItem>1997</asp:ListItem>
                            <asp:ListItem>1996</asp:ListItem>
                            <asp:ListItem>1995</asp:ListItem>
                            <asp:ListItem>1994</asp:ListItem>
                            <asp:ListItem>1993</asp:ListItem>
                            <asp:ListItem>1992</asp:ListItem>
                            <asp:ListItem>1991</asp:ListItem>
                            <asp:ListItem>1990</asp:ListItem>
                            <asp:ListItem>1989</asp:ListItem>
                            <asp:ListItem>1988</asp:ListItem>
                            <asp:ListItem>1987</asp:ListItem>
                            <asp:ListItem>1986</asp:ListItem>
                             <asp:ListItem>1985</asp:ListItem>
                            <asp:ListItem>1984</asp:ListItem>
                            <asp:ListItem>1983</asp:ListItem>
                            <asp:ListItem>1982</asp:ListItem>
                            <asp:ListItem>1981</asp:ListItem>
                            <asp:ListItem>1980</asp:ListItem>
                        </asp:DropDownList>   
                </div>

                  

                    </div>

                <div class="col-md-6">
               
                    
                    <div class="form-group">
                        <label for="txtColor">Color</label>
                        <%--  <input type="text" class="form-control" id="txtColor" runat="server" placeholder="Ingrese el color del vehiculo" required="required">--%>
                         <asp:DropDownList ID="ddlColor" runat="server"  CssClass="ddl"></asp:DropDownList>
                    </div>


                       <div class="form-group">
                        <label for="txtCombustible">Combustible</label>
                        <asp:DropDownList ID="ddlCombustible" runat="server" CssClass="ddl" >                        
                        </asp:DropDownList>                       
                    </div>

                       <div class="form-group">
                        <label for="ddlTipo">Tipo</label>

                        <asp:DropDownList ID="ddlTipo" runat="server" CssClass="ddl">
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
                        <asp:Button ID="btnIngresar" runat="server" Text="Buscar" CssClass="button" ForeColor="White" OnClick="btnIngresar_Click" />
                    </div>
           


         <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" >
        <span aria-hidden="true">&times;<asp:Label ID="lblError" runat="server" Text="No existe ningún vehículo que cumpla con los requisitos" Font-Size="20px" BackColor="#FF004D" ></asp:Label></span>
        </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito"  role="alert" runat="server" visible="false" style="margin-top: 20px" >
        <span aria-hidden="true">&times;<asp:Label ID="lblSuccess" runat="server" Text="Se ha ingresado un nuevo vehículo"></asp:Label></span>
        </div>

                  </div>

        <div class="container">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div  id="titulo" class="titulo" style="background-color: transparent; color: white; border-radius: 15px; padding: 30px 10px 30px 40px" runat="server">
                Vehículos disponibles
            </div>
        </div>
    </div> 
    <div class="container">
        <label style="text-align: center; color: white;" runat="server" id="instruccion">Seleccione el vehículo que desea rentar:</label>
     <div class="row" style="margin-top: 30px" visible="true">
                    <asp:GridView ID="gvVehiculos" runat="server" CssClass="tabla" AutoGenerateColumns="False" GridLines="Both"  SelectedRowStyle-ForeColor="#FF3399" Visible="False" OnSelectedIndexChanged="gvVehiculos_SelectedIndexChanged" AutoGenerateSelectButton="True" Height="35px" Width="350px" BorderStyle="Solid" BorderWidth="5px">
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
                        <asp:Button ID="btnAvanzar" runat="server" Text="Avanzar" CssClass="button" ForeColor="White" OnClick="btnAvanzar_Click" />
                    </div>
           

                  </div>

    </form>
</body>
</html>
