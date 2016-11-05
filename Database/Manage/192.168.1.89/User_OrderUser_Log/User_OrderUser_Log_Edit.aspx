<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_OrderUser_Log_Edit.aspx.cs"
    Inherits="Database_Output_User_OrderUser_Log_Edit" ValidateRequest="false" %>
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
    <form id="Form-User_OrderUser_Log" action="User_OrderUser_Log_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="User_OrderUser_Log-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="User_OrderUser_Log_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">ordersid<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="User_OrderUser_Log_ordersid" value="<%=UO.ordersid%>" style="width:100%;" name="User_OrderUser_Log_ordersid" /></td>
</tr>
<tr>
<td style="width:5%;">remark</td>
<td><textarea class="textarea" id="User_OrderUser_Log"_remark" row="20" style="width:100%;height:80px;" name="User_OrderUser_Log_remark" /><%=UO.remark%></textarea></td>
</tr>
<tr>
<td style="width:5%;">receivename<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="User_OrderUser_Log_receivename" value="<%=UO.receivename%>" style="width:100%;" name="User_OrderUser_Log_receivename" /></td>
</tr>
<tr>
<td style="width:5%;">receivetel<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="User_OrderUser_Log_receivetel" value="<%=UO.receivetel%>" style="width:100%;" name="User_OrderUser_Log_receivetel" /></td>
</tr>
<tr>
<td style="width:5%;">receivemobile<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="User_OrderUser_Log_receivemobile" value="<%=UO.receivemobile%>" style="width:100%;" name="User_OrderUser_Log_receivemobile" /></td>
</tr>
<tr>
<td style="width:5%;">receivepostcode<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="User_OrderUser_Log_receivepostcode" value="<%=UO.receivepostcode%>" style="width:100%;" name="User_OrderUser_Log_receivepostcode" /></td>
</tr>
<tr>
<td style="width:5%;">receiveaddress<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="User_OrderUser_Log_receiveaddress" value="<%=UO.receiveaddress%>" style="width:100%;" name="User_OrderUser_Log_receiveaddress" /></td>
</tr>
<tr>
<td style="width:5%;">adminname<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="User_OrderUser_Log_adminname" value="<%=UO.adminname%>" style="width:100%;" name="User_OrderUser_Log_adminname" /></td>
</tr>
<tr>
<td style="width:5%;">logtime</td>
<td><input type="text" class="txt" id="User_OrderUser_Log_logtime" value="<%=UO.logtime%>" style="width:100%;" name="User_OrderUser_Log_logtime" /></td>
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
				FCKReg(this.id, { PageType: 'User_OrderUser_Log', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function User_OrderUser_Log_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('User_OrderUser_Log-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-User_OrderUser_Log')[0].submit(); return; }
        }
    </script>
</body>
</html>
