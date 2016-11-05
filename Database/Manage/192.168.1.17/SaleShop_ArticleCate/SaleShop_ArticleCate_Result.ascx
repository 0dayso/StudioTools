<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SaleShop_ArticleCate_Result.ascx.cs" Inherits="Database_Output_SaleShop_ArticleCate_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'SaleShop_ArticleCate_','SaleShop_ArticleCate-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="SaleShop_ArticleCate_Delete();" /></td>
<td><%=GetSortHeader("Id", "Id")%></td><td><%=GetSortHeader("Level", "Level")%></td><td><%=GetSortHeader("ParentId", "ParentId")%></td><td><%=GetSortHeader("Name", "Name")%></td><td><%=GetSortHeader("CateType", "CateType")%></td><td><%=GetSortHeader("ShopId", "ShopId")%></td><td><%=GetSortHeader("UrlAlias", "UrlAlias")%></td><td><%=GetSortHeader("AddTime", "AddTime")%></td><td><%=GetSortHeader("Adder", "Adder")%></td><td><%=GetSortHeader("SeoKeywords", "SeoKeywords")%></td><td><%=GetSortHeader("SeoDescription", "SeoDescription")%></td><td><%=GetSortHeader("IsSys", "IsSys")%></td><td><%=GetSortHeader("OrderNum", "OrderNum")%></td><td><%=GetSortHeader("Editor", "Editor")%></td><td><%=GetSortHeader("EditTime", "EditTime")%></td><td><%=GetSortHeader("Disable", "Disable")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("Id")%>" id="SaleShop_ArticleCate_<%#Eval("Id")%>" /></td>
<td><a href="javascript:;;" onclick="SaleShop_ArticleCate_Edit('<%#Eval("Id")%>');"><%#Eval("Id")%></a></td>
<td><%#Eval("Level")%></td>
<td><%#Eval("ParentId")%></td>
<td><%#Eval("Name")%></td>
<td><%#Eval("CateType")%></td>
<td><%#Eval("ShopId")%></td>
<td><%#Eval("UrlAlias")%></td>
<td><%#Eval("AddTime")%></td>
<td><%#Eval("Adder")%></td>
<td><%#Eval("SeoKeywords")%></td>
<td><%#Eval("SeoDescription")%></td>
<td><%#Eval("IsSys")%></td>
<td><%#Eval("OrderNum")%></td>
<td><%#Eval("Editor")%></td>
<td><%#Eval("EditTime")%></td>
<td><%#Eval("Disable")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
