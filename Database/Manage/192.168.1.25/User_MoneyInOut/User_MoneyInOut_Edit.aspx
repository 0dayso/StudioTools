<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_MoneyInOut_Edit.aspx.cs"
    Inherits="Database_Output_User_MoneyInOut_Edit" ValidateRequest="false" %>
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
    <form id="Form-User_MoneyInOut" action="User_MoneyInOut_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="User_MoneyInOut-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="User_MoneyInOut_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">WasteBookId</td>
<td><input type="text" class="txt" id="User_MoneyInOut_WasteBookId" value="<%=UO.WasteBookId%>" style="width:100%;" name="User_MoneyInOut_WasteBookId" /></td>
</tr>
<tr>
<td style="width:5%;">UId</td>
<td><input type="text" class="txt" id="User_MoneyInOut_UId" value="<%=UO.UId%>" style="width:100%;" name="User_MoneyInOut_UId" /></td>
</tr>
<tr>
<td style="width:5%;">OrderId</td>
<td><input type="text" class="txt" id="User_MoneyInOut_OrderId" value="<%=UO.OrderId%>" style="width:100%;" name="User_MoneyInOut_OrderId" /></td>
</tr>
<tr>
<td style="width:5%;">Flag</td>
<td><input type="text" class="txt" id="User_MoneyInOut_Flag" value="<%=UO.Flag%>" style="width:100%;" name="User_MoneyInOut_Flag" /></td>
</tr>
<tr>
<td style="width:5%;">Momey</td>
<td><input type="text" class="txt" id="User_MoneyInOut_Momey" value="<%=UO.Momey%>" style="width:100%;" name="User_MoneyInOut_Momey" /></td>
</tr>
<tr>
<td style="width:5%;">MoneyType</td>
<td><input type="text" class="txt" id="User_MoneyInOut_MoneyType" value="<%=UO.MoneyType%>" style="width:100%;" name="User_MoneyInOut_MoneyType" /></td>
</tr>
<tr>
<td style="width:5%;">Note</td>
<td><input type="text" class="txt" id="User_MoneyInOut_Note" value="<%=UO.Note%>" style="width:100%;" name="User_MoneyInOut_Note" /></td>
</tr>
<tr>
<td style="width:5%;">Source</td>
<td><input type="text" class="txt" id="User_MoneyInOut_Source" value="<%=UO.Source%>" style="width:100%;" name="User_MoneyInOut_Source" /></td>
</tr>
<tr>
<td style="width:5%;">PayCode</td>
<td><input type="text" class="txt" id="User_MoneyInOut_PayCode" value="<%=UO.PayCode%>" style="width:100%;" name="User_MoneyInOut_PayCode" /></td>
</tr>
<tr>
<td style="width:5%;">PayBookId</td>
<td><input type="text" class="txt" id="User_MoneyInOut_PayBookId" value="<%=UO.PayBookId%>" style="width:100%;" name="User_MoneyInOut_PayBookId" /></td>
</tr>
<tr>
<td style="width:5%;">BeginTime</td>
<td><input type="text" class="txt" id="User_MoneyInOut_BeginTime" value="<%=UO.BeginTime%>" style="width:100%;" name="User_MoneyInOut_BeginTime" /></td>
</tr>
<tr>
<td style="width:5%;">EndTime</td>
<td><input type="text" class="txt" id="User_MoneyInOut_EndTime" value="<%=UO.EndTime%>" style="width:100%;" name="User_MoneyInOut_EndTime" /></td>
</tr>
<tr>
<td style="width:5%;">State</td>
<td><input type="text" class="txt" id="User_MoneyInOut_State" value="<%=UO.State%>" style="width:100%;" name="User_MoneyInOut_State" /></td>
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
				FCKReg(this.id, { PageType: 'User_MoneyInOut', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function User_MoneyInOut_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('User_MoneyInOut-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-User_MoneyInOut')[0].submit(); return; }
        }
    </script>
</body>
</html>
