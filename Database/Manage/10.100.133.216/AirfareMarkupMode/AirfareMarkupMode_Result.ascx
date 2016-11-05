<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AirfareMarkupMode_Result.ascx.cs" Inherits="Database_Output_AirfareMarkupMode_Result" %>
<table style="width:100%;" border="0">
    <tr>
        <td align="right">
            <%=GetTogether.Web.HtmlHelper.GenRecordInfo(Total)%>
            &nbsp;<%=GenPageSize()%>
        </td>
    </tr>
</table>
<div class="manage-result">
<table style="width:100%;" border="0" cellpadding="0px" cellspacing="0px">
    <tr class="header">
       <td style='white-space:nowrap;'>
<input id="selAll" type="checkbox" onclick="SelectAll(this,'AirfareMarkupMode_','AirfareMarkupMode-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="AirfareMarkupMode_Delete();" /></td>
<td><%=GetSortHeader("ID", "ID")%></td><td><%=GetSortHeader("DetailId", "DetailId")%></td><td><%=GetSortHeader("Rank", "Rank")%></td><td><%=GetSortHeader("MarkupBy", "MarkupBy")%></td><td><%=GetSortHeader("Amount", "Amount")%></td><td><%=GetSortHeader("Rate", "Rate")%></td><td><%=GetSortHeader("RoundUpBy", "RoundUpBy")%></td><td><%=GetSortHeader("IsRoundDown", "IsRoundDown")%></td><td><%=GetSortHeader("MarkupByValue", "MarkupByValue")%></td><td><%=GetSortHeader("Description", "Description")%></td><td><%=GetSortHeader("AirfareMarkupModeType", "AirfareMarkupModeType")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("ID")%>" id="AirfareMarkupMode_<%#Eval("ID")%>" /></td>
<td><a href="javascript:;;" onclick="AirfareMarkupMode_Edit('<%#Eval("ID")%>');"><%#Eval("ID")%></a></td>
<td><%#Eval("DetailId")%></td>
<td><%#Eval("Rank")%></td>
<td><%#Eval("MarkupBy")%></td>
<td><%#Eval("Amount")%></td>
<td><%#Eval("Rate")%></td>
<td><%#Eval("RoundUpBy")%></td>
<td><%#Eval("IsRoundDown")%></td>
<td><%#Eval("MarkupByValue")%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("Description"))%></td>
<td><%#Eval("AirfareMarkupModeType")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
