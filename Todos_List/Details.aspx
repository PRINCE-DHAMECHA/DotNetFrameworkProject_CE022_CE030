<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Todos_List.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <p><asp:Label ID="usrnm" runat="server"></asp:Label></p>
            <br />
            <asp:Button runat="server" OnClick="Buttun1_Click" Text="Todo"/>
            <asp:GridView ID="GridView1" runat="server" >
           
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Todo]"></asp:SqlDataSource>
          <asp:Button runat="server" onClick="Button2_Click" Text="logout"/>
           
        </div>
    </form>
</body>
</html>