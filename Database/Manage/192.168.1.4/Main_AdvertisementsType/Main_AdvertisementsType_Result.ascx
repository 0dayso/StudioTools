<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Main_AdvertisementsType_Result.ascx.cs" Inherits="Database_Output_Main_AdvertisementsType_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'Main_AdvertisementsType_','Main_AdvertisementsType-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="Main_AdvertisementsType_Delete();" /></td>
<td><%=GetSortHeader("Id", "Id")%></td><td><%=GetSortHeader("Name", "Name")%></td><td><%=GetSortHeader("Price", "Price")%></td><td><%=GetSortHeader("ImgUrl", "ImgUrl")%></td><td><%=GetSortHeader("Adway", "Adway")%></td><td><%=GetSortHeader("DefaultHtmlCode", "DefaultHtmlCode")%></td><td><%=GetSortHeader("DefaultParameter", "DefaultParameter")%></td><td><%=GetSortHeader("EditTime", "EditTime")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("Id")%>" id="Main_AdvertisementsType_<%#Eval("Id")%>" /></td>
<td><a href="javascript:;;" onclick="Main_AdvertisementsType_Edit('<%#Eval("Id")%>');"><%#Eval("Id")%></a></td>
<td><%#Eval("Name")%></td>
<td><%#Eval("Price")%></td>
<td><%#Eval("ImgUrl")%></td>
<td><%#Eval("Adway")%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("DefaultHtmlCode"))%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("DefaultParameter"))%></td>
<td><%#Eval("EditTime")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
