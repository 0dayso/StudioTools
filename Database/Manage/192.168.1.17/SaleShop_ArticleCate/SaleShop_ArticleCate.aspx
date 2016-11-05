<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_ArticleCate.aspx.cs" Inherits="Database_Output_SaleShop_ArticleCate" %>
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
    <div id="SaleShop_ArticleCate-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>SaleShop_ArticleCate Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>Id:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_Id" name="SaleShop_ArticleCate_Id" /></li>
<li>Level:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_Level" name="SaleShop_ArticleCate_Level" /></li>
<li>ParentId:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_ParentId" name="SaleShop_ArticleCate_ParentId" /></li>
<li>Name:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_Name" name="SaleShop_ArticleCate_Name" /></li>
<li>CateType:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_CateType" name="SaleShop_ArticleCate_CateType" /></li>
<li>ShopId:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_ShopId" name="SaleShop_ArticleCate_ShopId" /></li>
<li>UrlAlias:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_UrlAlias" name="SaleShop_ArticleCate_UrlAlias" /></li>
<li>AddTime:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_AddTime" name="SaleShop_ArticleCate_AddTime" /></li>
<li>Adder:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_Adder" name="SaleShop_ArticleCate_Adder" /></li>
<li>SeoKeywords:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_SeoKeywords" name="SaleShop_ArticleCate_SeoKeywords" /></li>
<li>SeoDescription:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_SeoDescription" name="SaleShop_ArticleCate_SeoDescription" /></li>
<li>IsSys:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_IsSys" name="SaleShop_ArticleCate_IsSys" /></li>
<li>OrderNum:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_OrderNum" name="SaleShop_ArticleCate_OrderNum" /></li>
<li>Editor:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_Editor" name="SaleShop_ArticleCate_Editor" /></li>
<li>EditTime:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_EditTime" name="SaleShop_ArticleCate_EditTime" /></li>
<li>Disable:</li><li><input type="text" class="txt" id="SaleShop_ArticleCate_Disable" name="SaleShop_ArticleCate_Disable" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="SaleShop_ArticleCate_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='SaleShop_ArticleCate_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="SaleShop_ArticleCate-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            SaleShop_ArticleCate_Search();
        });
		SerUrl=null;//Pending
        function SaleShop_ArticleCate_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('SaleShop_ArticleCate_Callback.aspx', 1, 'SaleShop_ArticleCate-Result', 'SaleShop_ArticleCate-Search', 'SaleShop_ArticleCate-Search', 'SaleShop_ArticleCate_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function SaleShop_ArticleCate_Delete(){
			ConfirmAndDelSel('SaleShop_ArticleCate_Callback.aspx', 4, 'SaleShop_ArticleCate_', 'keys', 'SaleShop_ArticleCate-Result', 'SaleShop_ArticleCate-Result', 'SaleShop_ArticleCate-Result', '', '', 'json', "SaleShop_ArticleCate_Search();");
		}
		function SaleShop_ArticleCate_Edit(id) {
			window.location = 'SaleShop_ArticleCate_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
