<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPoints.aspx.cs" Inherits="TTxApp1.MyPoints" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="Content/bootstrap.css" rel="stylesheet"/>
     <link rel="MyPoints" href="./MyPoints.css"/>


        <style type="text/css">
body {
    background-size: cover;
    background: url('/Images/railroad.jpg') no-repeat center center fixed;
}

#Points{
    font-size: 100px;
    color:white;
}

#ImageButton1 {
    display:block;
    padding-top:1%;
    margin: 0 auto;
    width: 250px;
}

.hideGridColumn {
    display: none;
}

#Logout {
    position: absolute;
    margin-left: 85%;
    width: 10%;
    margin-top: -4%;
    border-style:dashed;
    border-color:white;
}

#form1{
    background-color:orangered;
    
}

.pad{
background-color: blue;
margin-top:40%;
}
#GridView1 {
    display:grid;
    border-radius: 5px;
    font-size: 90px;
    color: white;
    margin-left: 10%;
    font-family: Arial;
    font-family: Impact, Haettenschweiler, 'Arial Narrow Bold', sans-serif; 
    background-color: orangered;
    margin-bottom:3%;
    position: center;
    vertical-align: middle;
    
    
   

}
    </style>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/TTX Logo White.png" OnClick="ImageButton1_Click"/>
         <asp:Button ID="Logout" runat="server" class="btn btn-danger" Text="Logout" OnClick="Logout_Click" />
        </div>
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server" ShowHeader="true"  CellSpacing="70" CellPadding="70" Height="1px" Width="50px"></asp:GridView>
        </div>
    </form>
</body>
</html>
