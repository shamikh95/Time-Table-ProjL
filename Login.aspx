<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<%--<div class="main_btm">--%>
<div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form">
				  	<h2>User Login</h2>
					    <form id="form1" runat ="server" >
					    	<div>
						    	<span>User Name</span>
						    	<span><asp:TextBox ID="TxtName" runat="server" CssClass ="form-control" Width ="60%" Height ="36px"></asp:TextBox></span>
						    </div>
						    <div>
						    	<span>Password</span>
						    	<span><asp:TextBox ID="TxtPwd" runat="server" CssClass ="form-control" Width ="60%" Height ="36px" TextMode ="Password" ></asp:TextBox></span>
						    </div>
						   <div>
						   		<label class="fa-btn btn-1 btn-1e"><asp:Button ID="BtnLogin" runat="server" Text=" Login " onclick="BtnLogin_Click" /></label>
                                <label class="fa-btn btn-1 btn-1e"><asp:Button ID="Button1" runat="server" Text=" Cancel " /></label>
						  </div><br />
                          <div>
						    	<span><asp:Label ID="LblValid" Font-Bold ="true"  runat="server" Text="Label" Visible ="false" ></asp:Label></span>
                          </div> 
					    </form>
				    </div>
  			    </div>		
  			<div class="clearfix"></div>		
	    </div> 
    </div>
</div>

</asp:Content>

<%--<ul class="nav navbar-nav">
		        <li ><a href="Default.aspx">Home</a></li>
                <li><a href="#">About Us</a></li>
		        <li><a href="#">Faculty</a></li>
		        <li><a href="#">Subjects</a></li>
		        <li><a href="#">Time Table</a></li>
                <li class="active"><a href="Login.aspx">Login</a></li>
		        <li><a href="#">Contact</a></li>
               </ul> --%>