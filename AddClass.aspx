<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddClass.aspx.cs" Inherits="AddClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form" style="width: 120%">
				  	<h2>Create Rooms</h2>
					    <form id="form1" runat ="server" >
                        <div style="float: right; margin-right: 0px">
                                <asp:HyperLink ID="HyperLink1" NavigateUrl ="~/ClassroomList.aspx"   runat="server" ForeColor ="#FF5454" Font-Bold ="true"  Font-Size ="16px">View Classroom List</asp:HyperLink>
                            </div>
					    	<div>
						    	<span>Room Number</span>
						    	<span><asp:TextBox ID="TxtRoomNo" runat="server" CssClass ="form-control2" Width ="60%" Height ="36px"></asp:TextBox></span>
						    </div>
						    <div>
						    	<span>Location</span>
						    	<span><asp:TextBox ID="TxtSumm" runat="server" CssClass ="form-control2" Width ="60%"  TextMode="MultiLine"></asp:TextBox></span>
						    </div>
						   <div>
						   		<label class="fa-btn btn-1 btn-1e"><asp:Button ID="BtnLogin" runat="server" 
                                    Text=" Save " onclick="BtnLogin_Click" /></label>
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

