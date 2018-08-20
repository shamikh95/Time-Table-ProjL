<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateTimeTable.aspx.cs" Inherits="UpdateTimeTable" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat ="server" >
   
    
    <div class="main_bg" id="m1" runat ="server" >
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form" style ="width :140%">
				  	<h2>Update Time Table
                      </h2>
					    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
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
                                 <asp:Button ID="BtnView" runat="server" 
                                    Text=" View " onclick="BtnView_Click"    /></label>
                                 
						    </div>
                            
                        <asp:Panel ID="Panel1" runat="server" Visible ="false" >
                        
					        <table id ="table1" align="center" cellpadding ="20" cellspacing ="10" class ="table table-bordered table-striped table-hover">
                                
                                <tr >
                                    <td align="center" ><span>DAYS</span></td> 
                                    <td align="center"><span >I<br />08:00-08:50</span></td> 
                                    <td align="center"><span >II<br />08:55-09:45</span></td> 
                                    <td align="center"><span >III<br />09:50-10:40</span></td> 
                                    <td align="center"><span >IV<br />10:45-11:35</span></td> 
                                    <td align="center"><span >V<br />11:40-12:30</span></td> 
                                    <td align="center"><span >VI<br />12:35-01:25</span></td> 
                                </tr> 
                                <tr>
                                    <td align ="center" ><span>MONDAY</span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L11" runat="server" Text="" CssClass ="lb" ></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L12" runat="server" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L13" runat="server" CssClass ="lb" ></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L14" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L15" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L16" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>TUESDAY</span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L21" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L22" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L23" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L24" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L25" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L26" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>WEDNESDAY</span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L31" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L32" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L33" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L34" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L35" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L36" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>THURSDAY</span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L41" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L42" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L43" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L44" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L45" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L46" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                </tr>
                                <tr >
                                    <td align ="center" rowspan ="2" valign ="middle" ><span>FRIDAY</span> </td>
                                    <td align="center" ><span >08:00-08:40</span></td> 
                                    <td align="center" ><span >08:45-09:25</span></td> 
                                    <td align="center" ><span >09:30-10:10</span></td> 
                                    <td align="center" ><span >10:15-10:55</span></td> 
                                    <td align="center" ><span >11:00-11:40</span></td> 
                                    <td align="center" ><span >11:45-12:25</span></td> 
                                </tr>
                                <tr>
                                    <%--<td align ="center" ><span>FRIDAY</span> </td>--%>
                                    <td align ="center" ><span><asp:LinkButton ID="L51" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L52" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L53" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L54" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L55" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L56" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>SATURDAY</span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L61" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L62" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L63" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L64" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L65" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                    <td align ="center" ><span><asp:LinkButton ID="L66" runat="server" Text="" CssClass ="lb"></asp:LinkButton></span> </td>
                                </tr>
                                
                            </table> 
                            </asp:Panel>
                           
                        <asp:Panel ID="pnlPopup" runat="server" CssClass ="mp "   >
                        <div><h2>Edit Block</h2></div>
                           <div>
						    	<span>Subject : </span>
                                <span style="margin-top: -30px; margin-left: 80px"><asp:Label ID="LblSCode" runat="server" Font-Bold ="true"  Text="Label"></asp:Label></span>
						    							    
                            </div>
                            <div>
						    	<span>Teacher : </span>
						    	<span style="margin-top: -30px; margin-left: 80px"><asp:Label ID="LblTeacher" runat="server" Font-Bold ="true"  Text="Label"></asp:Label></span>
						    </div>
                            <div>
						    	<span>Day : </span>
						    	<span style="margin-top: -35px; margin-left: 75px">
                                <asp:DropDownList ID="DrpDay" CssClass ="form-control2" Width ="60%" 
                                    runat="server" onselectedindexchanged="DrpDay_SelectedIndexChanged" AutoPostBack ="true" >
                                    <asp:ListItem>Mon</asp:ListItem>
                                    <asp:ListItem>Tue</asp:ListItem>
                                    <asp:ListItem>Wed</asp:ListItem>
                                    <asp:ListItem>Thurs</asp:ListItem>
                                    <asp:ListItem>Fri</asp:ListItem>
                                    <asp:ListItem>Sat</asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    </asp:DropDownList></span>
						    </div>
                            <div>
						    	<span>Period : </span>
						    	<span style="margin-top: -35px; margin-left: 75px">
                                    <asp:TextBox ID="TxtPeriod" runat="server" CssClass ="form-control2" Width ="60%"></asp:TextBox>
                                <asp:DropDownList ID="DrpPeriod" CssClass ="form-control2" Width ="60%" AutoPostBack ="true"   
                                    runat="server" onselectedindexchanged="DrpPeriod_SelectedIndexChanged" >
                                    
                                </asp:DropDownList></span>
						    </div>
                            <div>
						    	<span>Room : </span>
						    	<span style="margin-top: -35px; margin-left: 75px">
                                    <asp:TextBox ID="TxtRoom" runat="server" CssClass ="form-control2" Width ="60%"></asp:TextBox>
                                    <asp:DropDownList ID="DrpRoom" CssClass ="form-control2" Width ="60%" runat="server">
                                    </asp:DropDownList>
                                 </span> 
                                 
						    </div>
                            <div>
                                <label class="fa-btn btn-1 btn-1e"><asp:Button ID="BtnUpdate" onclick="BtnUpdate_Click"  runat="server" Text=" Update " /></label>
                                <label class="fa-btn btn-1 btn-1e"><asp:Button ID="ButtonCancel" runat="server" Text=" Cancel " /></label>
                            </div> 
                            </asp:Panel>
                         <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                        </cc1:ToolkitScriptManager>
                        
                        <cc1:ModalPopupExtender ID="ModalPopupExtender1" BackgroundCssClass ="mb" RepositionMode ="RepositionOnWindowResizeAndScroll"  DropShadow ="true" CancelControlID ="ButtonCancel" TargetControlID ="hdnField" runat="server" PopupControlID ="pnlPopup">
                            
                        </cc1:ModalPopupExtender>
                        <asp:HiddenField ID="hdnField" runat="server" />
                    </div>
                        
                        
				    </div>
  			    </div>		
  			<div class="clearfix"></div>		
	    </div> 
    </div>

  
    </form> 
</asp:Content>

