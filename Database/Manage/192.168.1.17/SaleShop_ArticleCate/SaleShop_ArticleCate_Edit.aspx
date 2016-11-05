<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaleShop_ArticleCate_Edit.aspx.cs"
    Inherits="Database_Output_SaleShop_ArticleCate_Edit" ValidateRequest="false" %>
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
    <form id="Form-SaleShop_ArticleCate" action="SaleShop_ArticleCate_Edit.aspx?id=<%=Request["id"] %>" method="post">
        <div id="SaleShop_ArticleCate-Content">
            <div class="edit-panel">
                <div style="text-align: right;padding:5px;">
                    <input type="button" class="btn" onclick="SaleShop_ArticleCate_Sumit()" value="Save" />
					&nbsp; <input type="button" class="btn" onclick="history.back();" value="Back" />
                </div>
            </div>
			<div class="edit-content">
				<table style="width:100%;"><tr>
<td style="width:5%;">Level</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_Level" value="<%=UO.Level%>" style="width:100%;" name="SaleShop_ArticleCate_Level" /></td>
</tr>
<tr>
<td style="width:5%;">ParentId</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_ParentId" value="<%=UO.ParentId%>" style="width:100%;" name="SaleShop_ArticleCate_ParentId" /></td>
</tr>
<tr>
<td style="width:5%;">Name</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_Name" value="<%=UO.Name%>" style="width:100%;" name="SaleShop_ArticleCate_Name" /></td>
</tr>
<tr>
<td style="width:5%;">CateType</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_CateType" value="<%=UO.CateType%>" style="width:100%;" name="SaleShop_ArticleCate_CateType" /></td>
</tr>
<tr>
<td style="width:5%;">ShopId</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_ShopId" value="<%=UO.ShopId%>" style="width:100%;" name="SaleShop_ArticleCate_ShopId" /></td>
</tr>
<tr>
<td style="width:5%;">UrlAlias</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_UrlAlias" value="<%=UO.UrlAlias%>" style="width:100%;" name="SaleShop_ArticleCate_UrlAlias" /></td>
</tr>
<tr>
<td style="width:5%;">AddTime</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_AddTime" value="<%=UO.AddTime%>" style="width:100%;" name="SaleShop_ArticleCate_AddTime" /></td>
</tr>
<tr>
<td style="width:5%;">Adder</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_Adder" value="<%=UO.Adder%>" style="width:100%;" name="SaleShop_ArticleCate_Adder" /></td>
</tr>
<tr>
<td style="width:5%;">SeoKeywords</td>
<td><textarea class="textarea" id="SaleShop_ArticleCate"_SeoKeywords" row="20" style="width:100%;height:80px;" name="SaleShop_ArticleCate_SeoKeywords" /><%=UO.SeoKeywords%></textarea></td>
</tr>
<tr>
<td style="width:5%;">SeoDescription</td>
<td><textarea class="textarea" id="SaleShop_ArticleCate"_SeoDescription" row="20" style="width:100%;height:80px;" name="SaleShop_ArticleCate_SeoDescription" /><%=UO.SeoDescription%></textarea></td>
</tr>
<tr>
<td style="width:5%;">IsSys</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_IsSys" value="<%=UO.IsSys%>" style="width:100%;" name="SaleShop_ArticleCate_IsSys" /></td>
</tr>
<tr>
<td style="width:5%;">OrderNum</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_OrderNum" value="<%=UO.OrderNum%>" style="width:100%;" name="SaleShop_ArticleCate_OrderNum" /></td>
</tr>
<tr>
<td style="width:5%;">Editor</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_Editor" value="<%=UO.Editor%>" style="width:100%;" name="SaleShop_ArticleCate_Editor" /></td>
</tr>
<tr>
<td style="width:5%;">EditTime</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_EditTime" value="<%=UO.EditTime%>" style="width:100%;" name="SaleShop_ArticleCate_EditTime" /></td>
</tr>
<tr>
<td style="width:5%;">Disable</td>
<td><input type="text" class="txt" id="SaleShop_ArticleCate_Disable" value="<%=UO.Disable%>" style="width:100%;" name="SaleShop_ArticleCate_Disable" /></td>
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
				FCKReg(this.id, { PageType: 'SaleShop_ArticleCate', UserFilesPath: 'ManageFileUploadUrl', FilesAbsolutePath: 'ManageFileUploadPath' }, null, 300, "Admin");
			});
        });
        function SaleShop_ArticleCate_Sumit() {
            var err = false;
            err = !ValidateTxtAndAreaAndSel('SaleShop_ArticleCate-Content');
            if (err) {
                return;
            }
            else { sld(); $('#Form-SaleShop_ArticleCate')[0].submit(); return; }
        }
    </script>
</body>
</html>
