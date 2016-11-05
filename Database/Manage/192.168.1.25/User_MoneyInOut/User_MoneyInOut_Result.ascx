<%@ Control Language="C#" AutoEventWireup="true" CodeFile="User_MoneyInOut_Result.ascx.cs" Inherits="Database_Output_User_MoneyInOut_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'User_MoneyInOut_','User_MoneyInOut-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="User_MoneyInOut_Delete();" /></td>
<td><%=GetSortHeader("Id", "Id")%></td><td><%=GetSortHeader("WasteBookId", "WasteBookId")%></td><td><%=GetSortHeader("UId", "UId")%></td><td><%=GetSortHeader("OrderId", "OrderId")%></td><td><%=GetSortHeader("Flag", "Flag")%></td><td><%=GetSortHeader("Momey", "Momey")%></td><td><%=GetSortHeader("MoneyType", "MoneyType")%></td><td><%=GetSortHeader("Note", "Note")%></td><td><%=GetSortHeader("Source", "Source")%></td><td><%=GetSortHeader("PayCode", "PayCode")%></td><td><%=GetSortHeader("PayBookId", "PayBookId")%></td><td><%=GetSortHeader("BeginTime", "BeginTime")%></td><td><%=GetSortHeader("EndTime", "EndTime")%></td><td><%=GetSortHeader("State", "State")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("Id")%>" id="User_MoneyInOut_<%#Eval("Id")%>" /></td>
<td><a href="javascript:;;" onclick="User_MoneyInOut_Edit('<%#Eval("Id")%>');"><%#Eval("Id")%></a></td>
<td><%#Eval("WasteBookId")%></td>
<td><%#Eval("UId")%></td>
<td><%#Eval("OrderId")%></td>
<td><%#Eval("Flag")%></td>
<td><%#Eval("Momey")%></td>
<td><%#Eval("MoneyType")%></td>
<td><%#Eval("Note")%></td>
<td><%#Eval("Source")%></td>
<td><%#Eval("PayCode")%></td>
<td><%#Eval("PayBookId")%></td>
<td><%#Eval("BeginTime")%></td>
<td><%#Eval("EndTime")%></td>
<td><%#Eval("State")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
