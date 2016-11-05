<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ErrorDescrption_Result.ascx.cs" Inherits="Database_Output_ErrorDescrption_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'ErrorDescrption_','ErrorDescrption-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="ErrorDescrption_Delete();" /></td>
<td><%=GetSortHeader("Code", "Code")%></td><td><%=GetSortHeader("Description", "Description")%></td><td><%=GetSortHeader("DescriptionKeywords", "DescriptionKeywords")%></td><td><%=GetSortHeader("DescriptionType", "DescriptionType")%></td><td><%=GetSortHeader("CreateOn", "CreateOn")%></td><td><%=GetSortHeader("CreateBy", "CreateBy")%></td><td><%=GetSortHeader("UpdateOn", "UpdateOn")%></td><td><%=GetSortHeader("UpdateBy", "UpdateBy")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("Code")%>" id="ErrorDescrption_<%#Eval("Code")%>" /></td>
<td><a href="javascript:;;" onclick="ErrorDescrption_Edit('<%#Eval("Code")%>');"><%#Eval("Code")%></a></td>
<td><%#Eval("Description")%></td>
<td><%#Eval("DescriptionKeywords")%></td>
<td><%#Eval("DescriptionType")%></td>
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
