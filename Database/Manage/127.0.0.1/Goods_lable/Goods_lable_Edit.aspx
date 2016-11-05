<%@ page language="C#" autoeventwireup="true" inherits="Database_Output_Goods_lable_Edit, App_Web_goods_lable_edit.aspx.eeccb890" validaterequest="false" %>
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
    <form id="Form-Goods_lable" action="Goods_lable_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="Goods_lable-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="Goods_lable_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">merchantid</td>
<td><input type="text" class="txt" id="Goods_lable_merchantid" value="<%=UO.merchantid%>" style="width:100%;" name="Goods_lable_merchantid" /></td>
</tr>
<tr>
<td style="width:5%;">lablename</td>
<td><input type="text" class="txt" id="Goods_lable_lablename" value="<%=UO.lablename%>" style="width:100%;" name="Goods_lable_lablename" /></td>
</tr>
<tr>
<td style="width:5%;">lablecolor</td>
<td><input type="text" class="txt" id="Goods_lable_lablecolor" value="<%=UO.lablecolor%>" style="width:100%;" name="Goods_lable_lablecolor" /></td>
</tr>
<tr>
<td style="width:5%;">addTime</td>
<td><input type="text" class="txt" id="Goods_lable_addTime" value="<%=UO.addTime%>" style="width:100%;" name="Goods_lable_addTime" /></td>
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
				FCKReg(this.id, { PageType: 'Goods_lable', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function Goods_lable_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('Goods_lable-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-Goods_lable')[0].submit(); return; }
        }
    </script>
</body>
</html>
