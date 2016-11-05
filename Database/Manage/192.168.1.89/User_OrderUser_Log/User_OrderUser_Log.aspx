<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_OrderUser_Log.aspx.cs" Inherits="Database_Output_User_OrderUser_Log" %>
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
    <div id="User_OrderUser_Log-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>User_OrderUser_Log Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>id:</li><li><input type="text" class="txt" id="User_OrderUser_Log_id" name="User_OrderUser_Log_id" /></li>
<li>ordersid:</li><li><input type="text" class="txt" id="User_OrderUser_Log_ordersid" name="User_OrderUser_Log_ordersid" /></li>
<li>remark:</li><li><input type="text" class="txt" id="User_OrderUser_Log_remark" name="User_OrderUser_Log_remark" /></li>
<li>receivename:</li><li><input type="text" class="txt" id="User_OrderUser_Log_receivename" name="User_OrderUser_Log_receivename" /></li>
<li>receivetel:</li><li><input type="text" class="txt" id="User_OrderUser_Log_receivetel" name="User_OrderUser_Log_receivetel" /></li>
<li>receivemobile:</li><li><input type="text" class="txt" id="User_OrderUser_Log_receivemobile" name="User_OrderUser_Log_receivemobile" /></li>
<li>receivepostcode:</li><li><input type="text" class="txt" id="User_OrderUser_Log_receivepostcode" name="User_OrderUser_Log_receivepostcode" /></li>
<li>receiveaddress:</li><li><input type="text" class="txt" id="User_OrderUser_Log_receiveaddress" name="User_OrderUser_Log_receiveaddress" /></li>
<li>adminname:</li><li><input type="text" class="txt" id="User_OrderUser_Log_adminname" name="User_OrderUser_Log_adminname" /></li>
<li>logtime:</li><li><input type="text" class="txt" id="User_OrderUser_Log_logtime" name="User_OrderUser_Log_logtime" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="User_OrderUser_Log_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='User_OrderUser_Log_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="User_OrderUser_Log-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            User_OrderUser_Log_Search();
        });
		SerUrl=null;//Pending
        function User_OrderUser_Log_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('User_OrderUser_Log_Callback.aspx', 1, 'User_OrderUser_Log-Result', 'User_OrderUser_Log-Search', 'User_OrderUser_Log-Search', 'User_OrderUser_Log_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function User_OrderUser_Log_Delete(){
			ConfirmAndDelSel('User_OrderUser_Log_Callback.aspx', 4, 'User_OrderUser_Log_', 'keys', 'User_OrderUser_Log-Result', 'User_OrderUser_Log-Result', 'User_OrderUser_Log-Result', '', '', 'json', "User_OrderUser_Log_Search();");
		}
		function User_OrderUser_Log_Edit(id) {
			window.location = 'User_OrderUser_Log_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
