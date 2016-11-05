<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorDescrption.aspx.cs" Inherits="Database_Output_ErrorDescrption" %>
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
    <div id="ErrorDescrption-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>ErrorDescrption Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>Code:</li><li><input type="text" class="txt" id="ErrorDescrption_Code" name="ErrorDescrption_Code" /></li>
<li>Description:</li><li><input type="text" class="txt" id="ErrorDescrption_Description" name="ErrorDescrption_Description" /></li>
<li>DescriptionKeywords:</li><li><input type="text" class="txt" id="ErrorDescrption_DescriptionKeywords" name="ErrorDescrption_DescriptionKeywords" /></li>
<li>DescriptionType:</li><li><input type="text" class="txt" id="ErrorDescrption_DescriptionType" name="ErrorDescrption_DescriptionType" /></li>
<li>CreateOn:</li><li><input type="text" class="txt" id="ErrorDescrption_CreateOn" name="ErrorDescrption_CreateOn" /></li>
<li>CreateBy:</li><li><input type="text" class="txt" id="ErrorDescrption_CreateBy" name="ErrorDescrption_CreateBy" /></li>
<li>UpdateOn:</li><li><input type="text" class="txt" id="ErrorDescrption_UpdateOn" name="ErrorDescrption_UpdateOn" /></li>
<li>UpdateBy:</li><li><input type="text" class="txt" id="ErrorDescrption_UpdateBy" name="ErrorDescrption_UpdateBy" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="ErrorDescrption_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='ErrorDescrption_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="ErrorDescrption-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            ErrorDescrption_Search();
        });
		SerUrl=null;//Pending
        function ErrorDescrption_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('ErrorDescrption_Callback.aspx', 1, 'ErrorDescrption-Result', 'ErrorDescrption-Search', 'ErrorDescrption-Search', 'ErrorDescrption_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function ErrorDescrption_Delete(){
			ConfirmAndDelSel('ErrorDescrption_Callback.aspx', 4, 'ErrorDescrption_', 'keys', 'ErrorDescrption-Result', 'ErrorDescrption-Result', 'ErrorDescrption-Result', '', '', 'json', "ErrorDescrption_Search();");
		}
		function ErrorDescrption_Edit(id) {
			window.location = 'ErrorDescrption_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
