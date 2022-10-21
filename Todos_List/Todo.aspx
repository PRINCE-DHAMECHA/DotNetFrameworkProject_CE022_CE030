<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Todo.aspx.cs" Inherits="Todos_List.Todo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;
            
          Username :   <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Add New Items.."></asp:Label>
            <br />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label> :
            <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Date"></asp:Label> : 
             <asp:TextBox ID="s_date" runat="server" TextMode="Date" ></asp:TextBox>
        </p>
       
        <p>
            <asp:Label ID="Label5" runat="server" Text="Description"></asp:Label> :
            <asp:TextBox ID="desctxt" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        </p>
        <div>
           <asp:Button runat="server" OnClick="Button2_Click" Text="Logout"/>
        </div>
    </form>
</body>
</html>

