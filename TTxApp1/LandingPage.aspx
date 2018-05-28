<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="TTxApp1.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./LandingPage.css"/>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <title></title>
    </head>
<body>
    
    <form id="form1" runat="server">
        <div>
         <asp:ImageButton ID="ImageButton1" runat="server" class="img-fluid" ImageUrl="~/Images/TTX Logo White.png"/>
        <asp:Button ID="Logout" runat="server" class="btn btn-danger" Text="Logout" OnClick="Logout_Click" />
     
            </div>

       <div class="container">
           <div class="row">
               <div class="col-lg-12">  
                      <asp:Button class="btn-block btn-lg btn-warning" ID="BtnMyAccount" runat="server" Text="My Account"  OnClick="BtnMyAccount_Click"/>  
               </div>
            </div>  
           <div class="row">
               <div class="col-lg-12">       
                      <asp:Button class="btn-block btn-lg btn-warning" ID="BtnTrendingIdeas" type="button" runat="server" Text="All Ideas"  OnClick="BtnTrendingIdeas_Click"/>
               </div>
            </div>  
           <div class="row">
               <div class="col-lg-12">          
                      <asp:Button class="btn-block btn-lg btn-warning" ID="BtnMakeNewIdea" type="button" runat="server" Text="Leave A Idea"  OnClick="BtnMakeNewIdea_Click"/>
               </div>
            </div>
      </div>     
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>
 
</body>
</html>
