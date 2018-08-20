<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddSubject.aspx.cs" Inherits="AddSubject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form" style="width: 120%">
				  	<h2>Add Subjects</h2>
					    <form id="form1" runat ="server" >
                        <div style="float: right; margin-right: 0px">
                                <asp:HyperLink ID="HyperLink1" NavigateUrl ="~/SubjectList.aspx"   runat="server" ForeColor ="#FF5454" Font-Bold ="true"  Font-Size ="16px">View Subject List</asp:HyperLink>
                            </div>
                            <div>
						    	<span>Course</span>
						    	<span>
                                    <asp:DropDownList ID="DrpCourse" runat="server" CssClass ="form-control2 " Width ="60%" Height ="36px">
                                        <asp:ListItem>- Select Course -</asp:ListItem>
                                        <asp:ListItem>BCA Ist Sem</asp:ListItem>
                                        <asp:ListItem>BCA IInd Sem</asp:ListItem>
                                        <asp:ListItem>BCA IIIrd Sem</asp:ListItem>
                                        <asp:ListItem>BCA IVth Sem</asp:ListItem>
                                        <asp:ListItem>BCA Vth Sem</asp:ListItem>
                                        <asp:ListItem>BCA VIth Sem</asp:ListItem>
                                        <asp:ListItem>MCA Ist Sem</asp:ListItem>
                                        <asp:ListItem>MCA IInd Sem</asp:ListItem>
                                        <asp:ListItem>MCA IIIrd Sem</asp:ListItem>
                                        <asp:ListItem>MCA IVth Sem</asp:ListItem>
                                        <asp:ListItem>MCA Vth Sem</asp:ListItem>
                                        
                                        
                                    </asp:DropDownList>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="DrpCourse"
                    Display="Dynamic" ErrorMessage="*" Operator="NotEqual" ForeColor ="red" SetFocusOnError="True" CssClass ="vl" 
                    ValueToCompare="0"></asp:CompareValidator>
                                </span>
						    </div>
					    	<div>
						    	<span>Subject Code</span>
						    	<span><asp:TextBox ID="TxtSCode" runat="server" CssClass ="form-control2" Width ="60%" Height ="36px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ErrorMessage="*"  ControlToValidate="TxtSCode" ForeColor="Red" Font-Bold ="true" CssClass ="vl "></asp:RequiredFieldValidator> </span>
                                
						    </div>
						    <div>
						    	<span>Subject Name </span>
						    	<span><asp:TextBox ID="TxtSName" runat="server" CssClass ="form-control2" Width ="60%"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ErrorMessage="*"  ControlToValidate="TxtSName" ForeColor="Red" Font-Bold ="true" CssClass ="vl "></asp:RequiredFieldValidator> </span>
						    </div>
                            <div>
						    	<span>Teacher </span>
						    	<span><asp:TextBox ID="TxtTeacher" runat="server" CssClass ="form-control2" Width ="60%" TextMode ="MultiLine" ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ErrorMessage="*"  ControlToValidate="TxtTeacher" ForeColor="Red" Font-Bold ="true" CssClass ="vl "></asp:RequiredFieldValidator> </span>
						    </div>
                            <div>
						    	<span>Lec / Week</span>
						    	<span><asp:TextBox ID="TxtLw" runat="server" CssClass ="form-control2" Width ="60%" Height ="36px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ErrorMessage="*"  ControlToValidate="TxtLw" ForeColor="Red" Font-Bold ="true" CssClass ="vl "></asp:RequiredFieldValidator> </span>
						    </div>
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

