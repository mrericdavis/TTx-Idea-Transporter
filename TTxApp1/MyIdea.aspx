<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyIdea.aspx.cs" Inherits="TTxApp1.MyIdea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
         <link href="Content/bootstrap.css" rel="stylesheet"/>
         <link rel="stylesheet" href="./MyIdea.css"/>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/TTX Logo White.png" OnClick="ImageButton1_Click" />
         <asp:Button ID="Logout" runat="server" class="btn btn-danger" Text="Logout" OnClick="Logout_Click" />
            <asp:GridView 
                ID="GridView1" runat="server" HorizontalAlign="Center" ShowHeader="True"  CellPadding="10" Height="500px" Width="50%"   PageSize ="4" Style="text-align:center;" GridLines="Vertical" CellSpacing="10">
               <RowStyle HorizontalAlign="Center"></RowStyle>
            </asp:GridView>

    </form>
</body>
</html>
