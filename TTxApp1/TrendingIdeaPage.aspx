<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrendingIdeaPage.aspx.cs" Inherits="TTxApp1.TrendingIdeaPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="./TrendingIdeaPage.css"/>
    <title></title>

 <style type="text/css">
    .hideGridColumn
    {
        display:none;
    }

    #Logout{
        position:absolute;
        margin-left:85%;
        width:10%;
        margin-top: -5%;
        border-style:dashed;
        border-color:white;
    }
 </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/TTX Logo White.png" OnClick="ImageButton1_Click" />
         <asp:Button ID="Logout" runat="server" class="btn btn-danger" Text="Logout" OnClick="Logout_Click" />
        </div>
<div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" pagesize="4" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" DataKeyNames="IID" CellPadding="1" Height="500px" Width="50%" AllowSorting="True" Style="text-align:left;"  >
        <Columns>
            <asp:BoundField DataField="Ptsvoting" HeaderText="Points" SortExpression="Ptsvoting" >
            <ControlStyle BorderColor="#FF6600" />
            <HeaderStyle BackColor="#FF6600" VerticalAlign="Top" Width="20%" />
            <ItemStyle Width="20%" />
            </asp:BoundField>
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title">

            <ControlStyle BorderColor="#FF6600" />

            <HeaderStyle BackColor="#FF6600" VerticalAlign="Top" Width="60%" />
            
            </asp:BoundField>

            <asp:CommandField ShowSelectButton="True" SelectText="View Idea" >
            <ControlStyle BorderColor="#FF6600" />
            <HeaderStyle BackColor="#FF6600" />
            
            </asp:CommandField>
            <asp:BoundField DataField="Idea" HeaderText="Idea" HeaderStyle-CssClass = "hideGridColumn" ItemStyle-CssClass="hideGridColumn" SortExpression="Idea" >
<HeaderStyle CssClass="hideGridColumn"></HeaderStyle>

<ItemStyle CssClass="hideGridColumn"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="IID" HeaderText="IID" HeaderStyle-CssClass = "hideGridColumn" ItemStyle-CssClass="hideGridColumn" InsertVisible="False" ReadOnly="True" SortExpression="IID" >
<HeaderStyle CssClass="hideGridColumn"></HeaderStyle>

<ItemStyle CssClass="hideGridColumn"></ItemStyle>
            </asp:BoundField>
        </Columns>



    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GetPWDConnectionString %>" SelectCommand="SELECT Ptsvoting, Ideas.Title, Ideas.Idea, Ideas.IID FROM UserAccounts INNER JOIN Employees ON UserAccounts.EmployeeID = Employees.EmployeeID INNER JOIN Ideas ON UserAccounts.LoginID = Ideas.LoginID order by IID desc;"></asp:SqlDataSource>
</div>
        
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>


    </form>
</body>
</html>
