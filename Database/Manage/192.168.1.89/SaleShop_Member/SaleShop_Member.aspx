<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_Member.aspx.cs" Inherits="Database_Output_SaleShop_Member" %>
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
    <div id="SaleShop_Member-Search" class="manage-search" style="margin-top:5px;">
		<div class="header" style="padding-left:5px;"><strong>SaleShop_Member Management</strong></div>
		<div class="line"></div>
		<div style="margin-top:5px;padding:5px;"><ul>
<li>UId:</li><li><input type="text" class="txt" id="SaleShop_Member_UId" name="SaleShop_Member_UId" /></li>
<li>UserName:</li><li><input type="text" class="txt" id="SaleShop_Member_UserName" name="SaleShop_Member_UserName" /></li>
<li>RealName:</li><li><input type="text" class="txt" id="SaleShop_Member_RealName" name="SaleShop_Member_RealName" /></li>
<li>ICON:</li><li><input type="text" class="txt" id="SaleShop_Member_ICON" name="SaleShop_Member_ICON" /></li>
<li>Password:</li><li><input type="text" class="txt" id="SaleShop_Member_Password" name="SaleShop_Member_Password" /></li>
<li>Gender:</li><li><input type="text" class="txt" id="SaleShop_Member_Gender" name="SaleShop_Member_Gender" /></li>
<li>GroupId:</li><li><input type="text" class="txt" id="SaleShop_Member_GroupId" name="SaleShop_Member_GroupId" /></li>
<li>Email:</li><li><input type="text" class="txt" id="SaleShop_Member_Email" name="SaleShop_Member_Email" /></li>
<li>Mobile:</li><li><input type="text" class="txt" id="SaleShop_Member_Mobile" name="SaleShop_Member_Mobile" /></li>
<li>District:</li><li><input type="text" class="txt" id="SaleShop_Member_District" name="SaleShop_Member_District" /></li>
<li>OtherContact:</li><li><input type="text" class="txt" id="SaleShop_Member_OtherContact" name="SaleShop_Member_OtherContact" /></li>
<li>Funds:</li><li><input type="text" class="txt" id="SaleShop_Member_Funds" name="SaleShop_Member_Funds" /></li>
<li>frostFunds:</li><li><input type="text" class="txt" id="SaleShop_Member_frostFunds" name="SaleShop_Member_frostFunds" /></li>
<li>Integral:</li><li><input type="text" class="txt" id="SaleShop_Member_Integral" name="SaleShop_Member_Integral" /></li>
<li>Referee:</li><li><input type="text" class="txt" id="SaleShop_Member_Referee" name="SaleShop_Member_Referee" /></li>
<li>LastIP:</li><li><input type="text" class="txt" id="SaleShop_Member_LastIP" name="SaleShop_Member_LastIP" /></li>
<li>PrevIP:</li><li><input type="text" class="txt" id="SaleShop_Member_PrevIP" name="SaleShop_Member_PrevIP" /></li>
<li>RegIP:</li><li><input type="text" class="txt" id="SaleShop_Member_RegIP" name="SaleShop_Member_RegIP" /></li>
<li>LastLoginTime:</li><li><input type="text" class="txt" id="SaleShop_Member_LastLoginTime" name="SaleShop_Member_LastLoginTime" /></li>
<li>logingtime:</li><li><input type="text" class="txt" id="SaleShop_Member_logingtime" name="SaleShop_Member_logingtime" /></li>
<li>State:</li><li><input type="text" class="txt" id="SaleShop_Member_State" name="SaleShop_Member_State" /></li>
<li>RegTime:</li><li><input type="text" class="txt" id="SaleShop_Member_RegTime" name="SaleShop_Member_RegTime" /></li>
<li>AddTime:</li><li><input type="text" class="txt" id="SaleShop_Member_AddTime" name="SaleShop_Member_AddTime" /></li>
<li>IsReceiveSms:</li><li><input type="text" class="txt" id="SaleShop_Member_IsReceiveSms" name="SaleShop_Member_IsReceiveSms" /></li>
<li>Friends:</li><li><input type="text" class="txt" id="SaleShop_Member_Friends" name="SaleShop_Member_Friends" /></li>
<li>loginappid:</li><li><input type="text" class="txt" id="SaleShop_Member_loginappid" name="SaleShop_Member_loginappid" /></li>
<li>forgotpwdtime:</li><li><input type="text" class="txt" id="SaleShop_Member_forgotpwdtime" name="SaleShop_Member_forgotpwdtime" /></li>
<li>idcard:</li><li><input type="text" class="txt" id="SaleShop_Member_idcard" name="SaleShop_Member_idcard" /></li>
<li>birthtime:</li><li><input type="text" class="txt" id="SaleShop_Member_birthtime" name="SaleShop_Member_birthtime" /></li>
<li>linkaddress:</li><li><input type="text" class="txt" id="SaleShop_Member_linkaddress" name="SaleShop_Member_linkaddress" /></li>
<li>industry:</li><li><input type="text" class="txt" id="SaleShop_Member_industry" name="SaleShop_Member_industry" /></li>
<li>mshopid:</li><li><input type="text" class="txt" id="SaleShop_Member_mshopid" name="SaleShop_Member_mshopid" /></li>
<li>headuid:</li><li><input type="text" class="txt" id="SaleShop_Member_headuid" name="SaleShop_Member_headuid" /></li>
<li>areaid1:</li><li><input type="text" class="txt" id="SaleShop_Member_areaid1" name="SaleShop_Member_areaid1" /></li>
<li>areaid2:</li><li><input type="text" class="txt" id="SaleShop_Member_areaid2" name="SaleShop_Member_areaid2" /></li>
<li>areaid3:</li><li><input type="text" class="txt" id="SaleShop_Member_areaid3" name="SaleShop_Member_areaid3" /></li>
<li>paypwd:</li><li><input type="text" class="txt" id="SaleShop_Member_paypwd" name="SaleShop_Member_paypwd" /></li>
<li>icon_old:</li><li><input type="text" class="txt" id="SaleShop_Member_icon_old" name="SaleShop_Member_icon_old" /></li>
<li>experience:</li><li><input type="text" class="txt" id="SaleShop_Member_experience" name="SaleShop_Member_experience" /></li>
<li>IsPerfectInfo:</li><li><input type="text" class="txt" id="SaleShop_Member_IsPerfectInfo" name="SaleShop_Member_IsPerfectInfo" /></li>
<li>emailApprove:</li><li><input type="text" class="txt" id="SaleShop_Member_emailApprove" name="SaleShop_Member_emailApprove" /></li>
<li>phoneApprove:</li><li><input type="text" class="txt" id="SaleShop_Member_phoneApprove" name="SaleShop_Member_phoneApprove" /></li>
<li>isSetSafeQuestion:</li><li><input type="text" class="txt" id="SaleShop_Member_isSetSafeQuestion" name="SaleShop_Member_isSetSafeQuestion" /></li>
<li>question:</li><li><input type="text" class="txt" id="SaleShop_Member_question" name="SaleShop_Member_question" /></li>
<li>answer:</li><li><input type="text" class="txt" id="SaleShop_Member_answer" name="SaleShop_Member_answer" /></li>
<li>isIdApprove:</li><li><input type="text" class="txt" id="SaleShop_Member_isIdApprove" name="SaleShop_Member_isIdApprove" /></li>
<li>bankNum:</li><li><input type="text" class="txt" id="SaleShop_Member_bankNum" name="SaleShop_Member_bankNum" /></li>
<li>isBingBank:</li><li><input type="text" class="txt" id="SaleShop_Member_isBingBank" name="SaleShop_Member_isBingBank" /></li>
<li>honourId:</li><li><input type="text" class="txt" id="SaleShop_Member_honourId" name="SaleShop_Member_honourId" /></li>
<li>gradeId:</li><li><input type="text" class="txt" id="SaleShop_Member_gradeId" name="SaleShop_Member_gradeId" /></li>
<li>weixin_openid:</li><li><input type="text" class="txt" id="SaleShop_Member_weixin_openid" name="SaleShop_Member_weixin_openid" /></li>
<li>qq_openid:</li><li><input type="text" class="txt" id="SaleShop_Member_qq_openid" name="SaleShop_Member_qq_openid" /></li>
</ul>
</div>
        <div style="text-align:right;padding:10px;">
		<input class="btn" type="button" onclick="SaleShop_Member_Search();" value="Search" />
		&nbsp;<input type="button" onclick="window.location='SaleShop_Member_Edit.aspx';" class="btn" value="Add" />
		</div>
    </div>
    <div class="" id="SaleShop_Member-Result" style="margin-top:5px;"></div>
	<script type="text/javascript">var SerUrl="<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    SerUrlValueStyle = SerUrl+'themes/skin-1/';
    SetupInit();
        $().ready(function () {
            SaleShop_Member_Search();
        });
		SerUrl=null;//Pending
        function SaleShop_Member_Search(pageIndex, pageSize, sortBy, isAsc) {
            CommonSearch('SaleShop_Member_Callback.aspx', 1, 'SaleShop_Member-Result', 'SaleShop_Member-Search', 'SaleShop_Member-Search', 'SaleShop_Member_', '', pageIndex, pageSize, sortBy, isAsc);
        }
		function SaleShop_Member_Delete(){
			ConfirmAndDelSel('SaleShop_Member_Callback.aspx', 4, 'SaleShop_Member_', 'keys', 'SaleShop_Member-Result', 'SaleShop_Member-Result', 'SaleShop_Member-Result', '', '', 'json', "SaleShop_Member_Search();");
		}
		function SaleShop_Member_Edit(id) {
			window.location = 'SaleShop_Member_Edit.aspx?id=' + id;
		}
    </script>
</body>
</html>
