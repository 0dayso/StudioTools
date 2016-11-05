<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Keywords_Edit.aspx.cs"
    Inherits="Database_Output_Keywords_Edit" ValidateRequest="false" %>
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
    <form id="Form-Keywords" action="Keywords_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="Keywords-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="Keywords_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">find<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="Keywords_find" value="<%=UO.find%>" style="width:100%;" name="Keywords_find" /></td>
</tr>
<tr>
<td style="width:5%;">replacement<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="Keywords_replacement" value="<%=UO.replacement%>" style="width:100%;" name="Keywords_replacement" /></td>
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
				FCKReg(this.id, { PageType: 'Keywords', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function Keywords_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('Keywords-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-Keywords')[0].submit(); return; }
        }
    </script>
</body>
</html>
