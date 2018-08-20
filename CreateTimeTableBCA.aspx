<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateTimeTableBCA.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form">
				  	<h2>Create Time Table</h2>
					    <form id="form1" runat ="server" >
					    	<div>
						    	<span>Course</span>
						    	<span>
                                    <asp:DropDownList ID="DrpCourse" runat="server" CssClass ="form-control2 " 
                                    Width ="60%" Height ="36px" >
                                        <asp:ListItem>- Select Course -</asp:ListItem>
                                        <asp:ListItem>MCA</asp:ListItem>
                                        <asp:ListItem>BCA</asp:ListItem>
                                        
                                        
                                    </asp:DropDownList>
                                </span>
						    </div>
					    	
                             <div>
						   		<label class="fa-btn btn-1 btn-1e">
                                 <asp:Button ID="BtnSave" runat="server" 
                                    Text=" Create " onclick="BtnSave_Click"   /></label>
                                 <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>--%>
						</div>
                         <asp:Panel ID="Panel1" runat="server" Visible ="false" >
                        <div class="alert alert-danger">
                            <strong>Success!</strong> Time Table has been <a href="#" class="alert-link">successfully generated.</a>.
                        </div>
                        </asp:Panel>
					    </form>
				    </div>
  			    </div>		
  			<div class="clearfix"></div>		
	    </div> 
    </div>
</div>

</asp:Content>



