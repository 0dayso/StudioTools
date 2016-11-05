<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main_AdvertisementsType_Edit.aspx.cs"
    Inherits="Database_Output_Main_AdvertisementsType_Edit" ValidateRequest="false" %>
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
    <form id="Form-Main_AdvertisementsType" action="Main_AdvertisementsType_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="Main_AdvertisementsType-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="Main_AdvertisementsType_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">Name</td>
<td><input type="text" class="txt" id="Main_AdvertisementsType_Name" value="<%=UO.Name%>" style="width:100%;" name="Main_AdvertisementsType_Name" /></td>
</tr>
<tr>
<td style="width:5%;">Price</td>
<td><input type="text" class="txt" id="Main_AdvertisementsType_Price" value="<%=UO.Price%>" style="width:100%;" name="Main_AdvertisementsType_Price" /></td>
</tr>
<tr>
<td style="width:5%;">ImgUrl</td>
<td><input type="text" class="txt" id="Main_AdvertisementsType_ImgUrl" value="<%=UO.ImgUrl%>" style="width:100%;" name="Main_AdvertisementsType_ImgUrl" /></td>
</tr>
<tr>
<td style="width:5%;">Adway</td>
<td><input type="text" class="txt" id="Main_AdvertisementsType_Adway" value="<%=UO.Adway%>" style="width:100%;" name="Main_AdvertisementsType_Adway" /></td>
</tr>
<tr>
<td style="width:5%;">DefaultHtmlCode</td>
<td><textarea class="textarea" id="Main_AdvertisementsType"_DefaultHtmlCode" content-type="1" row="20" style="width:100%;height:80px;" name="Main_AdvertisementsType_DefaultHtmlCode" /><%=UO.DefaultHtmlCode%></textarea></td>
</tr>
<tr>
<td style="width:5%;">DefaultParameter</td>
<td><textarea class="textarea" id="Main_AdvertisementsType"_DefaultParameter" content-type="1" row="20" style="width:100%;height:80px;" name="Main_AdvertisementsType_DefaultParameter" /><%=UO.DefaultParameter%></textarea></td>
</tr>
<tr>
<td style="width:5%;">EditTime</td>
<td><input type="text" class="txt" id="Main_AdvertisementsType_EditTime" value="<%=UO.EditTime%>" style="width:100%;" name="Main_AdvertisementsType_EditTime" /></td>
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
				FCKReg(this.id, { PageType: 'Main_AdvertisementsType', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function Main_AdvertisementsType_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('Main_AdvertisementsType-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-Main_AdvertisementsType')[0].submit(); return; }
        }
    </script>
</body>
</html>
