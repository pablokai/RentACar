<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RentACar.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h3>  
      Login Page</h3>  
            <table>  
                <tr>  
                    <td>  
          UserName:</td>  
                    <td>  
                        <asp:TextBox ID="UserName" runat="server" />  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"   
            ControlToValidate="UserName"  
            Display="Dynamic"   
            ErrorMessage="Cannot be empty."   
            runat="server" />  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
          Password:</td>  
                    <td>  
                        <asp:TextBox ID="UserPass" TextMode="Password"   
             runat="server" />  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"   
            ControlToValidate="UserPass"  
            ErrorMessage="Cannot be empty."   
            runat="server" />  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
          Remember me?</td>  
                    <td>  
                        <asp:CheckBox ID="chkboxPersist" runat="server" />  
                    </td>  
                </tr>  
            </table>  
            <asp:Button ID="btnLogin" OnClick="btnLogin_Click" Text="Log In"   
       runat="server" />  
            <p>  
                <asp:Label ID="Msg" ForeColor="red" runat="server" />  
            </p>  
</asp:Content>
