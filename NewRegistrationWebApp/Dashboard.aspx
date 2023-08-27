<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="NewRegistrationWebApp.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Helper/css/style.default.css" rel="stylesheet" />
    <link href="Helper/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .logout-button {
            position: absolute;
            top: 20px;
            right: 20px;
        }
    </style>
</head>
<body>
   
    <form id="form1" runat="server">
        <h1 style="margin-left: 475px;">Registration Details</h1>
        <div class=" page-holder d-flex align-items-center">

            <div style="height: 500px; width: 100%; background-color: White; padding: 10px; overflow: auto">

                <div class="gridDiv">
                    <asp:GridView ID="grvEmployee" runat="server" CssClass="table table-striped" AutoGenerateColumns="true"></asp:GridView>
                </div>
            </div>
        </div>

        <div class="col-lg-4 px-lg-4">
            <h1 class="text-base text-primary text-uppercase mb-4">Enter mail to delete user details</h1>
            <h2 class="mb-4">Delete Records!</h2>

            <div class="form-group mb-4">
                <asp:TextBox CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Email" ID="TxtLoginUsername_deleteRequest" runat="server"></asp:TextBox>

            </div>
            <asp:Button Text="Delete" Required ="true" CssClass="btn btn-primary" Height="50px" Width="200px" runat="server" OnClientClick="return alert_meth()" OnClick="DeleteClick" />
        </div>

        <div class="logout-button"> 
            <asp:Button ID="LogoutButton" Text="Logout" CssClass="btn btn-primary" runat="server" OnClick="LogoutClick"/>
        </div>

        <div class=""> 
            <asp:Label ID="DeleteRequestLabel" style="margin-left: 500px;margin-top:-100px;" runat="server" Text=""></asp:Label> 
        </div>

    </form>
</body>
</html>
