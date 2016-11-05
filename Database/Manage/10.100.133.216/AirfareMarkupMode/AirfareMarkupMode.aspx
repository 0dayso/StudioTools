<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirfareMarkupMode.aspx.cs" Inherits="Database_Output_AirfareMarkupMode" %>
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
    <div id="AirfareMarkupMode-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>AirfareMarkupMode Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>ID:</li><li><input type="text" class="txt" id="AirfareMarkupMode_ID" name="AirfareMarkupMode_ID" /></li>
<li>DetailId:</li><li><input type="text" class="txt" id="AirfareMarkupMode_DetailId" name="AirfareMarkupMode_DetailId" /></li>
<li>Rank:</li><li><input type="text" class="txt" id="AirfareMarkupMode_Rank" name="AirfareMarkupMode_Rank" /></li>
<li>MarkupBy:</li><li><input type="text" class="txt" id="AirfareMarkupMode_MarkupBy" name="AirfareMarkupMode_MarkupBy" /></li>
<li>Amount:</li><li><input type="text" class="txt" id="AirfareMarkupMode_Amount" name="AirfareMarkupMode_Amount" /></li>
<li>Rate:</li><li><input type="text" class="txt" id="AirfareMarkupMode_Rate" name="AirfareMarkupMode_Rate" /></li>
<li>RoundUpBy:</li><li><input type="text" class="txt" id="AirfareMarkupMode_RoundUpBy" name="AirfareMarkupMode_RoundUpBy" /></li>
<li>IsRoundDown:</li><li><input type="text" class="txt" id="AirfareMarkupMode_IsRoundDown" name="AirfareMarkupMode_IsRoundDown" /></li>
<li>MarkupByValue:</li><li><input type="text" class="txt" id="AirfareMarkupMode_MarkupByValue" name="AirfareMarkupMode_MarkupByValue" /></li>
<li>Description:</li><li><input type="text" class="txt" id="AirfareMarkupMode_Description" name="AirfareMarkupMode_Description" /></li>
<li>AirfareMarkupModeType:</li><li><input type="text" class="txt" id="AirfareMarkupMode_AirfareMarkupModeType" name="AirfareMarkupMode_AirfareMarkupModeType" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="AirfareMarkupMode_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='AirfareMarkupMode_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="AirfareMarkupMode-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            AirfareMarkupMode_Search();
        });
		SerUrl=null;//Pending
        function AirfareMarkupMode_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('AirfareMarkupMode_Callback.aspx', 1, 'AirfareMarkupMode-Result', 'AirfareMarkupMode-Search', 'AirfareMarkupMode-Search', 'AirfareMarkupMode_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function AirfareMarkupMode_Delete(){
			ConfirmAndDelSel('AirfareMarkupMode_Callback.aspx', 4, 'AirfareMarkupMode_', 'keys', 'AirfareMarkupMode-Result', 'AirfareMarkupMode-Result', 'AirfareMarkupMode-Result', '', '', 'json', "AirfareMarkupMode_Search();");
		}
		function AirfareMarkupMode_Edit(id) {
			window.location = 'AirfareMarkupMode_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
