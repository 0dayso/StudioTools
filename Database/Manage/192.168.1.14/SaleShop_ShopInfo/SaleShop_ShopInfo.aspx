<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_ShopInfo.aspx.cs" Inherits="Database_Output_SaleShop_ShopInfo" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	    <link href="<%=ResolveClientUrl("~") %>/themes/skin-1/ws.css" rel="stylesheet" type="text/css" />
	<style rel="stylesheet" type="text/css">
	body
	{
		margin:0px 5px;
	}
	.manage-result
	{
		background-color:#fff;
		border-top:solid 1px #DCDFE1;
		border-left:solid 1px #DCDFE1;
		border-right:solid 1px #DCDFE1;
	}
	.manage-result td
	{
		border-bottom:solid 1px #ddd;
		padding-right:5px;
		vertical-align:top;
		padding:3px 5px 3px 0px;
	}
	.manage-search
	{
		border:solid 1px #DCDFE1;
		background-color: #F2F2F2;
	}
	.manage-search ul
	{
		float:left;
	}
	.manage-search li
	{
		float:left;
		width:16%;
		margin-bottom:2px;
	}
	.header td
	{
	    padding:0px;
	    padding-right:5px;
	}
	</style>
</head>
<body style="background-image:none;">
    <div id="SaleShop_ShopInfo-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>SaleShop_ShopInfo Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>ShopId:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopId" name="SaleShop_ShopInfo_ShopId" /></li>
<li>CorpId:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_CorpId" name="SaleShop_ShopInfo_CorpId" /></li>
<li>StId:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_StId" name="SaleShop_ShopInfo_StId" /></li>
<li>ShopType:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopType" name="SaleShop_ShopInfo_ShopType" /></li>
<li>ShopBelong:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopBelong" name="SaleShop_ShopInfo_ShopBelong" /></li>
<li>ScId:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ScId" name="SaleShop_ShopInfo_ScId" /></li>
<li>ScIdSon:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ScIdSon" name="SaleShop_ShopInfo_ScIdSon" /></li>
<li>ShopName:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopName" name="SaleShop_ShopInfo_ShopName" /></li>
<li>ShopSubName:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopSubName" name="SaleShop_ShopInfo_ShopSubName" /></li>
<li>WebTitle:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_WebTitle" name="SaleShop_ShopInfo_WebTitle" /></li>
<li>ProvinceId:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ProvinceId" name="SaleShop_ShopInfo_ProvinceId" /></li>
<li>CityId:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_CityId" name="SaleShop_ShopInfo_CityId" /></li>
<li>AreaId:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_AreaId" name="SaleShop_ShopInfo_AreaId" /></li>
<li>ShopGrade:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopGrade" name="SaleShop_ShopInfo_ShopGrade" /></li>
<li>ShopImg:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopImg" name="SaleShop_ShopInfo_ShopImg" /></li>
<li>Landmark:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Landmark" name="SaleShop_ShopInfo_Landmark" /></li>
<li>Address:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Address" name="SaleShop_ShopInfo_Address" /></li>
<li>SvrTel:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_SvrTel" name="SaleShop_ShopInfo_SvrTel" /></li>
<li>SvrQQ:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_SvrQQ" name="SaleShop_ShopInfo_SvrQQ" /></li>
<li>SvrWorking:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_SvrWorking" name="SaleShop_ShopInfo_SvrWorking" /></li>
<li>DiscountInfo:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_DiscountInfo" name="SaleShop_ShopInfo_DiscountInfo" /></li>
<li>DiscountStartTime:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_DiscountStartTime" name="SaleShop_ShopInfo_DiscountStartTime" /></li>
<li>DiscountEndTime:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_DiscountEndTime" name="SaleShop_ShopInfo_DiscountEndTime" /></li>
<li>MapAddress:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_MapAddress" name="SaleShop_ShopInfo_MapAddress" /></li>
<li>Longitude:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Longitude" name="SaleShop_ShopInfo_Longitude" /></li>
<li>Latitude:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Latitude" name="SaleShop_ShopInfo_Latitude" /></li>
<li>IsMain:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_IsMain" name="SaleShop_ShopInfo_IsMain" /></li>
<li>ShopInstroduction:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopInstroduction" name="SaleShop_ShopInfo_ShopInstroduction" /></li>
<li>ShoppingGuide:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShoppingGuide" name="SaleShop_ShopInfo_ShoppingGuide" /></li>
<li>SvrCusServices:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_SvrCusServices" name="SaleShop_ShopInfo_SvrCusServices" /></li>
<li>TradeRate:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_TradeRate" name="SaleShop_ShopInfo_TradeRate" /></li>
<li>IsMsgSend:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_IsMsgSend" name="SaleShop_ShopInfo_IsMsgSend" /></li>
<li>Domain:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Domain" name="SaleShop_ShopInfo_Domain" /></li>
<li>LogoType:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_LogoType" name="SaleShop_ShopInfo_LogoType" /></li>
<li>LogoText:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_LogoText" name="SaleShop_ShopInfo_LogoText" /></li>
<li>LogoImg:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_LogoImg" name="SaleShop_ShopInfo_LogoImg" /></li>
<li>StartLevel:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_StartLevel" name="SaleShop_ShopInfo_StartLevel" /></li>
<li>Population:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Population" name="SaleShop_ShopInfo_Population" /></li>
<li>HitCount:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_HitCount" name="SaleShop_ShopInfo_HitCount" /></li>
<li>Deposit:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Deposit" name="SaleShop_ShopInfo_Deposit" /></li>
<li>MetaKeyword:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_MetaKeyword" name="SaleShop_ShopInfo_MetaKeyword" /></li>
<li>MetaDescrition:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_MetaDescrition" name="SaleShop_ShopInfo_MetaDescrition" /></li>
<li>ShopICP:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ShopICP" name="SaleShop_ShopInfo_ShopICP" /></li>
<li>WeixinToken:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinToken" name="SaleShop_ShopInfo_WeixinToken" /></li>
<li>WeixinAppid:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinAppid" name="SaleShop_ShopInfo_WeixinAppid" /></li>
<li>WeixinAppSecret:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinAppSecret" name="SaleShop_ShopInfo_WeixinAppSecret" /></li>
<li>WeixinPublicAcount:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinPublicAcount" name="SaleShop_ShopInfo_WeixinPublicAcount" /></li>
<li>WeixinQrCode:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinQrCode" name="SaleShop_ShopInfo_WeixinQrCode" /></li>
<li>WeixinImg:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinImg" name="SaleShop_ShopInfo_WeixinImg" /></li>
<li>BankType:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_BankType" name="SaleShop_ShopInfo_BankType" /></li>
<li>BankOwer:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_BankOwer" name="SaleShop_ShopInfo_BankOwer" /></li>
<li>BankName:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_BankName" name="SaleShop_ShopInfo_BankName" /></li>
<li>BankAccount:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_BankAccount" name="SaleShop_ShopInfo_BankAccount" /></li>
<li>MgrName:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_MgrName" name="SaleShop_ShopInfo_MgrName" /></li>
<li>MgrEmail:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_MgrEmail" name="SaleShop_ShopInfo_MgrEmail" /></li>
<li>MgrQQ:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_MgrQQ" name="SaleShop_ShopInfo_MgrQQ" /></li>
<li>MgrTel:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_MgrTel" name="SaleShop_ShopInfo_MgrTel" /></li>
<li>AttachLicense:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_AttachLicense" name="SaleShop_ShopInfo_AttachLicense" /></li>
<li>AttachJoin:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_AttachJoin" name="SaleShop_ShopInfo_AttachJoin" /></li>
<li>AttachMgrIDCard:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_AttachMgrIDCard" name="SaleShop_ShopInfo_AttachMgrIDCard" /></li>
<li>ApplyId:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_ApplyId" name="SaleShop_ShopInfo_ApplyId" /></li>
<li>OrderNum:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_OrderNum" name="SaleShop_ShopInfo_OrderNum" /></li>
<li>Disable:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Disable" name="SaleShop_ShopInfo_Disable" /></li>
<li>CreateTime:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_CreateTime" name="SaleShop_ShopInfo_CreateTime" /></li>
<li>Editor:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_Editor" name="SaleShop_ShopInfo_Editor" /></li>
<li>EditTime:</li><li><input type="text" class="txt" id="SaleShop_ShopInfo_EditTime" name="SaleShop_ShopInfo_EditTime" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="SaleShop_ShopInfo_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='SaleShop_ShopInfo_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="SaleShop_ShopInfo-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            SaleShop_ShopInfo_Search();
        });
		SerUrl=null;//Pending
        function SaleShop_ShopInfo_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('SaleShop_ShopInfo_Callback.aspx', 1, 'SaleShop_ShopInfo-Result', 'SaleShop_ShopInfo-Search', 'SaleShop_ShopInfo-Search', 'SaleShop_ShopInfo_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function SaleShop_ShopInfo_Delete(){
			ConfirmAndDelSel('SaleShop_ShopInfo_Callback.aspx', 4, 'SaleShop_ShopInfo_', 'keys', 'SaleShop_ShopInfo-Result', 'SaleShop_ShopInfo-Result', 'SaleShop_ShopInfo-Result', '', '', 'json', "SaleShop_ShopInfo_Search();");
		}
		function SaleShop_ShopInfo_Edit(id) {
			window.location = 'SaleShop_ShopInfo_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
