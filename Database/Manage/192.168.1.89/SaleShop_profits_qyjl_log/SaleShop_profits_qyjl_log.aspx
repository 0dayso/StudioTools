<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_profits_qyjl_log.aspx.cs" Inherits="Database_Output_SaleShop_profits_qyjl_log" %>
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
    <div id="SaleShop_profits_qyjl_log-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>SaleShop_profits_qyjl_log Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>id:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_id" name="SaleShop_profits_qyjl_log_id" /></li>
<li>uid:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_uid" name="SaleShop_profits_qyjl_log_uid" /></li>
<li>orderid:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_orderid" name="SaleShop_profits_qyjl_log_orderid" /></li>
<li>mshopid:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_mshopid" name="SaleShop_profits_qyjl_log_mshopid" /></li>
<li>original_price:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_original_price" name="SaleShop_profits_qyjl_log_original_price" /></li>
<li>managerRatio:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_managerRatio" name="SaleShop_profits_qyjl_log_managerRatio" /></li>
<li>profits_price:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_profits_price" name="SaleShop_profits_qyjl_log_profits_price" /></li>
<li>addtime:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_addtime" name="SaleShop_profits_qyjl_log_addtime" /></li>
<li>status:</li><li><input type="text" class="txt" id="SaleShop_profits_qyjl_log_status" name="SaleShop_profits_qyjl_log_status" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="SaleShop_profits_qyjl_log_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='SaleShop_profits_qyjl_log_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="SaleShop_profits_qyjl_log-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            SaleShop_profits_qyjl_log_Search();
        });
		SerUrl=null;//Pending
        function SaleShop_profits_qyjl_log_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('SaleShop_profits_qyjl_log_Callback.aspx', 1, 'SaleShop_profits_qyjl_log-Result', 'SaleShop_profits_qyjl_log-Search', 'SaleShop_profits_qyjl_log-Search', 'SaleShop_profits_qyjl_log_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function SaleShop_profits_qyjl_log_Delete(){
			ConfirmAndDelSel('SaleShop_profits_qyjl_log_Callback.aspx', 4, 'SaleShop_profits_qyjl_log_', 'keys', 'SaleShop_profits_qyjl_log-Result', 'SaleShop_profits_qyjl_log-Result', 'SaleShop_profits_qyjl_log-Result', '', '', 'json', "SaleShop_profits_qyjl_log_Search();");
		}
		function SaleShop_profits_qyjl_log_Edit(id) {
			window.location = 'SaleShop_profits_qyjl_log_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
