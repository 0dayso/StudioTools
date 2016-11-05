<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SaleShop_payment_Result.ascx.cs" Inherits="Database_Output_SaleShop_payment_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'SaleShop_payment_','SaleShop_payment-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="SaleShop_payment_Delete();" /></td>
<td><%=GetSortHeader("pay_id", "pay_id")%></td><td><%=GetSortHeader("pay_name", "pay_name")%></td><td><%=GetSortHeader("pay_code", "pay_code")%></td><td><%=GetSortHeader("pay_fee", "pay_fee")%></td><td><%=GetSortHeader("pay_desc", "pay_desc")%></td><td><%=GetSortHeader("Orderdisplay", "Orderdisplay")%></td><td><%=GetSortHeader("Interface", "Interface")%></td><td><%=GetSortHeader("pay_config", "pay_config")%></td><td><%=GetSortHeader("enabled", "enabled")%></td><td><%=GetSortHeader("is_cod", "is_cod")%></td><td><%=GetSortHeader("is_online", "is_online")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("pay_id")%>" id="SaleShop_payment_<%#Eval("pay_id")%>" /></td>
<td><a href="javascript:;;" onclick="SaleShop_payment_Edit('<%#Eval("pay_id")%>');"><%#Eval("pay_id")%></a></td>
<td><%#Eval("pay_name")%></td>
<td><%#Eval("pay_code")%></td>
<td><%#Eval("pay_fee")%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("pay_desc"))%></td>
<td><%#Eval("Orderdisplay")%></td>
<td><%#Eval("Interface")%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("pay_config"))%></td>
<td><%#Eval("enabled")%></td>
<td><%#Eval("is_cod")%></td>
<td><%#Eval("is_online")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
