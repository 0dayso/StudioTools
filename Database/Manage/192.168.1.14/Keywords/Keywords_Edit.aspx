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
<td style="width:5%;">Find</td>
<td><input type="text" class="txt" id="Keywords_Find" value="<%=UO.Find%>" style="width:100%;" name="Keywords_Find" /></td>
</tr>
<tr>
<td style="width:5%;">Replacement</td>
<td><input type="text" class="txt" id="Keywords_Replacement" value="<%=UO.Replacement%>" style="width:100%;" name="Keywords_Replacement" /></td>
</tr>
<tr>
<td style="width:5%;">Editor</td>
<td><input type="text" class="txt" id="Keywords_Editor" value="<%=UO.Editor%>" style="width:100%;" name="Keywords_Editor" /></td>
</tr>
<tr>
<td style="width:5%;">EditTime</td>
<td><input type="text" class="txt" id="Keywords_EditTime" value="<%=UO.EditTime%>" style="width:100%;" name="Keywords_EditTime" /></td>
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
