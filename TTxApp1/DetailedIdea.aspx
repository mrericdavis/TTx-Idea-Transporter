<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailedIdea.aspx.cs" Inherits="TTxApp1.DetailedIdea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

 <link href="Content/bootstrap.css" rel="stylesheet" />
 <link rel="stylesheet" href="./DetailedIdea.css"/>




    <style type="text/css">
        .auto-style6 {
            width: 300px;
        }
        .auto-style7 {
            width: 588px;
        }

#Logout {
    position: absolute;
    margin-left: 85%;
    width: 10%;
    margin-top: -6%;
    border-style:dashed;
    border-color:white;
}
    </style>




    </head>
<body>
    <form id="form1" runat="server">
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/TTX Logo White.png" OnClick="ImageButton1_Click"/>
         <asp:Button ID="Logout" runat="server" class="btn btn-danger" Text="Logout" OnClick="Logout_Click" />

         <div>           
            <asp:TextBox ID="Employeetxt" runat="server" BorderStyle="None" visible="false"></asp:TextBox>
        </div>
  <div>
        <table class="co">
            <tr>
                <td class="auto-style5">Title:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="Title1" runat="server" height="200px" Width="800px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Idea:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="Idea1" runat="server" height="200px" Width="800px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
        </table>
  </div>


      <div class="stars">
        <asp:ImageButton ID="EmptyStar1" runat="server" ImageUrl="~/if_Star-Empty_49623.png" OnClick="EmptyStar1_Click" CausesValidation="False" />
        <asp:ImageButton ID="EmptyStar2" runat="server" ImageUrl="~/if_Star-Empty_49623.png" OnClick="EmptyStar2_Click" />
        <asp:ImageButton ID="EmptyStar3" runat="server" ImageUrl="~/if_Star-Empty_49623.png" OnClick="EmptyStar3_Click" />
        <asp:ImageButton ID="EmptyStar4" runat="server" ImageUrl="~/if_Star-Empty_49623.png" OnClick="EmptyStar4_Click" />
        <asp:ImageButton ID="EmptyStar5" runat="server" ImageUrl="~/if_Star-Empty_49623.png" OnClick="EmptyStar5_Click" />
      </div>
    </form>
</body>
</html>
