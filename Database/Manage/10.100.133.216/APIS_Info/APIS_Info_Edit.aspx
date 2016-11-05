<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APIS_Info_Edit.aspx.cs"
    Inherits="Database_Output_APIS_Info_Edit" ValidateRequest="false" %>
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
    <form id="Form-APIS_Info" action="APIS_Info_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="APIS_Info-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="APIS_Info_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">Country<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="APIS_Info_Country" value="<%=UO.Country%>" style="width:100%;" name="APIS_Info_Country" /></td>
</tr>
<tr>
<td style="width:5%;">Airlines<span style="color: Red; padding-left: 3px;">*</span></td>
<td><textarea class="textarea" id="APIS_Info"_Airlines" content-type="1" required="1" row="20" style="width:100%;height:80px;" name="APIS_Info_Airlines" /><%=UO.Airlines%></textarea></td>
</tr>
<tr>
<td style="width:5%;">IsRequired<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="APIS_Info_IsRequired" value="<%=UO.IsRequired%>" style="width:100%;" name="APIS_Info_IsRequired" /></td>
</tr>
<%if(!string.IsNullOrEmpty(Request["id"])){%><tr>
<td style="width:5%;">CreateOn</td>
<td><%=UO.CreateOn%></td>
</tr><%}%>
<%if(!string.IsNullOrEmpty(Request["id"])){%><tr>
<td style="width:5%;">CreateBy</td>
<td><%=UO.CreateBy%></td>
</tr><%}%>
<%if(!string.IsNullOrEmpty(Request["id"])){%><tr>
<td style="width:5%;">UpdateOn</td>
<td><%=UO.UpdateOn%></td>
</tr><%}%>
<%if(!string.IsNullOrEmpty(Request["id"])){%><tr>
<td style="width:5%;">UpdateBy</td>
<td><%=UO.UpdateBy%></td>
</tr><%}%>
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
				FCKReg(this.id, { PageType: 'APIS_Info', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function APIS_Info_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('APIS_Info-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-APIS_Info')[0].submit(); return; }
        }
    </script>
</body>
</html>
