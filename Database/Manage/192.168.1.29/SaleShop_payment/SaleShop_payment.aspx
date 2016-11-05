<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_payment.aspx.cs" Inherits="Database_Output_SaleShop_payment" %>
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
    <div id="SaleShop_payment-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>SaleShop_payment Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>pay_id:</li><li><input type="text" class="txt" id="SaleShop_payment_pay_id" name="SaleShop_payment_pay_id" /></li>
<li>pay_name:</li><li><input type="text" class="txt" id="SaleShop_payment_pay_name" name="SaleShop_payment_pay_name" /></li>
<li>pay_code:</li><li><input type="text" class="txt" id="SaleShop_payment_pay_code" name="SaleShop_payment_pay_code" /></li>
<li>pay_fee:</li><li><input type="text" class="txt" id="SaleShop_payment_pay_fee" name="SaleShop_payment_pay_fee" /></li>
<li>pay_desc:</li><li><input type="text" class="txt" id="SaleShop_payment_pay_desc" name="SaleShop_payment_pay_desc" /></li>
<li>Orderdisplay:</li><li><input type="text" class="txt" id="SaleShop_payment_Orderdisplay" name="SaleShop_payment_Orderdisplay" /></li>
<li>Interface:</li><li><input type="text" class="txt" id="SaleShop_payment_Interface" name="SaleShop_payment_Interface" /></li>
<li>pay_config:</li><li><input type="text" class="txt" id="SaleShop_payment_pay_config" name="SaleShop_payment_pay_config" /></li>
<li>enabled:</li><li><input type="text" class="txt" id="SaleShop_payment_enabled" name="SaleShop_payment_enabled" /></li>
<li>is_cod:</li><li><input type="text" class="txt" id="SaleShop_payment_is_cod" name="SaleShop_payment_is_cod" /></li>
<li>is_online:</li><li><input type="text" class="txt" id="SaleShop_payment_is_online" name="SaleShop_payment_is_online" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="SaleShop_payment_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='SaleShop_payment_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="SaleShop_payment-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            SaleShop_payment_Search();
        });
		SerUrl=null;//Pending
        function SaleShop_payment_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('SaleShop_payment_Callback.aspx', 1, 'SaleShop_payment-Result', 'SaleShop_payment-Search', 'SaleShop_payment-Search', 'SaleShop_payment_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function SaleShop_payment_Delete(){
			ConfirmAndDelSel('SaleShop_payment_Callback.aspx', 4, 'SaleShop_payment_', 'keys', 'SaleShop_payment-Result', 'SaleShop_payment-Result', 'SaleShop_payment-Result', '', '', 'json', "SaleShop_payment_Search();");
		}
		function SaleShop_payment_Edit(id) {
			window.location = 'SaleShop_payment_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
