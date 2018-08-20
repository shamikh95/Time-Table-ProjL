<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ClassroomList.aspx.cs" Inherits="ClassroomList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form" style ="width :120%">
				  	<h2>Rooms List</h2>
					    <form id="form1" runat ="server" >
					        <table align="center" cellpadding ="20" cellspacing ="10" width ="110%">
                                <tr>
                                    <td align="center">
                                        <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging ="GridView1_PageIndexChanging" AllowPaging ="true"   
                                          AutoGenerateColumns="False" GridLines ="None" OnRowEditing ="edit" OnRowDeleting ="delete" OnRowCancelingEdit ="canceledit" OnRowUpdating ="update" CssClass ="table table-bordered table-responsive "  
                                         Width="100%"  >             
                                            <RowStyle ForeColor="#293364" Height ="40px"  />
                                                <Columns>
                                                    
                                                    <asp:TemplateField HeaderText ="# ^" >
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("RoomId") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Room Number" >
                                                        <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox1" runat="server" Text ='<%# Eval("RoomNo") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("RoomNo") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField HeaderText ="Description ^" >
                                                        <EditItemTemplate >
                                                            <span ><asp:TextBox ID="TextBox2" runat="server" Text ='<%# Eval("RoomBody") %>' CssClass ="form-control2 " Width ="60%"></asp:TextBox></span>
                                                        </EditItemTemplate>
                                                        <ItemTemplate >
                                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("RoomBody") %>'></asp:Label>
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
                                                     </Columns>
                                            <HeaderStyle CssClass ="submit" Font-Bold ="false"    />  
                                              <EmptyDataTemplate ><div class ="status " style="font-weight: bold"> No Records Found</div> </EmptyDataTemplate>
                                            <PagerStyle CssClass ="table1" />
                                            <%--<HeaderStyle BackColor ="Black"   />     --%>               
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

