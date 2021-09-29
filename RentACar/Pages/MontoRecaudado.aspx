<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MontoRecaudado.aspx.cs" Inherits="RentACar.Pages.MontoRecaudado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


      <!-- VALIDACION -->
    <div class="container">
        <div class="row" style="margin: 30px 0 30px 0; font-size: 35px; font-weight: 600">
            <div class="col-md-8" style="background-color: #2e52db; color:#E6EBF4; border-radius: 15px; padding: 30px 10px 30px 40px">
                Consulta de monto recaudado por día
            </div>
        </div>
    </div>

    <div class="container"">
        <div class="row">
              <div class="col-md-8" style="background-color: #ffffff;border-radius: 15px; padding: 40px 50px 40px 40px">
            <div class="col-md-5" style="font-size: 20px; font-weight: 400"">
                <label for="txtFecha">Fecha del consulta</label>
            </div>
                <div class="col-md-5 col-md-offset-1">
                        <input type="date" class="form-control" id="txtFecha" runat="server" placeholder="Ingrese la fecha a buscar">
            </div>
        </div>
            </div>
     </div>

    

    <script >

        function hola() {

            //document.getElementById("contador").style.display = "block";


            /*var x = document.getElementById("contador");

            // If selected element is hidden
            if (x.style.display === "none") {

                // Show the hidden element
                x.style.display = "block";

                // Else if the selected element is shown
            } else {

                // Hide the element
                x.style.display = "none";
            }*/


            var html = document.getElementById("<%=num.ClientID %>").innerHTML;
            //alert(html);

            var project = setInterval(projectDone, 1)
            let count1 =html-200 ;

            function projectDone() {
                count1++
                document.querySelector("#number1").innerHTML = count1
                if (count1 == html) {
                    clearInterval(project)
                }
            }

        }

    </script>

        <div class="container">
        
            <div class="row">
                <div class="col-lg-12" style="margin: 10px 0px 10px 0px">
                    </div>
            </div>
            
             <div class="col-lg-12 col-md-offset-2" style="padding-bottom: 20px">
                        <asp:Button ID="btnBuscar" runat="server" Text="Asignar fecha" CssClass="btn btn-primary btn-lg btn-block" BackColor="#1CCFF5 " BorderColor="#1CCFF5" ForeColor="White" OnClick="btnConsultar_Click" />

                  <input type="button" onclick="hola()" value="Calcular monto"  runat="server" id="btnCalcular" class="btn btn-primary btn-lg btn-block" style="background-color:#2e52db;" visible="false">


                    <span id="miLabel"> <asp:Label ID="num" runat="server" Text="0" Visible="true" ForeColor="#f3f7fe"></asp:Label></span>

                    </div>

           
        

             <div class="col-lg-12 col-md-offset-2 alert alert-danger close" id="lblMensajeError" role="alert" runat="server" visible="false" style="margin-top: 20px" data-dismiss="alert">
        <span aria-hidden="true">&times;<asp:Label ID="lblError" runat="server" Text="Se produjo un error, no hay registros en esa fecha"></asp:Label></span>
        </div>
            </div>

         


    <div id="contador" class="seccion" runat="server" visible="false">


<%--        <input type="button" onclick="hola()" value="funciona">


         <span id="miLabel"> <asp:Label ID="num" runat="server" Text="0"></asp:Label></span>--%>


        <ul style="list-style-type: none;">
            <li>
                <p  style="font-size: 50px; font-weight: bold; font-family: Poppins;">Total  <i style="margin:15px;" class="fas fa-dollar-sign fa-1x"></i>  </p>
                <p  id="number1" class="number">0</p>
                <span></span>
                
            </li>
            
        </ul>

    </div>

       

</asp:Content>
