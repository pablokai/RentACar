<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetallesAlquiler.aspx.cs" Inherits="RentACar.Pages.DetallesAlquiler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="../Content/Detalle.css" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;600;700&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
       
       
            <div class="titulo" style="background-color: transparent; color: white; border-radius: 15px; padding: 30px 10px 30px 40px">
                Detalles del Alquiler
            </div>
   


     <div class="nav">

            <div class="col-md-6">

             
                        <label for="txtSalida" >Fecha de salida</label>
                        <%--<input type="text" class="form-control" id="txtModelo" runat="server" placeholder="Ingrese el modelo del vehiculo" required="required">--%>
                           <input type="date" class="in" id="txtSalida" runat="server" />
                                 
                       <label for="txtEntrega">Fecha de Entrega</label>
                       
                           <input type="date" class="in" id="txtEntrega" runat="server" />
                
                    <asp:Button ID="btnFormalizar" runat="server" Text="Formalizar" CssClass="btn" ForeColor="White" BackColor="#1CCFF5" BorderColor="#1CCFF5" OnClick="btnFormalizar_Click"  />

                <asp:Button ID="btnSeguro" runat="server" Text="Agregar seguro" CssClass="btn" ForeColor="White" OnClick="btnSeguro_Click"  />

                </div>
       
         
        </div>
             <div class="container">
        
            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                    </div>
            </div>


         <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" >
        <span aria-hidden="true"><asp:Label ID="lblError" runat="server" Text="Error, inténtelo de nuevo" Font-Size="20px" BackColor="#FF004D" CssClass="mensaje" ></asp:Label></span>
        </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito"  role="alert" runat="server" visible="false" style="margin-top: 20px" >
        <span aria-hidden="true"><asp:Label ID="lblSuccess" runat="server" Text="Se ha formalizado el alquiler" CssClass="mensaje"></asp:Label></span>
        </div>

                  </div>

        <div class="titulo" style="background-color: transparent; color: white; border-radius: 15px; padding: 30px 10px 30px 40px;" id="titulo" runat="server">
            Agregar Seguro
        </div>
           <div class="nav" runat="server" id="bloque">

            <div class="col-md-6">

                        <label for="txtMonto" >Monto Seguro</label>
                        <%--<input type="text" class="form-control" id="txtModelo" runat="server" placeholder="Ingrese el modelo del vehiculo" required="required">--%>
                           <input type="number" class="in" id="txtMonto" runat="server" />

                  <label for="ddlPerdida">Cubrir Pérdida total</label>

                <asp:DropDownList ID="ddlPerdida" runat="server" CssClass="ddl">
                    <asp:ListItem>Si</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:DropDownList>
                  <label for="ddlGasto">Cubrir Gasto Ocupante</label>

                <asp:DropDownList ID="ddlGasto" runat="server" CssClass="ddl">
                    <asp:ListItem>Si</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:DropDownList>
                
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn" ForeColor="White" BackColor="#1CCFF5" BorderColor="#1CCFF5" OnClick="btnAgregar_Click"  />


                </div>
       
         
        </div>

         <div class="container">
        
            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                    </div>
            </div>


         <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblError2" role="alert" runat="server" visible="false" style="margin-top: 20px" >
        <span aria-hidden="true"><asp:Label ID="lblErr" runat="server" Text="Error, inténtelo de nuevo" Font-Size="20px" BackColor="#FF004D" CssClass="mensaje" ></asp:Label></span>
        </div>

            <div class="col-lg-8 col-md-offset-2 alert alert-success close" id="lblExito2"  role="alert" runat="server" visible="false" style="margin-top: 20px" >
        <span aria-hidden="true"><asp:Label ID="lblEx" runat="server" Text="Se ha guardado el seguro" CssClass="mensaje"></asp:Label></span>
        </div>

                  </div>

                        <div class ="nav">
                            <asp:Button ID="btnSalir" runat="server" Text="Salir" CssClass="btn" ForeColor="White" BackColor="#FF004D" BorderColor="#FF004D" OnClick="btnSalir_Click"  />
                        </div>
                    


                



    </form>
</body>
</html>
