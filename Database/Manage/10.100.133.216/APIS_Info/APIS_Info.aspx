<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APIS_Info.aspx.cs" Inherits="Database_Output_APIS_Info" %>
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
    <div id="APIS_Info-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>APIS_Info Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>Id:</li><li><input type="text" class="txt" id="APIS_Info_Id" name="APIS_Info_Id" /></li>
<li>Country:</li><li><input type="text" class="txt" id="APIS_Info_Country" name="APIS_Info_Country" /></li>
<li>Airlines:</li><li><input type="text" class="txt" id="APIS_Info_Airlines" name="APIS_Info_Airlines" /></li>
<li>IsRequired:</li><li><input type="text" class="txt" id="APIS_Info_IsRequired" name="APIS_Info_IsRequired" /></li>
<li>CreateOn:</li><li><input type="text" class="txt" id="APIS_Info_CreateOn" name="APIS_Info_CreateOn" /></li>
<li>CreateBy:</li><li><input type="text" class="txt" id="APIS_Info_CreateBy" name="APIS_Info_CreateBy" /></li>
<li>UpdateOn:</li><li><input type="text" class="txt" id="APIS_Info_UpdateOn" name="APIS_Info_UpdateOn" /></li>
<li>UpdateBy:</li><li><input type="text" class="txt" id="APIS_Info_UpdateBy" name="APIS_Info_UpdateBy" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="APIS_Info_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='APIS_Info_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="APIS_Info-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            APIS_Info_Search();
        });
		SerUrl=null;//Pending
        function APIS_Info_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('APIS_Info_Callback.aspx', 1, 'APIS_Info-Result', 'APIS_Info-Search', 'APIS_Info-Search', 'APIS_Info_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function APIS_Info_Delete(){
			ConfirmAndDelSel('APIS_Info_Callback.aspx', 4, 'APIS_Info_', 'keys', 'APIS_Info-Result', 'APIS_Info-Result', 'APIS_Info-Result', '', '', 'json', "APIS_Info_Search();");
		}
		function APIS_Info_Edit(id) {
			window.location = 'APIS_Info_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
