<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirfareLastView_Edit.aspx.cs"
    Inherits="Database_Output_AirfareLastView_Edit" ValidateRequest="false" %>
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
    <form id="Form-AirfareLastView" action="AirfareLastView_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="AirfareLastView-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="AirfareLastView_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">CompanyCode<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_CompanyCode" value="<%=UO.CompanyCode%>" style="width:100%;" name="AirfareLastView_CompanyCode" /></td>
</tr>
<tr>
<td style="width:5%;">UserCode<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_UserCode" value="<%=UO.UserCode%>" style="width:100%;" name="AirfareLastView_UserCode" /></td>
</tr>
<tr>
<td style="width:5%;">Org<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_Org" value="<%=UO.Org%>" style="width:100%;" name="AirfareLastView_Org" /></td>
</tr>
<tr>
<td style="width:5%;">Dst<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_Dst" value="<%=UO.Dst%>" style="width:100%;" name="AirfareLastView_Dst" /></td>
</tr>
<tr>
<td style="width:5%;">OWRTOJ<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_OWRTOJ" value="<%=UO.OWRTOJ%>" style="width:100%;" name="AirfareLastView_OWRTOJ" /></td>
</tr>
<tr>
<td style="width:5%;">LastViewDate<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_LastViewDate" value="<%=UO.LastViewDate%>" style="width:100%;" name="AirfareLastView_LastViewDate" /></td>
</tr>
<tr>
<td style="width:5%;">IsDirect<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_IsDirect" value="<%=UO.IsDirect%>" style="width:100%;" name="AirfareLastView_IsDirect" /></td>
</tr>
<tr>
<td style="width:5%;">DepartureDate<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_DepartureDate" value="<%=UO.DepartureDate%>" style="width:100%;" name="AirfareLastView_DepartureDate" /></td>
</tr>
<tr>
<td style="width:5%;">ReturnDate<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="AirfareLastView_ReturnDate" value="<%=UO.ReturnDate%>" style="width:100%;" name="AirfareLastView_ReturnDate" /></td>
</tr>
<tr>
<td style="width:5%;">Airline</td>
<td><input type="text" class="txt" id="AirfareLastView_Airline" value="<%=UO.Airline%>" style="width:100%;" name="AirfareLastView_Airline" /></td>
</tr>
<tr>
<td style="width:5%;">FareCat</td>
<td><input type="text" class="txt" id="AirfareLastView_FareCat" value="<%=UO.FareCat%>" style="width:100%;" name="AirfareLastView_FareCat" /></td>
</tr>
<tr>
<td style="width:5%;">BkgClass</td>
<td><input type="text" class="txt" id="AirfareLastView_BkgClass" value="<%=UO.BkgClass%>" style="width:100%;" name="AirfareLastView_BkgClass" /></td>
</tr>
<tr>
<td style="width:5%;">FareClass</td>
<td><input type="text" class="txt" id="AirfareLastView_FareClass" value="<%=UO.FareClass%>" style="width:100%;" name="AirfareLastView_FareClass" /></td>
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
				FCKReg(this.id, { PageType: 'AirfareLastView', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function AirfareLastView_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('AirfareLastView-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-AirfareLastView')[0].submit(); return; }
        }
    </script>
</body>
</html>
