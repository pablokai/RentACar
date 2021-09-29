<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RentACar._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <div class="row" style="margin-top: 160px">
        <div class="col-md-6">
            <h1 class="title">Bienvenido al sistema de Rent A Car</h1>
           
        </div>
        <div class="col-md-6">
           
            <img src="../Images/car.svg" width="600" height="600" style="margin-right: 10px;" />
        </div>
    </div>

    <style>
        
        .title {
            font-family: Poppins;
            font-weight: bold;
            font-size: 70px;
            margin: 120px 0px 0px 0px;
            letter-spacing: normal;
        }

        
    </style>

</asp:Content>
