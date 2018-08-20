<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login1.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Time Table</title>
<!-- Bootstrap -->
<link href="css/bootstrap.min.css" rel='stylesheet' type='text/css' />
<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
 <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<!-- start plugins -->
<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/bootstrap.js"></script>
<script type="text/javascript" src="js/bootstrap.min.js"></script>
<!----font-Awesome----->
   	<link type ="text/css"  rel="stylesheet" href="fonts/css/font-awesome.min.css"/>
<!----font-Awesome----->
<style type="text/css" >
            .submit
            {
                font-family: 'open_sansregular';
	            background: #3B3B3B;
	            color: #ffffff;
	            text-transform: uppercase;
	            font-size: 13px;
	            padding: 12px 20px;
	            border: none;
	            cursor: pointer;
	            width: 26.333%;
	            position: absolute;
	            line-height: 1.5em;
	            outline: none;
	            -webkit-transition: all 0.3s ease-in-out;
	            -moz-transition: all 0.3s ease-in-out;
	            -o-transition: all 0.3s ease-in-out;
	            transition: all 0.3s ease-in-out;
	            -webkit-appearance: none;
            }
            .submit:hover
            {
                background: #FF5454;
                color: #ffffff;
                text-decoration :none;
            }
        </style>
</head>
<body>
<div class="header_bg1">
<div class="container">
	<div class="row header">
		<div class="logo navbar-left">
			<h1><a href="index.html">Time Table</a></h1>
		</div>
		<div class="h_search navbar-right">
			<form>
				<input type="text" class="text" value="Enter text here" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Enter text here';}">
				<input type="submit" value="search">
			</form>
		</div>
		<div class="clearfix"></div>
	</div>
	<div class="row h_menu">
		<nav class="navbar navbar-default navbar-left" role="navigation">
		    <!-- Brand and toggle get grouped for better mobile display -->
		    <div class="navbar-header">
		      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
		        <span class="sr-only">Toggle navigation</span>
		        <span class="icon-bar"></span>
		        <span class="icon-bar"></span>
		        <span class="icon-bar"></span>
		      </button>
		    </div>
		    <!-- Collect the nav links, forms, and other content for toggling -->
		    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
		      <ul class="nav navbar-nav">
		        <li ><a href="#">Home</a></li>
                <li><a href="#">About Us</a></li>
		        <li><a href="#">Faculty</a></li>
		        <li><a href="#">Subjects</a></li>
		        <li><a href="#">Time Table</a></li>
                <li class="active"><a href="#">Login</a></li>
		        <li><a href="#">Contact</a></li>
		    </div><!-- /.navbar-collapse -->
		    <!-- start soc_icons -->
		</nav>
		</div>
	<div class="clearfix"></div>
</div>
</div>
<div class="main_btm"><!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form">
				  	<h2>User Login</h2>
					    <form id="form1" runat ="server" >
					    	<div>
						    	<span>User Name</span>
						    	<span>
                                    <asp:TextBox ID="TxtName" runat="server" CssClass ="form-control" Width ="60%" Height ="36px"></asp:TextBox></span>
						    </div>
						    <div>
						    	<span>Password</span>
						    	<span><asp:TextBox ID="TxtPwd" runat="server" CssClass ="form-control" Width ="60%" Height ="36px" TextMode ="Password" ></asp:TextBox></span>
						    </div>
						   <div>
						   		<label class="fa-btn btn-1 btn-1e"><asp:Button ID="BtnLogin" runat="server" 
                                    Text=" Login " onclick="BtnLogin_Click" /></label>
                                <label class="fa-btn btn-1 btn-1e"><asp:Button ID="Button1" runat="server" Text=" Cancel " /></label>
						  </div><br />
                          <div>
						    	<span>
                                    <asp:Label ID="LblValid" Font-Bold ="true"  runat="server" Text="Label" Visible ="false" ></asp:Label></span></div> 
					    </form>
				    </div>
  			</div>		
  			<div class="clearfix"></div>		
	</div> 
</div>
</div>
<div class="footer_bg"><!-- start footer -->
	<div class="container">
		<div class="row  footer">
			<div class="copy text-center">
				<p class="link"><span>&#169; All rights reserved | Design by&nbsp;<a >****</a></span></p>
			</div>
		</div>
	</div>
</div>
</body>
</html>
