<%@ Control Language="C#" AutoEventWireup="true" CodeFile="APIS_Info_Result.ascx.cs" Inherits="Database_Output_APIS_Info_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'APIS_Info_','APIS_Info-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="APIS_Info_Delete();" /></td>
<td><%=GetSortHeader("Id", "Id")%></td><td><%=GetSortHeader("Country", "Country")%></td><td><%=GetSortHeader("Airlines", "Airlines")%></td><td><%=GetSortHeader("IsRequired", "IsRequired")%></td><td><%=GetSortHeader("CreateOn", "CreateOn")%></td><td><%=GetSortHeader("CreateBy", "CreateBy")%></td><td><%=GetSortHeader("UpdateOn", "UpdateOn")%></td><td><%=GetSortHeader("UpdateBy", "UpdateBy")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("Id")%>" id="APIS_Info_<%#Eval("Id")%>" /></td>
<td><a href="javascript:;;" onclick="APIS_Info_Edit('<%#Eval("Id")%>');"><%#Eval("Id")%></a></td>
<td><%#Eval("Country")%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("Airlines"))%></td>
<td><%#Eval("IsRequired")%></td>
<td><%#Eval("CreateOn")%></td>
<td><%#Eval("CreateBy")%></td>
<td><%#Eval("UpdateOn")%></td>
<td><%#Eval("UpdateBy")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
