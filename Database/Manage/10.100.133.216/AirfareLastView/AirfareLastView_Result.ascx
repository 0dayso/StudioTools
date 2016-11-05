<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AirfareLastView_Result.ascx.cs" Inherits="Database_Output_AirfareLastView_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'AirfareLastView_','AirfareLastView-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="AirfareLastView_Delete();" /></td>
<td><%=GetSortHeader("Id", "Id")%></td><td><%=GetSortHeader("CompanyCode", "CompanyCode")%></td><td><%=GetSortHeader("UserCode", "UserCode")%></td><td><%=GetSortHeader("Org", "Org")%></td><td><%=GetSortHeader("Dst", "Dst")%></td><td><%=GetSortHeader("OWRTOJ", "OWRTOJ")%></td><td><%=GetSortHeader("LastViewDate", "LastViewDate")%></td><td><%=GetSortHeader("IsDirect", "IsDirect")%></td><td><%=GetSortHeader("DepartureDate", "DepartureDate")%></td><td><%=GetSortHeader("ReturnDate", "ReturnDate")%></td><td><%=GetSortHeader("Airline", "Airline")%></td><td><%=GetSortHeader("FareCat", "FareCat")%></td><td><%=GetSortHeader("BkgClass", "BkgClass")%></td><td><%=GetSortHeader("FareClass", "FareClass")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("Id")%>" id="AirfareLastView_<%#Eval("Id")%>" /></td>
<td><a href="javascript:;;" onclick="AirfareLastView_Edit('<%#Eval("Id")%>');"><%#Eval("Id")%></a></td>
<td><%#Eval("CompanyCode")%></td>
<td><%#Eval("UserCode")%></td>
<td><%#Eval("Org")%></td>
<td><%#Eval("Dst")%></td>
<td><%#Eval("OWRTOJ")%></td>
<td><%#Eval("LastViewDate")%></td>
<td><%#Eval("IsDirect")%></td>
<td><%#Eval("DepartureDate")%></td>
<td><%#Eval("ReturnDate")%></td>
<td><%#Eval("Airline")%></td>
<td><%#Eval("FareCat")%></td>
<td><%#Eval("BkgClass")%></td>
<td><%#Eval("FareClass")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
