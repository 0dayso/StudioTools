<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_ShopInfo_Edit.aspx.cs"
    Inherits="Database_Output_SaleShop_ShopInfo_Edit" ValidateRequest="false" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
	<link href="<%=ResolveClientUrl("~") %>/themes/skin-1/ws.css" rel="stylesheet" type="text/css" />
	<style rel="stylesheet" type="text/css">
	body
	{
		margin:0px 5px;
	}
	.edit-panel
	{
		border:solid 1px #DCDFE1;
		background-color: #EAF6F6;
	}
	.edit-content
	{
		border:solid 1px #DCDFE1;
		border-top-width:0px;
		padding:5px;
		background-color: #F2F2F2;
		margin-bottom:5px;
	}
	.edit-content td
	{
		vertical-align:top;
		white-space:nowrap;
	}
	</style>
</head>
<body style="background-image: none;margin-top:5px;">
    <form id="Form-SaleShop_ShopInfo" action="SaleShop_ShopInfo_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="SaleShop_ShopInfo-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="SaleShop_ShopInfo_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">CorpId</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_CorpId" value="<%=UO.CorpId%>" style="width:100%;" name="SaleShop_ShopInfo_CorpId" /></td>
</tr>
<tr>
<td style="width:5%;">StId</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_StId" value="<%=UO.StId%>" style="width:100%;" name="SaleShop_ShopInfo_StId" /></td>
</tr>
<tr>
<td style="width:5%;">ShopType</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ShopType" value="<%=UO.ShopType%>" style="width:100%;" name="SaleShop_ShopInfo_ShopType" /></td>
</tr>
<tr>
<td style="width:5%;">ShopBelong</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ShopBelong" value="<%=UO.ShopBelong%>" style="width:100%;" name="SaleShop_ShopInfo_ShopBelong" /></td>
</tr>
<tr>
<td style="width:5%;">ScId</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ScId" value="<%=UO.ScId%>" style="width:100%;" name="SaleShop_ShopInfo_ScId" /></td>
</tr>
<tr>
<td style="width:5%;">ScIdSon</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ScIdSon" value="<%=UO.ScIdSon%>" style="width:100%;" name="SaleShop_ShopInfo_ScIdSon" /></td>
</tr>
<tr>
<td style="width:5%;">ShopName</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ShopName" value="<%=UO.ShopName%>" style="width:100%;" name="SaleShop_ShopInfo_ShopName" /></td>
</tr>
<tr>
<td style="width:5%;">ShopSubName</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ShopSubName" value="<%=UO.ShopSubName%>" style="width:100%;" name="SaleShop_ShopInfo_ShopSubName" /></td>
</tr>
<tr>
<td style="width:5%;">WebTitle</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_WebTitle" value="<%=UO.WebTitle%>" style="width:100%;" name="SaleShop_ShopInfo_WebTitle" /></td>
</tr>
<tr>
<td style="width:5%;">ProvinceId</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ProvinceId" value="<%=UO.ProvinceId%>" style="width:100%;" name="SaleShop_ShopInfo_ProvinceId" /></td>
</tr>
<tr>
<td style="width:5%;">CityId</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_CityId" value="<%=UO.CityId%>" style="width:100%;" name="SaleShop_ShopInfo_CityId" /></td>
</tr>
<tr>
<td style="width:5%;">AreaId</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_AreaId" value="<%=UO.AreaId%>" style="width:100%;" name="SaleShop_ShopInfo_AreaId" /></td>
</tr>
<tr>
<td style="width:5%;">ShopGrade</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ShopGrade" value="<%=UO.ShopGrade%>" style="width:100%;" name="SaleShop_ShopInfo_ShopGrade" /></td>
</tr>
<tr>
<td style="width:5%;">ShopImg</td>
<td><textarea class="textarea" id="SaleShop_ShopInfo"_ShopImg" row="20" style="width:100%;height:80px;" name="SaleShop_ShopInfo_ShopImg" /><%=UO.ShopImg%></textarea></td>
</tr>
<tr>
<td style="width:5%;">Landmark</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_Landmark" value="<%=UO.Landmark%>" style="width:100%;" name="SaleShop_ShopInfo_Landmark" /></td>
</tr>
<tr>
<td style="width:5%;">Address</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_Address" value="<%=UO.Address%>" style="width:100%;" name="SaleShop_ShopInfo_Address" /></td>
</tr>
<tr>
<td style="width:5%;">SvrTel</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_SvrTel" value="<%=UO.SvrTel%>" style="width:100%;" name="SaleShop_ShopInfo_SvrTel" /></td>
</tr>
<tr>
<td style="width:5%;">SvrQQ</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_SvrQQ" value="<%=UO.SvrQQ%>" style="width:100%;" name="SaleShop_ShopInfo_SvrQQ" /></td>
</tr>
<tr>
<td style="width:5%;">SvrWorking</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_SvrWorking" value="<%=UO.SvrWorking%>" style="width:100%;" name="SaleShop_ShopInfo_SvrWorking" /></td>
</tr>
<tr>
<td style="width:5%;">DiscountInfo</td>
<td><textarea class="textarea" id="SaleShop_ShopInfo"_DiscountInfo" content-type="1" row="20" style="width:100%;height:80px;" name="SaleShop_ShopInfo_DiscountInfo" /><%=UO.DiscountInfo%></textarea></td>
</tr>
<tr>
<td style="width:5%;">DiscountStartTime</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_DiscountStartTime" value="<%=UO.DiscountStartTime%>" style="width:100%;" name="SaleShop_ShopInfo_DiscountStartTime" /></td>
</tr>
<tr>
<td style="width:5%;">DiscountEndTime</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_DiscountEndTime" value="<%=UO.DiscountEndTime%>" style="width:100%;" name="SaleShop_ShopInfo_DiscountEndTime" /></td>
</tr>
<tr>
<td style="width:5%;">MapAddress</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_MapAddress" value="<%=UO.MapAddress%>" style="width:100%;" name="SaleShop_ShopInfo_MapAddress" /></td>
</tr>
<tr>
<td style="width:5%;">Longitude</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_Longitude" value="<%=UO.Longitude%>" style="width:100%;" name="SaleShop_ShopInfo_Longitude" /></td>
</tr>
<tr>
<td style="width:5%;">Latitude</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_Latitude" value="<%=UO.Latitude%>" style="width:100%;" name="SaleShop_ShopInfo_Latitude" /></td>
</tr>
<tr>
<td style="width:5%;">IsMain</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_IsMain" value="<%=UO.IsMain%>" style="width:100%;" name="SaleShop_ShopInfo_IsMain" /></td>
</tr>
<tr>
<td style="width:5%;">ShopInstroduction</td>
<td><textarea class="textarea" id="SaleShop_ShopInfo"_ShopInstroduction" content-type="1" row="20" style="width:100%;height:80px;" name="SaleShop_ShopInfo_ShopInstroduction" /><%=UO.ShopInstroduction%></textarea></td>
</tr>
<tr>
<td style="width:5%;">ShoppingGuide</td>
<td><textarea class="textarea" id="SaleShop_ShopInfo"_ShoppingGuide" content-type="1" row="20" style="width:100%;height:80px;" name="SaleShop_ShopInfo_ShoppingGuide" /><%=UO.ShoppingGuide%></textarea></td>
</tr>
<tr>
<td style="width:5%;">SvrCusServices</td>
<td><textarea class="textarea" id="SaleShop_ShopInfo"_SvrCusServices" content-type="1" row="20" style="width:100%;height:80px;" name="SaleShop_ShopInfo_SvrCusServices" /><%=UO.SvrCusServices%></textarea></td>
</tr>
<tr>
<td style="width:5%;">TradeRate</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_TradeRate" value="<%=UO.TradeRate%>" style="width:100%;" name="SaleShop_ShopInfo_TradeRate" /></td>
</tr>
<tr>
<td style="width:5%;">IsMsgSend</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_IsMsgSend" value="<%=UO.IsMsgSend%>" style="width:100%;" name="SaleShop_ShopInfo_IsMsgSend" /></td>
</tr>
<tr>
<td style="width:5%;">Domain</td>
<td><textarea class="textarea" id="SaleShop_ShopInfo"_Domain" row="20" style="width:100%;height:80px;" name="SaleShop_ShopInfo_Domain" /><%=UO.Domain%></textarea></td>
</tr>
<tr>
<td style="width:5%;">LogoType</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_LogoType" value="<%=UO.LogoType%>" style="width:100%;" name="SaleShop_ShopInfo_LogoType" /></td>
</tr>
<tr>
<td style="width:5%;">LogoText</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_LogoText" value="<%=UO.LogoText%>" style="width:100%;" name="SaleShop_ShopInfo_LogoText" /></td>
</tr>
<tr>
<td style="width:5%;">LogoImg</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_LogoImg" value="<%=UO.LogoImg%>" style="width:100%;" name="SaleShop_ShopInfo_LogoImg" /></td>
</tr>
<tr>
<td style="width:5%;">StartLevel</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_StartLevel" value="<%=UO.StartLevel%>" style="width:100%;" name="SaleShop_ShopInfo_StartLevel" /></td>
</tr>
<tr>
<td style="width:5%;">Population</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_Population" value="<%=UO.Population%>" style="width:100%;" name="SaleShop_ShopInfo_Population" /></td>
</tr>
<tr>
<td style="width:5%;">HitCount</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_HitCount" value="<%=UO.HitCount%>" style="width:100%;" name="SaleShop_ShopInfo_HitCount" /></td>
</tr>
<tr>
<td style="width:5%;">Deposit</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_Deposit" value="<%=UO.Deposit%>" style="width:100%;" name="SaleShop_ShopInfo_Deposit" /></td>
</tr>
<tr>
<td style="width:5%;">MetaKeyword</td>
<td><textarea class="textarea" id="SaleShop_ShopInfo"_MetaKeyword" row="20" style="width:100%;height:80px;" name="SaleShop_ShopInfo_MetaKeyword" /><%=UO.MetaKeyword%></textarea></td>
</tr>
<tr>
<td style="width:5%;">MetaDescrition</td>
<td><textarea class="textarea" id="SaleShop_ShopInfo"_MetaDescrition" row="20" style="width:100%;height:80px;" name="SaleShop_ShopInfo_MetaDescrition" /><%=UO.MetaDescrition%></textarea></td>
</tr>
<tr>
<td style="width:5%;">ShopICP</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ShopICP" value="<%=UO.ShopICP%>" style="width:100%;" name="SaleShop_ShopInfo_ShopICP" /></td>
</tr>
<tr>
<td style="width:5%;">WeixinToken</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinToken" value="<%=UO.WeixinToken%>" style="width:100%;" name="SaleShop_ShopInfo_WeixinToken" /></td>
</tr>
<tr>
<td style="width:5%;">WeixinAppid</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinAppid" value="<%=UO.WeixinAppid%>" style="width:100%;" name="SaleShop_ShopInfo_WeixinAppid" /></td>
</tr>
<tr>
<td style="width:5%;">WeixinAppSecret</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinAppSecret" value="<%=UO.WeixinAppSecret%>" style="width:100%;" name="SaleShop_ShopInfo_WeixinAppSecret" /></td>
</tr>
<tr>
<td style="width:5%;">WeixinPublicAcount</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinPublicAcount" value="<%=UO.WeixinPublicAcount%>" style="width:100%;" name="SaleShop_ShopInfo_WeixinPublicAcount" /></td>
</tr>
<tr>
<td style="width:5%;">WeixinQrCode</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinQrCode" value="<%=UO.WeixinQrCode%>" style="width:100%;" name="SaleShop_ShopInfo_WeixinQrCode" /></td>
</tr>
<tr>
<td style="width:5%;">WeixinImg</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_WeixinImg" value="<%=UO.WeixinImg%>" style="width:100%;" name="SaleShop_ShopInfo_WeixinImg" /></td>
</tr>
<tr>
<td style="width:5%;">BankType</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_BankType" value="<%=UO.BankType%>" style="width:100%;" name="SaleShop_ShopInfo_BankType" /></td>
</tr>
<tr>
<td style="width:5%;">BankOwer</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_BankOwer" value="<%=UO.BankOwer%>" style="width:100%;" name="SaleShop_ShopInfo_BankOwer" /></td>
</tr>
<tr>
<td style="width:5%;">BankName</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_BankName" value="<%=UO.BankName%>" style="width:100%;" name="SaleShop_ShopInfo_BankName" /></td>
</tr>
<tr>
<td style="width:5%;">BankAccount</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_BankAccount" value="<%=UO.BankAccount%>" style="width:100%;" name="SaleShop_ShopInfo_BankAccount" /></td>
</tr>
<tr>
<td style="width:5%;">MgrName</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_MgrName" value="<%=UO.MgrName%>" style="width:100%;" name="SaleShop_ShopInfo_MgrName" /></td>
</tr>
<tr>
<td style="width:5%;">MgrEmail</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_MgrEmail" value="<%=UO.MgrEmail%>" style="width:100%;" name="SaleShop_ShopInfo_MgrEmail" /></td>
</tr>
<tr>
<td style="width:5%;">MgrQQ</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_MgrQQ" value="<%=UO.MgrQQ%>" style="width:100%;" name="SaleShop_ShopInfo_MgrQQ" /></td>
</tr>
<tr>
<td style="width:5%;">MgrTel</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_MgrTel" value="<%=UO.MgrTel%>" style="width:100%;" name="SaleShop_ShopInfo_MgrTel" /></td>
</tr>
<tr>
<td style="width:5%;">AttachLicense</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_AttachLicense" value="<%=UO.AttachLicense%>" style="width:100%;" name="SaleShop_ShopInfo_AttachLicense" /></td>
</tr>
<tr>
<td style="width:5%;">AttachJoin</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_AttachJoin" value="<%=UO.AttachJoin%>" style="width:100%;" name="SaleShop_ShopInfo_AttachJoin" /></td>
</tr>
<tr>
<td style="width:5%;">AttachMgrIDCard</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_AttachMgrIDCard" value="<%=UO.AttachMgrIDCard%>" style="width:100%;" name="SaleShop_ShopInfo_AttachMgrIDCard" /></td>
</tr>
<tr>
<td style="width:5%;">ApplyId</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_ApplyId" value="<%=UO.ApplyId%>" style="width:100%;" name="SaleShop_ShopInfo_ApplyId" /></td>
</tr>
<tr>
<td style="width:5%;">OrderNum</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_OrderNum" value="<%=UO.OrderNum%>" style="width:100%;" name="SaleShop_ShopInfo_OrderNum" /></td>
</tr>
<tr>
<td style="width:5%;">Disable</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_Disable" value="<%=UO.Disable%>" style="width:100%;" name="SaleShop_ShopInfo_Disable" /></td>
</tr>
<tr>
<td style="width:5%;">CreateTime</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_CreateTime" value="<%=UO.CreateTime%>" style="width:100%;" name="SaleShop_ShopInfo_CreateTime" /></td>
</tr>
<tr>
<td style="width:5%;">Editor</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_Editor" value="<%=UO.Editor%>" style="width:100%;" name="SaleShop_ShopInfo_Editor" /></td>
</tr>
<tr>
<td style="width:5%;">EditTime</td>
<td><input type="text" class="txt" id="SaleShop_ShopInfo_EditTime" value="<%=UO.EditTime%>" style="width:100%;" name="SaleShop_ShopInfo_EditTime" /></td>
</tr>
</table>

			</div>
        </div>
    </form>
	<script type="text/javascript" src="<%=ResolveUrl("~") %>fck/fckeditor.js"></script>
    <script type="text/javascript">var SerUrl = "<%=ResolveUrl("~") %>";var LangType='en-us';</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        SerUrlValueStyle = SerUrl + 'themes/skin-1/';
        SetupInit();
        $().ready(function () {
			$('textarea[content-type="1"]').each(function(){
				FCKReg(this.id, { PageType: 'SaleShop_ShopInfo', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function SaleShop_ShopInfo_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('SaleShop_ShopInfo-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-SaleShop_ShopInfo')[0].submit(); return; }
        }
    </script>
</body>
</html>
