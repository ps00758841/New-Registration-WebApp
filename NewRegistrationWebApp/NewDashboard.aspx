<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewDashboard.aspx.cs" Inherits="NewRegistrationWebApp.NewDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Helper/css/style.default.css" rel="stylesheet" />
    <link href="Helper/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class=" page-holder d-flex ">
            
                    <div style="height: 500px; width:100%; background-color: White; padding: 10px; overflow: auto">
                    
                        <div class="gridDiv">
                             <asp:GridView ID="grvEmployee" runat="server"  CssClass="table table-striped" AutoGenerateColumns="true"> </asp:GridView>  
                        </div>
                    </div>
                  
                </div>
          
    </form>
</body>
</html>
