<%@ control language="C#" autoeventwireup="true" inherits="Database_Output_Goods_lable_Result, App_Web_goods_lable_result.ascx.eeccb890" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'Goods_lable_','Goods_lable-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="Goods_lable_Delete();" /></td>
<td><%=GetSortHeader("lableid", "lableid")%></td><td><%=GetSortHeader("merchantid", "merchantid")%></td><td><%=GetSortHeader("lablename", "lablename")%></td><td><%=GetSortHeader("lablecolor", "lablecolor")%></td><td><%=GetSortHeader("addTime", "addTime")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("lableid")%>" id="Goods_lable_<%#Eval("lableid")%>" /></td>
<td><a href="javascript:;;" onclick="Goods_lable_Edit('<%#Eval("lableid")%>');"><%#Eval("lableid")%></a></td>
<td><%#Eval("merchantid")%></td>
<td><%#Eval("lablename")%></td>
<td><%#Eval("lablecolor")%></td>
<td><%#Eval("addTime")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
