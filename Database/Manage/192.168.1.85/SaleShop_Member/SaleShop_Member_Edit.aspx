<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_Member_Edit.aspx.cs"
    Inherits="Database_Output_SaleShop_Member_Edit" ValidateRequest="false" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
	<link href="<%=ResolveClientUrl("~") %>/themes/skin-1/ws.css" rel="stylesheet" type="text/css" />
	<style rel="stylesheet" type="text/css">
	body
	{
		margin:0px 5px;
	}
	.edit-panel
	{
		border:solid 1px #DCDFE1;
		background-color: #EAF6F6;
	}
	.edit-content
	{
		border:solid 1px #DCDFE1;
		border-top-width:0px;
		padding:5px;
		background-color: #F2F2F2;
		margin-bottom:5px;
	}
	.edit-content td
	{
		vertical-align:top;
		white-space:nowrap;
	}
	</style>
</head>
<body style="background-image: none;margin-top:5px;">
    <form id="Form-SaleShop_Member" action="SaleShop_Member_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="SaleShop_Member-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="SaleShop_Member_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">UserName<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_Member_UserName" value="<%=UO.UserName%>" style="width:100%;" name="SaleShop_Member_UserName" /></td>
</tr>
<tr>
<td style="width:5%;">RealName</td>
<td><input type="text" class="txt" id="SaleShop_Member_RealName" value="<%=UO.RealName%>" style="width:100%;" name="SaleShop_Member_RealName" /></td>
</tr>
<tr>
<td style="width:5%;">ICON</td>
<td><input type="text" class="txt" id="SaleShop_Member_ICON" value="<%=UO.ICON%>" style="width:100%;" name="SaleShop_Member_ICON" /></td>
</tr>
<tr>
<td style="width:5%;">Password<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_Member_Password" value="<%=UO.Password%>" style="width:100%;" name="SaleShop_Member_Password" /></td>
</tr>
<tr>
<td style="width:5%;">Gender</td>
<td><input type="text" class="txt" id="SaleShop_Member_Gender" value="<%=UO.Gender%>" style="width:100%;" name="SaleShop_Member_Gender" /></td>
</tr>
<tr>
<td style="width:5%;">GroupId</td>
<td><input type="text" class="txt" id="SaleShop_Member_GroupId" value="<%=UO.GroupId%>" style="width:100%;" name="SaleShop_Member_GroupId" /></td>
</tr>
<tr>
<td style="width:5%;">Email</td>
<td><input type="text" class="txt" id="SaleShop_Member_Email" value="<%=UO.Email%>" style="width:100%;" name="SaleShop_Member_Email" /></td>
</tr>
<tr>
<td style="width:5%;">Mobile</td>
<td><input type="text" class="txt" id="SaleShop_Member_Mobile" value="<%=UO.Mobile%>" style="width:100%;" name="SaleShop_Member_Mobile" /></td>
</tr>
<tr>
<td style="width:5%;">District</td>
<td><input type="text" class="txt" id="SaleShop_Member_District" value="<%=UO.District%>" style="width:100%;" name="SaleShop_Member_District" /></td>
</tr>
<tr>
<td style="width:5%;">OtherContact</td>
<td><input type="text" class="txt" id="SaleShop_Member_OtherContact" value="<%=UO.OtherContact%>" style="width:100%;" name="SaleShop_Member_OtherContact" /></td>
</tr>
<tr>
<td style="width:5%;">Funds</td>
<td><input type="text" class="txt" id="SaleShop_Member_Funds" value="<%=UO.Funds%>" style="width:100%;" name="SaleShop_Member_Funds" /></td>
</tr>
<tr>
<td style="width:5%;">frostFunds</td>
<td><input type="text" class="txt" id="SaleShop_Member_frostFunds" value="<%=UO.frostFunds%>" style="width:100%;" name="SaleShop_Member_frostFunds" /></td>
</tr>
<tr>
<td style="width:5%;">Integral</td>
<td><input type="text" class="txt" id="SaleShop_Member_Integral" value="<%=UO.Integral%>" style="width:100%;" name="SaleShop_Member_Integral" /></td>
</tr>
<tr>
<td style="width:5%;">Referee</td>
<td><input type="text" class="txt" id="SaleShop_Member_Referee" value="<%=UO.Referee%>" style="width:100%;" name="SaleShop_Member_Referee" /></td>
</tr>
<tr>
<td style="width:5%;">LastIP</td>
<td><input type="text" class="txt" id="SaleShop_Member_LastIP" value="<%=UO.LastIP%>" style="width:100%;" name="SaleShop_Member_LastIP" /></td>
</tr>
<tr>
<td style="width:5%;">PrevIP</td>
<td><input type="text" class="txt" id="SaleShop_Member_PrevIP" value="<%=UO.PrevIP%>" style="width:100%;" name="SaleShop_Member_PrevIP" /></td>
</tr>
<tr>
<td style="width:5%;">RegIP</td>
<td><input type="text" class="txt" id="SaleShop_Member_RegIP" value="<%=UO.RegIP%>" style="width:100%;" name="SaleShop_Member_RegIP" /></td>
</tr>
<tr>
<td style="width:5%;">LastLoginTime</td>
<td><input type="text" class="txt" id="SaleShop_Member_LastLoginTime" value="<%=UO.LastLoginTime%>" style="width:100%;" name="SaleShop_Member_LastLoginTime" /></td>
</tr>
<tr>
<td style="width:5%;">logingtime</td>
<td><input type="text" class="txt" id="SaleShop_Member_logingtime" value="<%=UO.logingtime%>" style="width:100%;" name="SaleShop_Member_logingtime" /></td>
</tr>
<tr>
<td style="width:5%;">State</td>
<td><input type="text" class="txt" id="SaleShop_Member_State" value="<%=UO.State%>" style="width:100%;" name="SaleShop_Member_State" /></td>
</tr>
<tr>
<td style="width:5%;">RegTime</td>
<td><input type="text" class="txt" id="SaleShop_Member_RegTime" value="<%=UO.RegTime%>" style="width:100%;" name="SaleShop_Member_RegTime" /></td>
</tr>
<tr>
<td style="width:5%;">AddTime<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_Member_AddTime" value="<%=UO.AddTime%>" style="width:100%;" name="SaleShop_Member_AddTime" /></td>
</tr>
<tr>
<td style="width:5%;">IsReceiveSms</td>
<td><input type="text" class="txt" id="SaleShop_Member_IsReceiveSms" value="<%=UO.IsReceiveSms%>" style="width:100%;" name="SaleShop_Member_IsReceiveSms" /></td>
</tr>
<tr>
<td style="width:5%;">Friends</td>
<td><textarea class="textarea" id="SaleShop_Member"_Friends" content-type="1" row="20" style="width:100%;height:80px;" name="SaleShop_Member_Friends" /><%=UO.Friends%></textarea></td>
</tr>
<tr>
<td style="width:5%;">loginappid</td>
<td><input type="text" class="txt" id="SaleShop_Member_loginappid" value="<%=UO.loginappid%>" style="width:100%;" name="SaleShop_Member_loginappid" /></td>
</tr>
<tr>
<td style="width:5%;">forgotpwdtime</td>
<td><input type="text" class="txt" id="SaleShop_Member_forgotpwdtime" value="<%=UO.forgotpwdtime%>" style="width:100%;" name="SaleShop_Member_forgotpwdtime" /></td>
</tr>
<tr>
<td style="width:5%;">idcard</td>
<td><input type="text" class="txt" id="SaleShop_Member_idcard" value="<%=UO.idcard%>" style="width:100%;" name="SaleShop_Member_idcard" /></td>
</tr>
<tr>
<td style="width:5%;">birthtime</td>
<td><input type="text" class="txt" id="SaleShop_Member_birthtime" value="<%=UO.birthtime%>" style="width:100%;" name="SaleShop_Member_birthtime" /></td>
</tr>
<tr>
<td style="width:5%;">linkaddress</td>
<td><textarea class="textarea" id="SaleShop_Member"_linkaddress" row="20" style="width:100%;height:80px;" name="SaleShop_Member_linkaddress" /><%=UO.linkaddress%></textarea></td>
</tr>
<tr>
<td style="width:5%;">industry</td>
<td><input type="text" class="txt" id="SaleShop_Member_industry" value="<%=UO.industry%>" style="width:100%;" name="SaleShop_Member_industry" /></td>
</tr>
<tr>
<td style="width:5%;">mshopid</td>
<td><input type="text" class="txt" id="SaleShop_Member_mshopid" value="<%=UO.mshopid%>" style="width:100%;" name="SaleShop_Member_mshopid" /></td>
</tr>
<tr>
<td style="width:5%;">headuid</td>
<td><input type="text" class="txt" id="SaleShop_Member_headuid" value="<%=UO.headuid%>" style="width:100%;" name="SaleShop_Member_headuid" /></td>
</tr>
<tr>
<td style="width:5%;">areaid1</td>
<td><input type="text" class="txt" id="SaleShop_Member_areaid1" value="<%=UO.areaid1%>" style="width:100%;" name="SaleShop_Member_areaid1" /></td>
</tr>
<tr>
<td style="width:5%;">areaid2</td>
<td><input type="text" class="txt" id="SaleShop_Member_areaid2" value="<%=UO.areaid2%>" style="width:100%;" name="SaleShop_Member_areaid2" /></td>
</tr>
<tr>
<td style="width:5%;">areaid3</td>
<td><input type="text" class="txt" id="SaleShop_Member_areaid3" value="<%=UO.areaid3%>" style="width:100%;" name="SaleShop_Member_areaid3" /></td>
</tr>
<tr>
<td style="width:5%;">paypwd</td>
<td><input type="text" class="txt" id="SaleShop_Member_paypwd" value="<%=UO.paypwd%>" style="width:100%;" name="SaleShop_Member_paypwd" /></td>
</tr>
<tr>
<td style="width:5%;">icon_old</td>
<td><input type="text" class="txt" id="SaleShop_Member_icon_old" value="<%=UO.icon_old%>" style="width:100%;" name="SaleShop_Member_icon_old" /></td>
</tr>
<tr>
<td style="width:5%;">experience</td>
<td><input type="text" class="txt" id="SaleShop_Member_experience" value="<%=UO.experience%>" style="width:100%;" name="SaleShop_Member_experience" /></td>
</tr>
<tr>
<td style="width:5%;">IsPerfectInfo</td>
<td><input type="text" class="txt" id="SaleShop_Member_IsPerfectInfo" value="<%=UO.IsPerfectInfo%>" style="width:100%;" name="SaleShop_Member_IsPerfectInfo" /></td>
</tr>
<tr>
<td style="width:5%;">emailApprove</td>
<td><input type="text" class="txt" id="SaleShop_Member_emailApprove" value="<%=UO.emailApprove%>" style="width:100%;" name="SaleShop_Member_emailApprove" /></td>
</tr>
<tr>
<td style="width:5%;">phoneApprove</td>
<td><input type="text" class="txt" id="SaleShop_Member_phoneApprove" value="<%=UO.phoneApprove%>" style="width:100%;" name="SaleShop_Member_phoneApprove" /></td>
</tr>
<tr>
<td style="width:5%;">isSetSafeQuestion</td>
<td><input type="text" class="txt" id="SaleShop_Member_isSetSafeQuestion" value="<%=UO.isSetSafeQuestion%>" style="width:100%;" name="SaleShop_Member_isSetSafeQuestion" /></td>
</tr>
<tr>
<td style="width:5%;">question</td>
<td><input type="text" class="txt" id="SaleShop_Member_question" value="<%=UO.question%>" style="width:100%;" name="SaleShop_Member_question" /></td>
</tr>
<tr>
<td style="width:5%;">answer</td>
<td><input type="text" class="txt" id="SaleShop_Member_answer" value="<%=UO.answer%>" style="width:100%;" name="SaleShop_Member_answer" /></td>
</tr>
<tr>
<td style="width:5%;">isIdApprove</td>
<td><input type="text" class="txt" id="SaleShop_Member_isIdApprove" value="<%=UO.isIdApprove%>" style="width:100%;" name="SaleShop_Member_isIdApprove" /></td>
</tr>
<tr>
<td style="width:5%;">bankNum</td>
<td><input type="text" class="txt" id="SaleShop_Member_bankNum" value="<%=UO.bankNum%>" style="width:100%;" name="SaleShop_Member_bankNum" /></td>
</tr>
<tr>
<td style="width:5%;">isBingBank</td>
<td><input type="text" class="txt" id="SaleShop_Member_isBingBank" value="<%=UO.isBingBank%>" style="width:100%;" name="SaleShop_Member_isBingBank" /></td>
</tr>
<tr>
<td style="width:5%;">honourId</td>
<td><input type="text" class="txt" id="SaleShop_Member_honourId" value="<%=UO.honourId%>" style="width:100%;" name="SaleShop_Member_honourId" /></td>
</tr>
<tr>
<td style="width:5%;">gradeId</td>
<td><input type="text" class="txt" id="SaleShop_Member_gradeId" value="<%=UO.gradeId%>" style="width:100%;" name="SaleShop_Member_gradeId" /></td>
</tr>
<tr>
<td style="width:5%;">weixin_openid</td>
<td><input type="text" class="txt" id="SaleShop_Member_weixin_openid" value="<%=UO.weixin_openid%>" style="width:100%;" name="SaleShop_Member_weixin_openid" /></td>
</tr>
<tr>
<td style="width:5%;">qq_openid</td>
<td><input type="text" class="txt" id="SaleShop_Member_qq_openid" value="<%=UO.qq_openid%>" style="width:100%;" name="SaleShop_Member_qq_openid" /></td>
</tr>
</table>

			</div>
        </div>
    </form>
	<script type="text/javascript" src="<%=ResolveUrl("~") %>fck/fckeditor.js"></script>
    <script type="text/javascript">var SerUrl = "<%=ResolveUrl("~") %>";var LangType='en-us';</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        SerUrlValueStyle = SerUrl + 'themes/skin-1/';
        SetupInit();
        $().ready(function () {
			$('textarea[content-type="1"]').each(function(){
				FCKReg(this.id, { PageType: 'SaleShop_Member', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function SaleShop_Member_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('SaleShop_Member-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-SaleShop_Member')[0].submit(); return; }
        }
    </script>
</body>
</html>
