<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewMasterTimeTable.aspx.cs" Inherits="ViewMasterTimeTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type ="text/javascript" >
    function PrintPanel() {
        var panel = document.getElementById("<% =Panel1.ClientID %>");
        var pw = window.open(",", 'height=400,width=800');
        pw.document.write('<html><head><title>Time Table</title>');
        pw.document.write('</head><body>');
        pw.document.write(panel.innerHTML);
        pw.document.write('</body></html>');
        pw.document.cloneNode();
        setTimeout(function () {
            pw.print();
        }, 500);
        return false;
    }
</script>
    <div class="main_bg">
<!-- start main_btm -->
	<div class="container">
		<div class="main row">
			   <div class="col-md-8" style="margin-left: 50px; ">
				  <div class="contact-form" style ="width :150%">
				  	<h2>View Time Table</h2>
					    <form id="form1" runat ="server" >
                            <div>
						    	<span>Course</span>
						    	<span>
                                    <asp:DropDownList ID="DrpCourse" runat="server" CssClass ="form-control2 " Width ="50%" Height ="36px">
                                        <asp:ListItem>- Select Course -</asp:ListItem>
                                        <asp:ListItem>MCA</asp:ListItem>
                                        <asp:ListItem>BCA </asp:ListItem>
                                                                              
                                    </asp:DropDownList>
                                </span>
						    </div>
					    	
                             <div>
						   		<label class="fa-btn btn-1 btn-1e" >
                                 <asp:Button ID="BtnView" runat="server" 
                                    Text=" View " onclick="BtnView_Click"    /></label>
                                 
						     </div>
                        <div>
						   		<asp:Panel ID="Panel2" runat="server" Visible ="false" ><label class="fa-btn btn-1 btn-1e" style="float: right; margin-top: -25px"><asp:Button ID="Button1" runat="server" 
                                    Text=" Print " OnClientClick ="return PrintPanel();"    /></label></asp:Panel> 
                                 
                                 
						</div>
                        <asp:Panel ID="Panel1" runat="server" Visible ="false"   >
                        
					        <table id ="table1" align="center" cellpadding ="20" cellspacing ="10" class ="table table-bordered table-striped table-hover">
                                <%--<colgroup>
                                    <col style="width: 50%" />
                                    <col style="width: 40%" />
                                    <col style="width: 40%" />
                                    <col style="width: 50%" />
                                    <col style="width: 40%" />
                                    <col style="width: 40%" />
                                    <col style="width: 40%" />
                                </colgroup>--%>
                                <tr >
                                    <td align="center" ><span>DAYS</span></td>
                                    <td align ="center" ><span>Courses</span> </td> 
                                    <td align="center"><span >I<br />08:00-08:50</span></td> 
                                    <td align="center"><span >II<br />08:55-09:45</span></td> 
                                    <td align="center"><span >III<br />09:50-10:40</span></td> 
                                    <td align="center"><span >IV<br />10:45-11:35</span></td> 
                                    <td align="center"><span >V<br />11:40-12:30</span></td> 
                                    <td align="center"><span >VI<br />12:35-01:25</span></td> 
                                </tr> 
                                <tr>
                                    <td align ="center" valign ="middle"  rowspan ="3" ><span>MONDAY</span> </td>
                                    <td align ="center" ><span>MCA-I</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L111" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L112" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L113" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L114" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L115" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L116" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>MCA-III</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L311" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L312" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L313" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L314" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L315" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L316" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" ><span>MCA-V</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L511" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L512" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L513" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L514" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L515" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L516" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" rowspan ="3"><span>TUESDAY</span> </td>
                                    <td align ="center" ><span>MCA-I</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L121" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L122" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L123" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L124" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L125" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L126" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>MCA-III</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L321" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L322" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L323" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L324" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L325" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L326" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" ><span>MCA-V</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L521" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L522" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L523" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L524" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L525" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L526" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" rowspan ="3"><span>WEDNESDAY</span> </td>
                                    <td align ="center" ><span>MCA-I</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L131" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L132" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L133" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L134" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L135" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L136" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>MCA-III</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L331" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L332" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L333" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L334" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L335" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L336" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" ><span>MCA-V</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L531" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L532" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L533" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L534" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L535" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L536" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" rowspan ="3"><span>THURSDAY</span> </td>
                                    <td align ="center" ><span>MCA-I</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L141" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L142" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L143" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L144" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L145" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L146" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>MCA-III</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L341" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L342" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L343" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L344" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L345" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L346" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" ><span>MCA-V</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L541" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L542" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L543" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L544" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L545" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L546" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                 <tr >
                                    <td align ="center" rowspan ="4" valign ="middle" ><span>FRIDAY</span> </td>
                                    <td></td>
                                    <td align="center" ><span >08:00-08:40</span></td> 
                                    <td align="center" ><span >08:45-09:25</span></td> 
                                    <td align="center" ><span >09:30-10:10</span></td> 
                                    <td align="center" ><span >10:15-10:55</span></td> 
                                    <td align="center" ><span >11:00-11:40</span></td> 
                                    <td align="center" ><span >11:45-12:25</span></td> 
                                </tr>
                                <tr>
                                    <td align ="center" ><span>MCA-I</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L151" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L152" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L153" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L154" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L155" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L156" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>MCA-III</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L351" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L352" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L353" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L354" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L355" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L356" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" ><span>MCA-V</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L551" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L552" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L553" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L554" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L555" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L556" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" rowspan ="3"><span>SATURDAY</span> </td>
                                    <td align ="center" ><span>MCA-I</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L161" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L162" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L163" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L164" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L165" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L166" runat="server" Text=""></asp:Label></span> </td>
                                </tr>
                                <tr>
                                    <td align ="center" ><span>MCA-III</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L361" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L362" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L363" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L364" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L365" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L366" runat="server" Text=""></asp:Label></span> </td>
                                </tr> 
                                <tr>
                                    <td align ="center" ><span>MCA-V</span> </td>
                                    <td align ="center" ><span><asp:Label ID="L561" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L562" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L563" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L564" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L565" runat="server" Text=""></asp:Label></span> </td>
                                    <td align ="center" ><span><asp:Label ID="L566" runat="server" Text=""></asp:Label></span> </td>
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

