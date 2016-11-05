<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_payment_Edit.aspx.cs"
    Inherits="Database_Output_SaleShop_payment_Edit" ValidateRequest="false" %>
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
    <form id="Form-SaleShop_payment" action="SaleShop_payment_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="SaleShop_payment-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="SaleShop_payment_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">pay_name<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_payment_pay_name" value="<%=UO.pay_name%>" style="width:100%;" name="SaleShop_payment_pay_name" /></td>
</tr>
<tr>
<td style="width:5%;">pay_code<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_payment_pay_code" value="<%=UO.pay_code%>" style="width:100%;" name="SaleShop_payment_pay_code" /></td>
</tr>
<tr>
<td style="width:5%;">pay_fee<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_payment_pay_fee" value="<%=UO.pay_fee%>" style="width:100%;" name="SaleShop_payment_pay_fee" /></td>
</tr>
<tr>
<td style="width:5%;">pay_desc</td>
<td><textarea class="textarea" id="SaleShop_payment"_pay_desc" content-type="1" row="20" style="width:100%;height:80px;" name="SaleShop_payment_pay_desc" /><%=UO.pay_desc%></textarea></td>
</tr>
<tr>
<td style="width:5%;">Orderdisplay</td>
<td><input type="text" class="txt" id="SaleShop_payment_Orderdisplay" value="<%=UO.Orderdisplay%>" style="width:100%;" name="SaleShop_payment_Orderdisplay" /></td>
</tr>
<tr>
<td style="width:5%;">Interface</td>
<td><input type="text" class="txt" id="SaleShop_payment_Interface" value="<%=UO.Interface%>" style="width:100%;" name="SaleShop_payment_Interface" /></td>
</tr>
<tr>
<td style="width:5%;">pay_config</td>
<td><textarea class="textarea" id="SaleShop_payment"_pay_config" content-type="1" row="20" style="width:100%;height:80px;" name="SaleShop_payment_pay_config" /><%=UO.pay_config%></textarea></td>
</tr>
<tr>
<td style="width:5%;">enabled<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_payment_enabled" value="<%=UO.enabled%>" style="width:100%;" name="SaleShop_payment_enabled" /></td>
</tr>
<tr>
<td style="width:5%;">is_cod<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_payment_is_cod" value="<%=UO.is_cod%>" style="width:100%;" name="SaleShop_payment_is_cod" /></td>
</tr>
<tr>
<td style="width:5%;">is_online<span style="color: Red; padding-left: 3px;">*</span></td>
<td><input type="text" class="txt" required="1" id="SaleShop_payment_is_online" value="<%=UO.is_online%>" style="width:100%;" name="SaleShop_payment_is_online" /></td>
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
				FCKReg(this.id, { PageType: 'SaleShop_payment', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function SaleShop_payment_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('SaleShop_payment-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-SaleShop_payment')[0].submit(); return; }
        }
    </script>
</body>
</html>
