<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewTeacherWise.aspx.cs" Inherits="ViewSubjectWise" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px">
				  <div class="contact-form">
				  	<h2>View Time Table</h2>
					    <form id="form1" runat ="server" >
                            <div>
						    	<span>Course</span>
						    	<span>
                                    <asp:DropDownList ID="DrpTeacher" runat="server" CssClass ="form-control2 " 
                                    Width ="60%" Height ="36px" DataSourceID="SqlDataSource1" 
                                    DataTextField="Tch" DataValueField="TCode" AppendDataBoundItems ="true"  >
                                        <asp:ListItem Text ="- Select Teacher -" Value ="0" ></asp:ListItem>
                                    </asp:DropDownList>
                                
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:ApplicationServices %>" 
                                    SelectCommand="SELECT TCode, TName + ' ( ' + TCode + ' )' AS Tch FROM Teacher">
                                </asp:SqlDataSource>
                                
                                </span>
						    </div>
					    	<%--<div>
						    	<span>Subject</span>
						    	<span>
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass ="form-control2 " Width ="60%" Height ="36px">
                                                                           
                                    </asp:DropDownList>
                                </span>
						    </div>--%>
                             <div>
						   		<label class="fa-btn btn-1 btn-1e">
                                 <asp:Button ID="BtnView" runat="server" 
                                    Text=" View " onclick="BtnView_Click"     /></label>
                                 
						</div>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <asp:Panel ID="Panel1" runat="server" Visible ="false" >
                        
					        <table id ="table1" align="center" cellpadding ="20" cellspacing ="10" class ="table  table-bordered table-striped table-hover" width ="100%">
                                <tr class ="tb" >
                                    <td align="center"><span>DAYS</span></td> 
                                    <td align="center"><span >I<br />08:00-08:50</span></td> 
                                    <td align="center"><span >II<br />08:55-09:45</span></td> 
                                    <td align="center"><span >III<br />09:50-10:40</span></td> 
                                    <td align="center"><span >IV<br />10:45-11:35</span></td> 
                                    <td align="center"><span >V<br />11:40-12:30</span></td> 
                                    <td align="center"><span >VI<br />12:35-01:25</span></td> 
                                </tr> 
                                <tr>
                                    <td align ="center" ><span>MONDAY</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L11" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L12" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L13" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L14" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L15" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L16" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>TUESDAY</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L21" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L22" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L23" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L24" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L25" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L26" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>WEDNESDAY</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L31" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L32" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L33" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L34" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L35" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L36" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>THURSDAY</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L41" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L42" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L43" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L44" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L45" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L46" runat="server" Text=""></asp:Label></span> </td>
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
                                   <%-- <td align ="center" ><span>FRIDAY</span> </td>--%>
                                    <td align ="center" ><span><asp:Label ID="L51" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L52" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L53" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L54" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L55" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L56" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>SATURDAY</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L61" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L62" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L63" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L64" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L65" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L66" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                
                            </table> 
                            </asp:Panel>
                        </form> 
				    </div>
  			    </div>		
  			<div class="clearfix"></div>		
	    </div> 
    </div>
</div>



</asp:Content>

