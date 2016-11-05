<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Keywords.aspx.cs" Inherits="Database_Output_Keywords" %>
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
    <div id="Keywords-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>Keywords Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>Id:</li><li><input type="text" class="txt" id="Keywords_Id" name="Keywords_Id" /></li>
<li>Find:</li><li><input type="text" class="txt" id="Keywords_Find" name="Keywords_Find" /></li>
<li>Replacement:</li><li><input type="text" class="txt" id="Keywords_Replacement" name="Keywords_Replacement" /></li>
<li>Editor:</li><li><input type="text" class="txt" id="Keywords_Editor" name="Keywords_Editor" /></li>
<li>EditTime:</li><li><input type="text" class="txt" id="Keywords_EditTime" name="Keywords_EditTime" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="Keywords_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='Keywords_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="Keywords-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            Keywords_Search();
        });
		SerUrl=null;//Pending
        function Keywords_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('Keywords_Callback.aspx', 1, 'Keywords-Result', 'Keywords-Search', 'Keywords-Search', 'Keywords_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function Keywords_Delete(){
			ConfirmAndDelSel('Keywords_Callback.aspx', 4, 'Keywords_', 'keys', 'Keywords-Result', 'Keywords-Result', 'Keywords-Result', '', '', 'json', "Keywords_Search();");
		}
		function Keywords_Edit(id) {
			window.location = 'Keywords_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
