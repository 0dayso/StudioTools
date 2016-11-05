<%@ page language="C#" autoeventwireup="true" inherits="Database_Output_Goods_lable, App_Web_goods_lable.aspx.eeccb890" %>
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
    <div id="Goods_lable-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>Goods_lable Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>lableid:</li><li><input type="text" class="txt" id="Goods_lable_lableid" name="Goods_lable_lableid" /></li>
<li>merchantid:</li><li><input type="text" class="txt" id="Goods_lable_merchantid" name="Goods_lable_merchantid" /></li>
<li>lablename:</li><li><input type="text" class="txt" id="Goods_lable_lablename" name="Goods_lable_lablename" /></li>
<li>lablecolor:</li><li><input type="text" class="txt" id="Goods_lable_lablecolor" name="Goods_lable_lablecolor" /></li>
<li>addTime:</li><li><input type="text" class="txt" id="Goods_lable_addTime" name="Goods_lable_addTime" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="Goods_lable_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='Goods_lable_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="Goods_lable-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            Goods_lable_Search();
        });
		SerUrl=null;//Pending
        function Goods_lable_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('Goods_lable_Callback.aspx', 1, 'Goods_lable-Result', 'Goods_lable-Search', 'Goods_lable-Search', 'Goods_lable_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function Goods_lable_Delete(){
			ConfirmAndDelSel('Goods_lable_Callback.aspx', 4, 'Goods_lable_', 'keys', 'Goods_lable-Result', 'Goods_lable-Result', 'Goods_lable-Result', '', '', 'json', "Goods_lable_Search();");
		}
		function Goods_lable_Edit(id) {
			window.location = 'Goods_lable_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
