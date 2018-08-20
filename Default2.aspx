<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
<%--<script type="text/javascript" src="js/bootstrap.js"></script>
<script type="text/javascript" src="js/bootstrap.min.js"></script>--%>
<!-- start slider -->
<link href="css/slider.css" rel="stylesheet" type="text/css" media="all" />
<%--<script type="text/javascript" src="js/modernizr.custom.28468.js"></script>
--%><script type="text/javascript" src="js/jquery.cslider.js"></script>
	<script type="text/javascript">
	    $(function () {

	        $('#da-slider').cslider({
	            autoplay: true,
	            bgincrement: 450
	        });

	    });
		</script>
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
            #mainav{text-align:center; text-transform:uppercase;}
            #mainav ul{color: #ffffff; }
            #mainav ul ul{z-index:9999; position:absolute; width:170px;background: #3B3B3B; box-shadow:0px 8px 16px opx rgba(0,0,0,0.2); }
            #mainav ul ul ul{left:170px; top:0;}
            #mainav li{display:inline-block; position:relative; }
            #mainav li:last-child{margin-right:0;}
            #mainav li li{width:100%; margin:0; text-align:left; text-transform:none;}
            #mainav li li a{border:solid; border-width:0 0 1px 0;}
            #mainav li li:last-child a{}
            #mainav li li a, #mainav li li .drop{display:block; margin:0; padding:18px 22px;color: #ffffff;}
            #mainav ul ul{display:none;}
            #mainav ul li:hover > ul{display:block;}
            #mainav ul li:hover > ul li a:hover{background: #FF5454;color: #ffffff;}
        </style>
<!----font-Awesome----->
   	<link rel="stylesheet" href="fonts/css/font-awesome.min.css"/>
<!----font-Awesome----->
</head>
<body>
<div class="header_bg">
<div class="container">
	<div class="row header">
		<div class="logo navbar-left">
			<h1><a href="index.html">Time Table </a></h1>
		</div>
		<div class="h_search navbar-right">
			<form id="Form1" runat ="server" >
                <asp:TextBox ID="TxtSearch" runat="server" PlaceHolder="Enter text here" ForeColor ="#c6c6c6" CssClass ="text"></asp:TextBox>
				<%--<input type="text" class="text" value="Enter text here" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Enter text here';}">--%>
                <asp:LinkButton ID="BtnSubmit" runat="server" CssClass ="submit">Search</asp:LinkButton>
                <%--<input type="submit" value="search">--%>
			</form>
		</div>
		<div class="clearfix"></div>
	</div>
</div>
</div>
<div class="container">
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
		      <div id ="mainav">
		      <ul class="nav navbar-nav" >
		        <li class="active"><a href="Default.aspx">Home</a></li>
                <li><a href="AddTeachers.aspx">Teacher</a></li>
		        <li><a href="AddSubject.aspx">Subjects</a></li>
		        <li> <a href="#" >Time Table &#9660;</a>
                    <ul class ="nav">
                    <li><a href="AddNewTimeTable.aspx">Create &#9654;</a>
                        <ul class ="nav ">
                            <li><a href="AddNewTimeTable.aspx">Semester Wise</a></li>
                            <li><a href="CreateMasterTimeTable.aspx">Master Time Table</a></li>
                        </ul>
                    </li>

                    <li><a href="#">Edit &#9654;</a>
                        <ul class ="nav ">
                            <li><a href="UpdateTimeTable.aspx">Update</a></li>
                            <li><a href="DeleteTimeTable.aspx">Delete</a></li>
                        </ul>
                    </li>
                    <li><a href="#">View &#9654;</a>
                        <ul class ="nav ">
                            <li><a href="ViewTeacherWise.aspx">Teacher Wise</a></li>
                            <li><a href="ViewTimeTable.aspx">Course Wise</a></li>
                            <li><a href="ViewMasterTimeTable.aspx">Master Time Table</a></li>
                        </ul>
                    </li>
                  </ul>
                </li>
                <li><a href="AddClass.aspx">Classrooms</a></li>
                <li ><a href="Login.aspx">Login</a></li>
                 <li><a href="#">About Us</a></li>
		        <li><a href="#">Contact</a></li>
                <li><asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl ="~/Default.aspx" >Logout</asp:HyperLink></li>
		      </ul>
              </div> 
		    </div><!-- /.navbar-collapse -->
		    <!-- start soc_icons -->
		</nav>
	</div>
</div>
<div class="slider_bg"><!-- start slider -->
	<div class="container">
		<div id="da-slider" class="da-slider text-center">
			<div class="da-slide">
				<h2>Online Time Table</h2>
				<p>Timetables usually cycle every week or fortnight.<span class="hide_text"> Timetabling is a more computationally intensive task.It is a comprehensive timetable management solution for Colleges which helps to overcome the challenges in current system.</span></p>
				<h3 class="da-link">
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass ="fa-btn btn-1 btn-1e">view more</asp:HyperLink></h3>
			</div>
		</div>
	</div>
</div><!-- end slider -->
<div class="main_bg"><!-- start main -->
	<div class="container">
		<div class="main row">
			<div class="col-md-3 images_1_of_4 bg1 text-center" style="width: 33.33%">
				<span class="bg"><i class="fa fa-files-o"></i></span>
				<h4><a href="#">Timetable Management</a></h4>
				<p class="para">It is a long established fact that the timetable will be automatically created by the system when all required information will be filled.</p>
				<asp:HyperLink ID="HyperLink2" runat="server" CssClass ="fa-btn btn-1 btn-1e">read more</asp:HyperLink> 
			</div>
			<div class="col-md-3 images_1_of_4 bg1 text-center" style="width: 33.33%">
				<span class="bg"><i class="fa fa-laptop"></i></span>
				<h4><a href="#">Weekly Timetables</a></h4>
				<p class="para">The timetable will be generated in a proper format like week wise, class wise and faculty wise so that it is easily ustandardable by the students and the teachers.</p>
				<asp:HyperLink ID="HyperLink3" runat="server" CssClass ="fa-btn btn-1 btn-1e">read more</asp:HyperLink> 
			</div>		
			<div class="col-md-3 images_1_of_4 bg1 text-center" style="width: 33.33%">
				<span class="bg"><i class="fa fa-female"></i> </span>
				<h4><a href="#">Faculty Management</a></h4>
				<p class="para">There is no need for Faculty to worry about their period details and maximum workload. Faculties will be properly maintained and managed.</p>
				<asp:HyperLink ID="HyperLink4" runat="server" CssClass ="fa-btn btn-1 btn-1e">read more</asp:HyperLink> 
			</div>	
		</div>
	</div>
</div><!-- end main -->
<div class="footer_bg"><!-- start footer -->
	<div class="container">
		<div class="row  footer">
			<div class="copy text-center">
				<p class="link"><span>&#169; All rights reserved | Design by&nbsp;<a href="#">****</a></span></p>
			</div>
		</div>
	</div>
</div>
</body>
</html>

