<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TeacherList.aspx.cs" Inherits="TeacherList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form" style="width: 140%">
				  	<h2>Teachers List</h2>
					    <form id="form1" runat ="server" >
					        <table align="center" width ="100%">
                                <tr>
                                    <td align="center">
                                        <asp:GridView ID="GridView1" runat="server"  AllowPaging ="true"   
                                          AutoGenerateColumns="False" GridLines ="None" OnPageIndexChanging ="GridView1_PageIndexChanging" OnRowEditing ="edit" OnRowDeleting ="delete" OnRowCancelingEdit ="canceledit" OnRowUpdating ="update" CssClass ="table table-bordered table-responsive "
                                         Width="100%"  >             
                                            <RowStyle  Height ="40px"  />
                                                <Columns>
                                                    <asp:TemplateField HeaderText ="# ^" >
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TID") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Code" >
                                                        <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox1" runat="server" Text ='<%# Eval("TCode") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("TCode") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Name " >
                                                        <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox2" runat="server" Text ='<%# Eval("TName") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("TName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Qualifications " >
                                                    <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox3" runat="server" Text ='<%# Eval("Qualification") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="LabelQ" runat="server" Text='<%# Eval("Qualification") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Specialization " >
                                                    <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox4" runat="server" Text ='<%# Eval("Specialization") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="LabelS" runat="server" Text='<%# Eval("Specialization") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
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
                                                    <%--<asp:TemplateField HeaderText ="Lec / Week " >
                                                        <ItemTemplate >
                                                            <asp:Label ID="LabelL" runat="server" Text='<%# Eval("Lec") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> --%>
                                                     </Columns>
                                            <EmptyDataTemplate ><div class ="status " style="font-weight: bold"> No Records Found</div> </EmptyDataTemplate>
                                            <PagerStyle CssClass ="table1" />
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

