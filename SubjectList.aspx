<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SubjectList.aspx.cs" Inherits="SubjectList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form" style="width: 140%">
				  	<h2>Subject List</h2>
					    <form id="form1" runat ="server" >
					    	<div>
						    	<span>Course</span>
						    	<span>
                                    <asp:DropDownList ID="DrpCourse" runat="server" CssClass ="form-control2 " Width ="40%" Height ="36px">
                                        <asp:ListItem>- Select Course -</asp:ListItem>
                                        <asp:ListItem>MCA Ist Sem</asp:ListItem>
                                        <asp:ListItem>MCA IIIrd Sem</asp:ListItem>
                                        <asp:ListItem>MCA Vth Sem</asp:ListItem>
                                        <asp:ListItem>BCA Ist Sem</asp:ListItem>
                                        <asp:ListItem>BCA IIIrd Sem</asp:ListItem>
                                        <asp:ListItem>BCA Vth Sem</asp:ListItem>
                                        
                                        
                                    </asp:DropDownList>
                                </span>
						    </div>
					    	
                             <div>
						   		<label class="fa-btn btn-1 btn-1e">
                                 <asp:Button ID="BtnView" runat="server" 
                                    Text=" View " onclick="BtnView_Click"/></label>
                                 <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>--%>
						</div>
                        <table align="center" width ="100%">
                                <tr>
                                    <td align="center">
                                        <asp:GridView ID="GridView1" runat="server"   
                                          AutoGenerateColumns="False" GridLines ="None" Visible ="false"    OnRowEditing ="edit" OnRowDeleting ="delete" OnRowCancelingEdit ="canceledit" OnRowUpdating ="update" CssClass ="table table-bordered table-responsive "
                                         Width="100%"  >             
                                            <RowStyle  Height ="40px"  />
                                                <Columns>
                                                    <asp:TemplateField HeaderText ="# ^" >
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("SId") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Code" >
                                                        <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox1" runat="server" Text ='<%# Eval("SCode") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("SCode") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Name " >
                                                        <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox2" runat="server" Text ='<%# Eval("SName") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("SName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                     <asp:TemplateField HeaderText ="Lec / Week " >
                                                     <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox3" runat="server" Text ='<%# Eval("SLecWeek") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="LabelL" runat="server" Text='<%# Eval("SLecWeek") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Teacher " >
                                                    <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox4" runat="server" Text ='<%# Eval("Teacher") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="LabelQ" runat="server" Text='<%# Eval("Teacher") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <%--<asp:TemplateField HeaderText ="Specialization " >
                                                    <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox4" runat="server" Text ='<%# Eval("Specialization") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="LabelS" runat="server" Text='<%# Eval("Specialization") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> --%>
                                                     <asp:TemplateField  >
                                                        <EditItemTemplate >
                                                            <div style="margin-top: 10px; margin-bottom :10px;"><asp:LinkButton ID="LinkButton3" runat="server" CommandName ="Update" CssClass ="link">Update </asp:LinkButton></div>
                                                            <div style="margin-top: -27px; margin-bottom :10px; margin-left :100px"><asp:LinkButton ID="LinkButton2" runat="server" CommandName ="Cancel" CssClass ="link">Cancel</asp:LinkButton></div>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <div style="margin-top: 10px; margin-bottom :10px"><asp:LinkButton ID="LinkButton1" runat="server" CommandName ="Edit" CssClass ="link">Edit</asp:LinkButton></div> 
                                                            <div style="margin-top: -27px; margin-bottom :10px; margin-left :100px"><asp:LinkButton ID="LinkButton4" runat="server" CommandName ="Delete" CssClass ="link">Delete</asp:LinkButton></div> 
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                   
                                                     </Columns>
                                            
                                            <HeaderStyle CssClass ="submit"   />                  
                                        </asp:GridView>
                                    </td> 
                                </tr> 
                            </table> 
                        </form> 
				    </div>
  			    </div>		
  			<div class="clearfix"></div>		
	    </div> 
    </div>
</div>

</asp:Content>

