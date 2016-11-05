<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_profits_qyjl_log_Edit.aspx.cs"
    Inherits="Database_Output_SaleShop_profits_qyjl_log_Edit" ValidateRequest="false" %>
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
    <form id="Form-SaleShop_profits_qyjl_log" action="SaleShop_profits_qyjl_log_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="SaleShop_profits_qyjl_log-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="SaleShop_profits_qyjl_log_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">uid<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_profits_qyjl_log_uid" value="<%=UO.uid%>" style="width:100%;" name="SaleShop_profits_qyjl_log_uid" /></td>
</tr>
<tr>
<td style="width:5%;">orderid</td>
<td><input type="text" class="txt" id="SaleShop_profits_qyjl_log_orderid" value="<%=UO.orderid%>" style="width:100%;" name="SaleShop_profits_qyjl_log_orderid" /></td>
</tr>
<tr>
<td style="width:5%;">mshopid</td>
<td><input type="text" class="txt" id="SaleShop_profits_qyjl_log_mshopid" value="<%=UO.mshopid%>" style="width:100%;" name="SaleShop_profits_qyjl_log_mshopid" /></td>
</tr>
<tr>
<td style="width:5%;">original_price</td>
<td><input type="text" class="txt" id="SaleShop_profits_qyjl_log_original_price" value="<%=UO.original_price%>" style="width:100%;" name="SaleShop_profits_qyjl_log_original_price" /></td>
</tr>
<tr>
<td style="width:5%;">managerRatio</td>
<td><input type="text" class="txt" id="SaleShop_profits_qyjl_log_managerRatio" value="<%=UO.managerRatio%>" style="width:100%;" name="SaleShop_profits_qyjl_log_managerRatio" /></td>
</tr>
<tr>
<td style="width:5%;">profits_price</td>
<td><input type="text" class="txt" id="SaleShop_profits_qyjl_log_profits_price" value="<%=UO.profits_price%>" style="width:100%;" name="SaleShop_profits_qyjl_log_profits_price" /></td>
</tr>
<tr>
<td style="width:5%;">addtime</td>
<td><input type="text" class="txt" id="SaleShop_profits_qyjl_log_addtime" value="<%=UO.addtime%>" style="width:100%;" name="SaleShop_profits_qyjl_log_addtime" /></td>
</tr>
<tr>
<td style="width:5%;">status</td>
<td><input type="text" class="txt" id="SaleShop_profits_qyjl_log_status" value="<%=UO.status%>" style="width:100%;" name="SaleShop_profits_qyjl_log_status" /></td>
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
				FCKReg(this.id, { PageType: 'SaleShop_profits_qyjl_log', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function SaleShop_profits_qyjl_log_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('SaleShop_profits_qyjl_log-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-SaleShop_profits_qyjl_log')[0].submit(); return; }
        }
    </script>
</body>
</html>
