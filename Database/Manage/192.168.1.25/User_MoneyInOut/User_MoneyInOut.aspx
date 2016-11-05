<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_MoneyInOut.aspx.cs" Inherits="Database_Output_User_MoneyInOut" %>
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
    <div id="User_MoneyInOut-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>User_MoneyInOut Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>Id:</li><li><input type="text" class="txt" id="User_MoneyInOut_Id" name="User_MoneyInOut_Id" /></li>
<li>WasteBookId:</li><li><input type="text" class="txt" id="User_MoneyInOut_WasteBookId" name="User_MoneyInOut_WasteBookId" /></li>
<li>UId:</li><li><input type="text" class="txt" id="User_MoneyInOut_UId" name="User_MoneyInOut_UId" /></li>
<li>OrderId:</li><li><input type="text" class="txt" id="User_MoneyInOut_OrderId" name="User_MoneyInOut_OrderId" /></li>
<li>Flag:</li><li><input type="text" class="txt" id="User_MoneyInOut_Flag" name="User_MoneyInOut_Flag" /></li>
<li>Momey:</li><li><input type="text" class="txt" id="User_MoneyInOut_Momey" name="User_MoneyInOut_Momey" /></li>
<li>MoneyType:</li><li><input type="text" class="txt" id="User_MoneyInOut_MoneyType" name="User_MoneyInOut_MoneyType" /></li>
<li>Note:</li><li><input type="text" class="txt" id="User_MoneyInOut_Note" name="User_MoneyInOut_Note" /></li>
<li>Source:</li><li><input type="text" class="txt" id="User_MoneyInOut_Source" name="User_MoneyInOut_Source" /></li>
<li>PayCode:</li><li><input type="text" class="txt" id="User_MoneyInOut_PayCode" name="User_MoneyInOut_PayCode" /></li>
<li>PayBookId:</li><li><input type="text" class="txt" id="User_MoneyInOut_PayBookId" name="User_MoneyInOut_PayBookId" /></li>
<li>BeginTime:</li><li><input type="text" class="txt" id="User_MoneyInOut_BeginTime" name="User_MoneyInOut_BeginTime" /></li>
<li>EndTime:</li><li><input type="text" class="txt" id="User_MoneyInOut_EndTime" name="User_MoneyInOut_EndTime" /></li>
<li>State:</li><li><input type="text" class="txt" id="User_MoneyInOut_State" name="User_MoneyInOut_State" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="User_MoneyInOut_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='User_MoneyInOut_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="User_MoneyInOut-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            User_MoneyInOut_Search();
        });
		SerUrl=null;//Pending
        function User_MoneyInOut_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('User_MoneyInOut_Callback.aspx', 1, 'User_MoneyInOut-Result', 'User_MoneyInOut-Search', 'User_MoneyInOut-Search', 'User_MoneyInOut_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function User_MoneyInOut_Delete(){
			ConfirmAndDelSel('User_MoneyInOut_Callback.aspx', 4, 'User_MoneyInOut_', 'keys', 'User_MoneyInOut-Result', 'User_MoneyInOut-Result', 'User_MoneyInOut-Result', '', '', 'json', "User_MoneyInOut_Search();");
		}
		function User_MoneyInOut_Edit(id) {
			window.location = 'User_MoneyInOut_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
