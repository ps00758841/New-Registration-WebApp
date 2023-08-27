<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid_View_Demo.aspx.cs" Inherits="NewRegistrationWebApp.Grid_View_Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" CssClass="Grid" runat="server" OnRowDeleting="OnRowDeleting" AutoGenerateColumns="false" OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
          <Columns>
    <asp:CommandField ShowDeleteButton="True"  ButtonType="Button" />
    <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
    <asp:BoundField DataField="LastName" HeaderText="LastName" />
   
   
    
</Columns> 
</asp:GridView>
        </div>
      
    </form>
</body>
</html>
