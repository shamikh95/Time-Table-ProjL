<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddTeachers.aspx.cs" Inherits="AddTeachers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form" style="width: 120%">
				  	<h2>Add Teachers</h2>
					    <form id="form1" runat ="server" >
					    	<div style="float: right; margin-right: 0px">
                                <asp:HyperLink ID="HyperLink1" NavigateUrl ="~/TeacherList.aspx"  runat="server" ForeColor ="#FF5454" Font-Bold ="true"  Font-Size ="16px">View Teacher List</asp:HyperLink>
                            </div>
                            <div>
						    	<span>Teacher Code</span>
						    	<span><asp:TextBox ID="TxtTCode" runat="server" CssClass ="form-control2" Width ="60%" Height ="36px"></asp:TextBox></span>
						    </div>
                            <div>
						    	<span>Teacher Name </span>
						    	<span><asp:TextBox ID="TxtTName" runat="server" CssClass ="form-control2" Width ="60%"></asp:TextBox></span>
						    </div>
						    <div>
						    	<span>Qualification </span>
						    	<span><asp:TextBox ID="TxtTQf" runat="server" CssClass ="form-control2" Width ="60%"></asp:TextBox></span>
						    </div>
                            <div>
						    	<span>Specialization </span>
						    	<span><asp:TextBox ID="TxtSpec" runat="server" CssClass ="form-control2" Width ="60%"></asp:TextBox></span>
						    </div>
                            
                            <%--<div>
						    	<span>Lec / Week</span>
						    	<span><asp:TextBox ID="TxtLw" runat="server" CssClass ="form-control2" Width ="60%" Height ="36px"></asp:TextBox></span>
						    </div>--%>
						   <div>
						   		<label class="fa-btn btn-1 btn-1e"><asp:Button ID="BtnSave" runat="server" 
                                    Text=" Save " OnClick ="BtnSave_Click"  /></label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <label class="fa-btn btn-1 btn-1e"><asp:Button ID="BtnCancel" runat="server" Text=" Cancel " /></label>
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


