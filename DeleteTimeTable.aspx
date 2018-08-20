<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DeleteTimeTable.aspx.cs" Inherits="DeleteTimeTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px; ">
				  <div class="contact-form" style ="width :140%">
				  	<h2>Delete Time Table</h2>
					    <form id="form1" runat ="server" >
                            <div>
						    	<span>Course</span>
						    	<span>
                                    <asp:DropDownList ID="DrpCourse" runat="server" CssClass ="form-control2 " Width ="50%" Height ="36px">
                                        <asp:ListItem>- Select Course -</asp:ListItem>
                                         <asp:ListItem>BCA Ist Sem</asp:ListItem>
                                       
                                        <asp:ListItem>BCA IIIrd Sem</asp:ListItem>
                                       
                                        <asp:ListItem>BCA Vth Sem</asp:ListItem>
                                       
                                        <asp:ListItem>MCA Ist Sem</asp:ListItem>
                                       
                                        <asp:ListItem>MCA IIIrd Sem</asp:ListItem>
                                        
                                        <asp:ListItem>MCA Vth Sem</asp:ListItem>                                
                                    </asp:DropDownList>
                                </span>
						    </div>
					    	
                             <div>
						   		<label class="fa-btn btn-1 btn-1e">
                                 <asp:Button ID="BtnDelete" runat="server" 
                                    Text=" Delete " onclick="BtnDelete_Click" /></label>
                                 
						</div>
 </form> 
				    </div>
  			    </div>		
  			<div class="clearfix"></div>		
	    </div> 
    </div>
</div>
</asp:Content>

