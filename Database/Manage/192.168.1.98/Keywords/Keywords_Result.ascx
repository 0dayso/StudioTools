<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Keywords_Result.ascx.cs" Inherits="Database_Output_Keywords_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'Keywords_','Keywords-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="Keywords_Delete();" /></td>
<td><%=GetSortHeader("id", "id")%></td><td><%=GetSortHeader("find", "find")%></td><td><%=GetSortHeader("replacement", "replacement")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("id")%>" id="Keywords_<%#Eval("id")%>" /></td>
<td><a href="javascript:;;" onclick="Keywords_Edit('<%#Eval("id")%>');"><%#Eval("id")%></a></td>
<td><%#Eval("find")%></td>
<td><%#Eval("replacement")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
