<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAIdea.aspx.cs" Inherits="TTxApp1.CreateAIdea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet"/>
     <link rel="stylesheet" href="./CreateAIdea.css"/>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/TTX Logo White.png" OnClick="ImageButton1_Click"/>
          <asp:Button ID="Logout" runat="server" class="btn btn-danger" Text="Logout" OnClick="Logout_Click" />


        <asp:Label ID="lblMessageidea" runat="server" Text=""></asp:Label>
   
        <div>
            
          <asp:Label ID="Title"  runat="server" Text="Idea Title:"></asp:Label>  <asp:TextBox ID="Titletxt" runat="server" Wrap="true" columns="70" TextMode="MultiLine" MaxLength="100" ></asp:TextBox>
        </div>


        <div>
            <asp:Label ID="Idea" runat="server" Text="Leave A Idea:"></asp:Label>
            <asp:TextBox ID="Ideatxt" runat="server" TextMode="MultiLine" MaxLength="2000" Rows="13" columns="70" EnableViewState="True" Wrap="true"></asp:TextBox>
        </div>

         <div>           
            <asp:TextBox ID="Employeetxt" runat="server"></asp:TextBox>
        </div>


        <asp:Button ID="btnIdea" runat="server" Text="Submit Idea" OnClick="btnIdea_Click" />


    </form>
</body>
</html>
