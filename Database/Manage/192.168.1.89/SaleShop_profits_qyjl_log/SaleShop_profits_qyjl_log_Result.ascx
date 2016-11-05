<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SaleShop_profits_qyjl_log_Result.ascx.cs" Inherits="Database_Output_SaleShop_profits_qyjl_log_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'SaleShop_profits_qyjl_log_','SaleShop_profits_qyjl_log-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="SaleShop_profits_qyjl_log_Delete();" /></td>
<td><%=GetSortHeader("id", "id")%></td><td><%=GetSortHeader("uid", "uid")%></td><td><%=GetSortHeader("orderid", "orderid")%></td><td><%=GetSortHeader("mshopid", "mshopid")%></td><td><%=GetSortHeader("original_price", "original_price")%></td><td><%=GetSortHeader("managerRatio", "managerRatio")%></td><td><%=GetSortHeader("profits_price", "profits_price")%></td><td><%=GetSortHeader("addtime", "addtime")%></td><td><%=GetSortHeader("status", "status")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("id")%>" id="SaleShop_profits_qyjl_log_<%#Eval("id")%>" /></td>
<td><a href="javascript:;;" onclick="SaleShop_profits_qyjl_log_Edit('<%#Eval("id")%>');"><%#Eval("id")%></a></td>
<td><%#Eval("uid")%></td>
<td><%#Eval("orderid")%></td>
<td><%#Eval("mshopid")%></td>
<td><%#Eval("original_price")%></td>
<td><%#Eval("managerRatio")%></td>
<td><%#Eval("profits_price")%></td>
<td><%#Eval("addtime")%></td>
<td><%#Eval("status")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
