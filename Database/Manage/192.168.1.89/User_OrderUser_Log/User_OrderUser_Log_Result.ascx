<%@ Control Language="C#" AutoEventWireup="true" CodeFile="User_OrderUser_Log_Result.ascx.cs" Inherits="Database_Output_User_OrderUser_Log_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'User_OrderUser_Log_','User_OrderUser_Log-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="User_OrderUser_Log_Delete();" /></td>
<td><%=GetSortHeader("id", "id")%></td><td><%=GetSortHeader("ordersid", "ordersid")%></td><td><%=GetSortHeader("remark", "remark")%></td><td><%=GetSortHeader("receivename", "receivename")%></td><td><%=GetSortHeader("receivetel", "receivetel")%></td><td><%=GetSortHeader("receivemobile", "receivemobile")%></td><td><%=GetSortHeader("receivepostcode", "receivepostcode")%></td><td><%=GetSortHeader("receiveaddress", "receiveaddress")%></td><td><%=GetSortHeader("adminname", "adminname")%></td><td><%=GetSortHeader("logtime", "logtime")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("id")%>" id="User_OrderUser_Log_<%#Eval("id")%>" /></td>
<td><a href="javascript:;;" onclick="User_OrderUser_Log_Edit('<%#Eval("id")%>');"><%#Eval("id")%></a></td>
<td><%#Eval("ordersid")%></td>
<td><%#Eval("remark")%></td>
<td><%#Eval("receivename")%></td>
<td><%#Eval("receivetel")%></td>
<td><%#Eval("receivemobile")%></td>
<td><%#Eval("receivepostcode")%></td>
<td><%#Eval("receiveaddress")%></td>
<td><%#Eval("adminname")%></td>
<td><%#Eval("logtime")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
