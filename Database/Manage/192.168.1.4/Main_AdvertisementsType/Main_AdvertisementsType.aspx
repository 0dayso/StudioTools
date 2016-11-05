<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main_AdvertisementsType.aspx.cs" Inherits="Database_Output_Main_AdvertisementsType" %>
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
    <div id="Main_AdvertisementsType-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>Main_AdvertisementsType Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>Id:</li><li><input type="text" class="txt" id="Main_AdvertisementsType_Id" name="Main_AdvertisementsType_Id" /></li>
<li>Name:</li><li><input type="text" class="txt" id="Main_AdvertisementsType_Name" name="Main_AdvertisementsType_Name" /></li>
<li>Price:</li><li><input type="text" class="txt" id="Main_AdvertisementsType_Price" name="Main_AdvertisementsType_Price" /></li>
<li>ImgUrl:</li><li><input type="text" class="txt" id="Main_AdvertisementsType_ImgUrl" name="Main_AdvertisementsType_ImgUrl" /></li>
<li>Adway:</li><li><input type="text" class="txt" id="Main_AdvertisementsType_Adway" name="Main_AdvertisementsType_Adway" /></li>
<li>DefaultHtmlCode:</li><li><input type="text" class="txt" id="Main_AdvertisementsType_DefaultHtmlCode" name="Main_AdvertisementsType_DefaultHtmlCode" /></li>
<li>DefaultParameter:</li><li><input type="text" class="txt" id="Main_AdvertisementsType_DefaultParameter" name="Main_AdvertisementsType_DefaultParameter" /></li>
<li>EditTime:</li><li><input type="text" class="txt" id="Main_AdvertisementsType_EditTime" name="Main_AdvertisementsType_EditTime" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="Main_AdvertisementsType_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='Main_AdvertisementsType_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="Main_AdvertisementsType-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            Main_AdvertisementsType_Search();
        });
		SerUrl=null;//Pending
        function Main_AdvertisementsType_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('Main_AdvertisementsType_Callback.aspx', 1, 'Main_AdvertisementsType-Result', 'Main_AdvertisementsType-Search', 'Main_AdvertisementsType-Search', 'Main_AdvertisementsType_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function Main_AdvertisementsType_Delete(){
			ConfirmAndDelSel('Main_AdvertisementsType_Callback.aspx', 4, 'Main_AdvertisementsType_', 'keys', 'Main_AdvertisementsType-Result', 'Main_AdvertisementsType-Result', 'Main_AdvertisementsType-Result', '', '', 'json', "Main_AdvertisementsType_Search();");
		}
		function Main_AdvertisementsType_Edit(id) {
			window.location = 'Main_AdvertisementsType_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
