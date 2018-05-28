<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyAccountPage.aspx.cs" Inherits="TTxApp1.MyAccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./MyAccount.css"/>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="Content/bootstrap.css" rel="stylesheet" >
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<asp:ImageButton ID="ImageButton1" runat="server" Class="img-fluid" ImageUrl="~/Images/TTX Logo White.png" OnClick="ImageButton1_Click1"/>
 //<asp:Button ID="Logout" runat="server" class="btn btn-danger" Text="Logout" OnClick="Logout_Click" />     
               <div class="text-center"> 
                       <h1 id="font">My Account </h1>
               </div>
         <div class="container">
           <div class="row">
               <div class="col-lg-12">      
                      <asp:Button class="btn-block btn-lg btn-warning" ID="BtnMyIdea" runat="server" Text="My Ideas" Height="54px" Width="220px" OnClick="BtnMyIdea_Click"/>              
               </div>
           </div>    
           <div class="row">
               <div class="col-lg-12">         
                      <asp:Button class="btn-block btn-lg btn-warning" ID="BtnMyPoints" type="button" runat="server" Text="My Points" Height="54px" Width="220px" OnClick="BtnMyPoints_Click"/>
               </div>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>
</body>
</html>
