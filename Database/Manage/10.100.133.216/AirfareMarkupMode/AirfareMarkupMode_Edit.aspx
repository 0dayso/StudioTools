<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirfareMarkupMode_Edit.aspx.cs"
    Inherits="Database_Output_AirfareMarkupMode_Edit" ValidateRequest="false" %>
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
    <form id="Form-AirfareMarkupMode" action="AirfareMarkupMode_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="AirfareMarkupMode-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="AirfareMarkupMode_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">DetailId<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareMarkupMode_DetailId" value="<%=UO.DetailId%>" style="width:100%;" name="AirfareMarkupMode_DetailId" /></td>
</tr>
<tr>
<td style="width:5%;">Rank</td>
<td><input type="text" class="txt" id="AirfareMarkupMode_Rank" value="<%=UO.Rank%>" style="width:100%;" name="AirfareMarkupMode_Rank" /></td>
</tr>
<tr>
<td style="width:5%;">MarkupBy</td>
<td><input type="text" class="txt" id="AirfareMarkupMode_MarkupBy" value="<%=UO.MarkupBy%>" style="width:100%;" name="AirfareMarkupMode_MarkupBy" /></td>
</tr>
<tr>
<td style="width:5%;">Amount</td>
<td><input type="text" class="txt" id="AirfareMarkupMode_Amount" value="<%=UO.Amount%>" style="width:100%;" name="AirfareMarkupMode_Amount" /></td>
</tr>
<tr>
<td style="width:5%;">Rate</td>
<td><input type="text" class="txt" id="AirfareMarkupMode_Rate" value="<%=UO.Rate%>" style="width:100%;" name="AirfareMarkupMode_Rate" /></td>
</tr>
<tr>
<td style="width:5%;">RoundUpBy</td>
<td><input type="text" class="txt" id="AirfareMarkupMode_RoundUpBy" value="<%=UO.RoundUpBy%>" style="width:100%;" name="AirfareMarkupMode_RoundUpBy" /></td>
</tr>
<tr>
<td style="width:5%;">IsRoundDown</td>
<td><input type="text" class="txt" id="AirfareMarkupMode_IsRoundDown" value="<%=UO.IsRoundDown%>" style="width:100%;" name="AirfareMarkupMode_IsRoundDown" /></td>
</tr>
<tr>
<td style="width:5%;">MarkupByValue</td>
<td><input type="text" class="txt" id="AirfareMarkupMode_MarkupByValue" value="<%=UO.MarkupByValue%>" style="width:100%;" name="AirfareMarkupMode_MarkupByValue" /></td>
</tr>
<tr>
<td style="width:5%;">Description</td>
<td><textarea class="textarea" id="AirfareMarkupMode"_Description" content-type="1" row="20" style="width:100%;height:80px;" name="AirfareMarkupMode_Description" /><%=UO.Description%></textarea></td>
</tr>
<tr>
<td style="width:5%;">AirfareMarkupModeType</td>
<td><input type="text" class="txt" id="AirfareMarkupMode_AirfareMarkupModeType" value="<%=UO.AirfareMarkupModeType%>" style="width:100%;" name="AirfareMarkupMode_AirfareMarkupModeType" /></td>
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
				FCKReg(this.id, { PageType: 'AirfareMarkupMode', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function AirfareMarkupMode_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('AirfareMarkupMode-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-AirfareMarkupMode')[0].submit(); return; }
        }
    </script>
</body>
</html>
