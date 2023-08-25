<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="NewRegistrationWebApp.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Helper/css/style.default.css" rel="stylesheet" />
    <link href="Helper/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
</head>
    <!--<script>
        function confrimpopup(){
        alert("Registration Successfull");
        }
        
    </script> -->
<body>
   <form id="form1" runat="server">
        <div class=" page-holder d-flex align-items-center">
            <div class="container">
                <div class="row align-items-center py-5">
                    <div class="col-5 col-lg-7 mx-auto mb-5 mb-lg-0">
                    
                        <div class="pr-lg-5">
                            <img src="illustration.svg" alt="" class="img-fluid" />     
                        </div>
                    </div>
                    <div class="col-lg-5 px-lg-4">
                        <h1 class="text-base text-primary text-uppercase mb-4">Sign up Here</h1>
                        <h2 class="mb-4">Welcome Back!</h2>

                        <div class ="form-group mb-4">
                            <asp:TextBox ID="TextFirstname" required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="First Name" runat="server" ></asp:TextBox>
                          </div>
                         
                        <div class ="form-group mb-4">
    <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Last Name" ID="TextLastname" runat="server" ></asp:TextBox>

</div>



                        <div class ="form-group mb-4">
    <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="User Name" runat="server" ></asp:TextBox>

</div>


                        <div class ="form-group mb-4">
    <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Email" ID="TextRegEmail" runat="server" ></asp:TextBox>

</div>

                        <div class ="form-group mb-4">
    <asp:TextBox required= "true" TextMode="Password" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Password" ID="TextPassword" runat="server" ></asp:TextBox>

</div>
              
                         <div class ="form-group mb-4">
    <asp:TextBox required= "true" TextMode="Password" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Confirm Password" ID="TextConfirmpassword" runat="server" ></asp:TextBox>

</div>
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        <div class ="form-group mb-4">
                 <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Address" ID="TextAddress" runat="server" ></asp:TextBox>

 </div>


                  


                     <div class ="form-group mb-4">
                    <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Enter city" runat="server" ></asp:TextBox>

                </div>
                         

                         
                          

                     <div class ="form-group mb-4">
                        <asp:TextBox <asp:RadioButtonList ID="RadioButtonListGender"   required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="User Name" runat="server">  
                        <asp:ListItem>Male</asp:ListItem>  
                        <asp:ListItem>Female</asp:ListItem>  
                    </asp:RadioButtonList>  </asp:TextBox>

            </div>


                   <div class ="form-group mb-4">
                <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="zip" ID="TextZip" runat="server" ></asp:TextBox>

         </div>
                       <div class ="form-group mb-4">
                      <asp:CheckBox ID="CheckBoxAreaofinterest1" runat="server" Text="Reading"/>  
                     <asp:CheckBox ID="CheckBoxAreaofinterest2" runat="server" Text="Writing"/>  
                     <asp:CheckBox ID="CheckBoxAreaofinterest3" runat="server" Text="Travelling"/>  
                    <asp:CheckBox ID="CheckBoxAreaofinterest4" runat="server" Text="Others"/> 

</div>



                                                  <div class ="form-group mb-4">
                                <asp:DropDownList  runat="server" required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Country" ID="DropDownListCountry"  >
                             <asp:ListItem Text="Select Country" Value="select" Selected="True"></asp:ListItem>  
                             <asp:ListItem Text="India" Value="India"></asp:ListItem>  
                             <asp:ListItem Text="Pakistan" Value="Pakistan"></asp:ListItem>  
                             <asp:ListItem Text="Bangladesh" Value="Bangladesh"></asp:ListItem>  
                              </asp:DropDownList>  

                                         </div>

                                             <div class ="form-group mb-4">
                         <asp:DropDownList ID="DropDownListState" runat="server" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Email">  
                         <asp:ListItem Text="Select State" Value="select" Selected="True"></asp:ListItem>  
                         <asp:ListItem Text="MP" Value="MP"></asp:ListItem>  
                         <asp:ListItem Text="UP" Value="UP"></asp:ListItem>  
                         <asp:ListItem Text="Maharashtra" Value="Maharashtra"></asp:ListItem>  
                       </asp:DropDownList>

                    </div>

                           <div class ="form-group mb-4">
                             <asp:FileUpload ID="FileUploadProfilepicture" CssClass="form-control border-0 shadow form-control-lg text-base" runat="server" />
                        </div>
                       
                        <asp:Button ID="ButtonReg" Text="Sign up" CssClass="btn btn-primary" Height="50px" OnClientClick="confrimpopup()" Width="400px" runat="server" OnClick="Unnamed8_Click"/>
                    </div>               
                        
                </div>
                       <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary" Height="50px" Text="LoginButtonPage" OnClick="btnLogin_Click" Width="398px" />
            
                       <footer class="footer bg-white shadow align-self-end py-3 px-xl-5 w-100 " style="text-align:end;margin-top:390px">
                          <div class="container-fluid">
                            <div class="row">   
                            <div class="col-md-6 text-center text-md-left text-primary">
                                <p class  ="mb-2 mb-md-0">RashiCode &copy;2021</p>
                            </div>
                            <div class="col-md-6 text-center text-md-right text-gray-400">
                                <p class="mb-0">DEsign by <a href="#">Rashicode</a></p>
 
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
            
        </div>
    </form>
</body>
</html>

