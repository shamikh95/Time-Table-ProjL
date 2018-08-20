<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePopup.aspx.cs" Inherits="UpdatePopup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type = "text/css"  >
        .mb
        {
            background :black;
            filter:alpha(opacity=90);
            opacity:0.8;
        }
        .mp
        {
            background :white;
            border :10px solid #d0d0d0;
            padding-top :10px;
            padding-left :10px;
            width :300px;
            height :200px;
            z-index :100;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class ="mb ">
    <div>
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <cc1:ModalPopupExtender ID="ModalPopupExtender1" DropShadow ="true" CancelControlID ="ButtonCancel" OkControlID ="ButtonOk"   TargetControlID ="LinkButton1" runat="server" PopupControlID ="pnlPopup">
        </cc1:ModalPopupExtender>
        <asp:Panel ID="pnlPopup" runat="server" CssClass ="mp " style="display:none;" >
        <div>
            <table border="0" cellspacing="4" cellpadding="0">
            <tr>
                <td align="right" valign="top"></td>
                <td><h1>Edit Block</h1></td>
            </tr>
            <tr>
                <td align="right" valign="top">Start:</td>
                <td>
                <asp:DropDownList ID="DropDownListStart" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" valign="top">End:</td>
                <td><asp:DropDownList ID="DropDownListEnd" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td align="right"></td>
                <td>
                    <asp:Button ID="ButtonOK" runat="server"  Text="OK" />
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel"  />
                </td>
            </tr>
        </table>
        
        </asp:Panel>
        
    </div>
    </form>
</body>
</html>
