<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirfareLastView.aspx.cs" Inherits="Database_Output_AirfareLastView" %>
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
    <div id="AirfareLastView-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>AirfareLastView Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>Id:</li><li><input type="text" class="txt" id="AirfareLastView_Id" name="AirfareLastView_Id" /></li>
<li>CompanyCode:</li><li><input type="text" class="txt" id="AirfareLastView_CompanyCode" name="AirfareLastView_CompanyCode" /></li>
<li>UserCode:</li><li><input type="text" class="txt" id="AirfareLastView_UserCode" name="AirfareLastView_UserCode" /></li>
<li>Org:</li><li><input type="text" class="txt" id="AirfareLastView_Org" name="AirfareLastView_Org" /></li>
<li>Dst:</li><li><input type="text" class="txt" id="AirfareLastView_Dst" name="AirfareLastView_Dst" /></li>
<li>OWRTOJ:</li><li><input type="text" class="txt" id="AirfareLastView_OWRTOJ" name="AirfareLastView_OWRTOJ" /></li>
<li>LastViewDate:</li><li><input type="text" class="txt" id="AirfareLastView_LastViewDate" name="AirfareLastView_LastViewDate" /></li>
<li>IsDirect:</li><li><input type="text" class="txt" id="AirfareLastView_IsDirect" name="AirfareLastView_IsDirect" /></li>
<li>DepartureDate:</li><li><input type="text" class="txt" id="AirfareLastView_DepartureDate" name="AirfareLastView_DepartureDate" /></li>
<li>ReturnDate:</li><li><input type="text" class="txt" id="AirfareLastView_ReturnDate" name="AirfareLastView_ReturnDate" /></li>
<li>Airline:</li><li><input type="text" class="txt" id="AirfareLastView_Airline" name="AirfareLastView_Airline" /></li>
<li>FareCat:</li><li><input type="text" class="txt" id="AirfareLastView_FareCat" name="AirfareLastView_FareCat" /></li>
<li>BkgClass:</li><li><input type="text" class="txt" id="AirfareLastView_BkgClass" name="AirfareLastView_BkgClass" /></li>
<li>FareClass:</li><li><input type="text" class="txt" id="AirfareLastView_FareClass" name="AirfareLastView_FareClass" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="AirfareLastView_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='AirfareLastView_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="AirfareLastView-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            AirfareLastView_Search();
        });
		SerUrl=null;//Pending
        function AirfareLastView_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('AirfareLastView_Callback.aspx', 1, 'AirfareLastView-Result', 'AirfareLastView-Search', 'AirfareLastView-Search', 'AirfareLastView_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function AirfareLastView_Delete(){
			ConfirmAndDelSel('AirfareLastView_Callback.aspx', 4, 'AirfareLastView_', 'keys', 'AirfareLastView-Result', 'AirfareLastView-Result', 'AirfareLastView-Result', '', '', 'json', "AirfareLastView_Search();");
		}
		function AirfareLastView_Edit(id) {
			window.location = 'AirfareLastView_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
