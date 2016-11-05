<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SaleShop_Member_Result.ascx.cs" Inherits="Database_Output_SaleShop_Member_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'SaleShop_Member_','SaleShop_Member-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="SaleShop_Member_Delete();" /></td>
<td><%=GetSortHeader("UId", "UId")%></td><td><%=GetSortHeader("UserName", "UserName")%></td><td><%=GetSortHeader("RealName", "RealName")%></td><td><%=GetSortHeader("ICON", "ICON")%></td><td><%=GetSortHeader("Password", "Password")%></td><td><%=GetSortHeader("Gender", "Gender")%></td><td><%=GetSortHeader("GroupId", "GroupId")%></td><td><%=GetSortHeader("Email", "Email")%></td><td><%=GetSortHeader("Mobile", "Mobile")%></td><td><%=GetSortHeader("District", "District")%></td><td><%=GetSortHeader("OtherContact", "OtherContact")%></td><td><%=GetSortHeader("Funds", "Funds")%></td><td><%=GetSortHeader("frostFunds", "frostFunds")%></td><td><%=GetSortHeader("Integral", "Integral")%></td><td><%=GetSortHeader("Referee", "Referee")%></td><td><%=GetSortHeader("LastIP", "LastIP")%></td><td><%=GetSortHeader("PrevIP", "PrevIP")%></td><td><%=GetSortHeader("RegIP", "RegIP")%></td><td><%=GetSortHeader("LastLoginTime", "LastLoginTime")%></td><td><%=GetSortHeader("logingtime", "logingtime")%></td><td><%=GetSortHeader("State", "State")%></td><td><%=GetSortHeader("RegTime", "RegTime")%></td><td><%=GetSortHeader("AddTime", "AddTime")%></td><td><%=GetSortHeader("IsReceiveSms", "IsReceiveSms")%></td><td><%=GetSortHeader("Friends", "Friends")%></td><td><%=GetSortHeader("loginappid", "loginappid")%></td><td><%=GetSortHeader("forgotpwdtime", "forgotpwdtime")%></td><td><%=GetSortHeader("idcard", "idcard")%></td><td><%=GetSortHeader("birthtime", "birthtime")%></td><td><%=GetSortHeader("linkaddress", "linkaddress")%></td><td><%=GetSortHeader("industry", "industry")%></td><td><%=GetSortHeader("mshopid", "mshopid")%></td><td><%=GetSortHeader("headuid", "headuid")%></td><td><%=GetSortHeader("areaid1", "areaid1")%></td><td><%=GetSortHeader("areaid2", "areaid2")%></td><td><%=GetSortHeader("areaid3", "areaid3")%></td><td><%=GetSortHeader("paypwd", "paypwd")%></td><td><%=GetSortHeader("icon_old", "icon_old")%></td><td><%=GetSortHeader("experience", "experience")%></td><td><%=GetSortHeader("IsPerfectInfo", "IsPerfectInfo")%></td><td><%=GetSortHeader("emailApprove", "emailApprove")%></td><td><%=GetSortHeader("phoneApprove", "phoneApprove")%></td><td><%=GetSortHeader("isSetSafeQuestion", "isSetSafeQuestion")%></td><td><%=GetSortHeader("question", "question")%></td><td><%=GetSortHeader("answer", "answer")%></td><td><%=GetSortHeader("isIdApprove", "isIdApprove")%></td><td><%=GetSortHeader("bankNum", "bankNum")%></td><td><%=GetSortHeader("isBingBank", "isBingBank")%></td><td><%=GetSortHeader("honourId", "honourId")%></td><td><%=GetSortHeader("gradeId", "gradeId")%></td><td><%=GetSortHeader("weixin_openid", "weixin_openid")%></td><td><%=GetSortHeader("qq_openid", "qq_openid")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("UId")%>" id="SaleShop_Member_<%#Eval("UId")%>" /></td>
<td><a href="javascript:;;" onclick="SaleShop_Member_Edit('<%#Eval("UId")%>');"><%#Eval("UId")%></a></td>
<td><%#Eval("UserName")%></td>
<td><%#Eval("RealName")%></td>
<td><%#Eval("ICON")%></td>
<td><%#Eval("Password")%></td>
<td><%#Eval("Gender")%></td>
<td><%#Eval("GroupId")%></td>
<td><%#Eval("Email")%></td>
<td><%#Eval("Mobile")%></td>
<td><%#Eval("District")%></td>
<td><%#Eval("OtherContact")%></td>
<td><%#Eval("Funds")%></td>
<td><%#Eval("frostFunds")%></td>
<td><%#Eval("Integral")%></td>
<td><%#Eval("Referee")%></td>
<td><%#Eval("LastIP")%></td>
<td><%#Eval("PrevIP")%></td>
<td><%#Eval("RegIP")%></td>
<td><%#Eval("LastLoginTime")%></td>
<td><%#Eval("logingtime")%></td>
<td><%#Eval("State")%></td>
<td><%#Eval("RegTime")%></td>
<td><%#Eval("AddTime")%></td>
<td><%#Eval("IsReceiveSms")%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("Friends"))%></td>
<td><%#Eval("loginappid")%></td>
<td><%#Eval("forgotpwdtime")%></td>
<td><%#Eval("idcard")%></td>
<td><%#Eval("birthtime")%></td>
<td><%#Eval("linkaddress")%></td>
<td><%#Eval("industry")%></td>
<td><%#Eval("mshopid")%></td>
<td><%#Eval("headuid")%></td>
<td><%#Eval("areaid1")%></td>
<td><%#Eval("areaid2")%></td>
<td><%#Eval("areaid3")%></td>
<td><%#Eval("paypwd")%></td>
<td><%#Eval("icon_old")%></td>
<td><%#Eval("experience")%></td>
<td><%#Eval("IsPerfectInfo")%></td>
<td><%#Eval("emailApprove")%></td>
<td><%#Eval("phoneApprove")%></td>
<td><%#Eval("isSetSafeQuestion")%></td>
<td><%#Eval("question")%></td>
<td><%#Eval("answer")%></td>
<td><%#Eval("isIdApprove")%></td>
<td><%#Eval("bankNum")%></td>
<td><%#Eval("isBingBank")%></td>
<td><%#Eval("honourId")%></td>
<td><%#Eval("gradeId")%></td>
<td><%#Eval("weixin_openid")%></td>
<td><%#Eval("qq_openid")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
