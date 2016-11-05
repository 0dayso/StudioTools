<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SaleShop_ShopInfo_Result.ascx.cs" Inherits="Database_Output_SaleShop_ShopInfo_Result" %>
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
<input id="selAll" type="checkbox" onclick="SelectAll(this,'SaleShop_ShopInfo_','SaleShop_ShopInfo-Result')" style="border-width: 0px;" />
<img src="<%=ResolveUrl("~") %>themes/skin-1/images/delete_icon.gif" onclick="SaleShop_ShopInfo_Delete();" /></td>
<td><%=GetSortHeader("ShopId", "ShopId")%></td><td><%=GetSortHeader("CorpId", "CorpId")%></td><td><%=GetSortHeader("StId", "StId")%></td><td><%=GetSortHeader("ShopType", "ShopType")%></td><td><%=GetSortHeader("ShopBelong", "ShopBelong")%></td><td><%=GetSortHeader("ScId", "ScId")%></td><td><%=GetSortHeader("ScIdSon", "ScIdSon")%></td><td><%=GetSortHeader("ShopName", "ShopName")%></td><td><%=GetSortHeader("ShopSubName", "ShopSubName")%></td><td><%=GetSortHeader("WebTitle", "WebTitle")%></td><td><%=GetSortHeader("ProvinceId", "ProvinceId")%></td><td><%=GetSortHeader("CityId", "CityId")%></td><td><%=GetSortHeader("AreaId", "AreaId")%></td><td><%=GetSortHeader("ShopGrade", "ShopGrade")%></td><td><%=GetSortHeader("ShopImg", "ShopImg")%></td><td><%=GetSortHeader("Landmark", "Landmark")%></td><td><%=GetSortHeader("Address", "Address")%></td><td><%=GetSortHeader("SvrTel", "SvrTel")%></td><td><%=GetSortHeader("SvrQQ", "SvrQQ")%></td><td><%=GetSortHeader("SvrWorking", "SvrWorking")%></td><td><%=GetSortHeader("DiscountInfo", "DiscountInfo")%></td><td><%=GetSortHeader("DiscountStartTime", "DiscountStartTime")%></td><td><%=GetSortHeader("DiscountEndTime", "DiscountEndTime")%></td><td><%=GetSortHeader("MapAddress", "MapAddress")%></td><td><%=GetSortHeader("Longitude", "Longitude")%></td><td><%=GetSortHeader("Latitude", "Latitude")%></td><td><%=GetSortHeader("IsMain", "IsMain")%></td><td><%=GetSortHeader("ShopInstroduction", "ShopInstroduction")%></td><td><%=GetSortHeader("ShoppingGuide", "ShoppingGuide")%></td><td><%=GetSortHeader("SvrCusServices", "SvrCusServices")%></td><td><%=GetSortHeader("TradeRate", "TradeRate")%></td><td><%=GetSortHeader("IsMsgSend", "IsMsgSend")%></td><td><%=GetSortHeader("Domain", "Domain")%></td><td><%=GetSortHeader("LogoType", "LogoType")%></td><td><%=GetSortHeader("LogoText", "LogoText")%></td><td><%=GetSortHeader("LogoImg", "LogoImg")%></td><td><%=GetSortHeader("StartLevel", "StartLevel")%></td><td><%=GetSortHeader("Population", "Population")%></td><td><%=GetSortHeader("HitCount", "HitCount")%></td><td><%=GetSortHeader("Deposit", "Deposit")%></td><td><%=GetSortHeader("MetaKeyword", "MetaKeyword")%></td><td><%=GetSortHeader("MetaDescrition", "MetaDescrition")%></td><td><%=GetSortHeader("ShopICP", "ShopICP")%></td><td><%=GetSortHeader("WeixinToken", "WeixinToken")%></td><td><%=GetSortHeader("WeixinAppid", "WeixinAppid")%></td><td><%=GetSortHeader("WeixinAppSecret", "WeixinAppSecret")%></td><td><%=GetSortHeader("WeixinPublicAcount", "WeixinPublicAcount")%></td><td><%=GetSortHeader("WeixinQrCode", "WeixinQrCode")%></td><td><%=GetSortHeader("WeixinImg", "WeixinImg")%></td><td><%=GetSortHeader("BankType", "BankType")%></td><td><%=GetSortHeader("BankOwer", "BankOwer")%></td><td><%=GetSortHeader("BankName", "BankName")%></td><td><%=GetSortHeader("BankAccount", "BankAccount")%></td><td><%=GetSortHeader("MgrName", "MgrName")%></td><td><%=GetSortHeader("MgrEmail", "MgrEmail")%></td><td><%=GetSortHeader("MgrQQ", "MgrQQ")%></td><td><%=GetSortHeader("MgrTel", "MgrTel")%></td><td><%=GetSortHeader("AttachLicense", "AttachLicense")%></td><td><%=GetSortHeader("AttachJoin", "AttachJoin")%></td><td><%=GetSortHeader("AttachMgrIDCard", "AttachMgrIDCard")%></td><td><%=GetSortHeader("ApplyId", "ApplyId")%></td><td><%=GetSortHeader("OrderNum", "OrderNum")%></td><td><%=GetSortHeader("Disable", "Disable")%></td><td><%=GetSortHeader("CreateTime", "CreateTime")%></td><td><%=GetSortHeader("Editor", "Editor")%></td><td><%=GetSortHeader("EditTime", "EditTime")%></td>
    </tr>
    <asp:Repeater runat="server" ID="RepeaterLogin">
        <ItemTemplate>
            <tr>
                <td><input type="checkbox" value="<%#Eval("ShopId")%>" id="SaleShop_ShopInfo_<%#Eval("ShopId")%>" /></td>
<td><a href="javascript:;;" onclick="SaleShop_ShopInfo_Edit('<%#Eval("ShopId")%>');"><%#Eval("ShopId")%></a></td>
<td><%#Eval("CorpId")%></td>
<td><%#Eval("StId")%></td>
<td><%#Eval("ShopType")%></td>
<td><%#Eval("ShopBelong")%></td>
<td><%#Eval("ScId")%></td>
<td><%#Eval("ScIdSon")%></td>
<td><%#Eval("ShopName")%></td>
<td><%#Eval("ShopSubName")%></td>
<td><%#Eval("WebTitle")%></td>
<td><%#Eval("ProvinceId")%></td>
<td><%#Eval("CityId")%></td>
<td><%#Eval("AreaId")%></td>
<td><%#Eval("ShopGrade")%></td>
<td><%#Eval("ShopImg")%></td>
<td><%#Eval("Landmark")%></td>
<td><%#Eval("Address")%></td>
<td><%#Eval("SvrTel")%></td>
<td><%#Eval("SvrQQ")%></td>
<td><%#Eval("SvrWorking")%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("DiscountInfo"))%></td>
<td><%#Eval("DiscountStartTime")%></td>
<td><%#Eval("DiscountEndTime")%></td>
<td><%#Eval("MapAddress")%></td>
<td><%#Eval("Longitude")%></td>
<td><%#Eval("Latitude")%></td>
<td><%#Eval("IsMain")%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("ShopInstroduction"))%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("ShoppingGuide"))%></td>
<td><%#System.Web.HttpUtility.HtmlDecode((string)Eval("SvrCusServices"))%></td>
<td><%#Eval("TradeRate")%></td>
<td><%#Eval("IsMsgSend")%></td>
<td><%#Eval("Domain")%></td>
<td><%#Eval("LogoType")%></td>
<td><%#Eval("LogoText")%></td>
<td><%#Eval("LogoImg")%></td>
<td><%#Eval("StartLevel")%></td>
<td><%#Eval("Population")%></td>
<td><%#Eval("HitCount")%></td>
<td><%#Eval("Deposit")%></td>
<td><%#Eval("MetaKeyword")%></td>
<td><%#Eval("MetaDescrition")%></td>
<td><%#Eval("ShopICP")%></td>
<td><%#Eval("WeixinToken")%></td>
<td><%#Eval("WeixinAppid")%></td>
<td><%#Eval("WeixinAppSecret")%></td>
<td><%#Eval("WeixinPublicAcount")%></td>
<td><%#Eval("WeixinQrCode")%></td>
<td><%#Eval("WeixinImg")%></td>
<td><%#Eval("BankType")%></td>
<td><%#Eval("BankOwer")%></td>
<td><%#Eval("BankName")%></td>
<td><%#Eval("BankAccount")%></td>
<td><%#Eval("MgrName")%></td>
<td><%#Eval("MgrEmail")%></td>
<td><%#Eval("MgrQQ")%></td>
<td><%#Eval("MgrTel")%></td>
<td><%#Eval("AttachLicense")%></td>
<td><%#Eval("AttachJoin")%></td>
<td><%#Eval("AttachMgrIDCard")%></td>
<td><%#Eval("ApplyId")%></td>
<td><%#Eval("OrderNum")%></td>
<td><%#Eval("Disable")%></td>
<td><%#Eval("CreateTime")%></td>
<td><%#Eval("Editor")%></td>
<td><%#Eval("EditTime")%></td>

            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
</div>
<div class="header-2" style="padding-left:5px;"><%=ShowPaging() %></div>
