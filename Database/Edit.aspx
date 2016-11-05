<%@ page language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="MS_MSSQL, App_Web_edit.aspx.c985e3fb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MP1" runat="Server">
    <div style="padding-bottom: 1px;">
        <%=Parameter.Category %>&nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;
        <%=GetTogether.Studio.Database.BLL.BO_Common.GetDatabase(Parameter)%>
        (<%=Parameter.DatabaseTypeForCodeEngineer.ToString() %>)
    </div>
    <div style="width: 100%;">
    </div>
    <div id="nav-container">
        <ul id="nav-list">
            <li id="active" onclick="ft(this);" class="table-objects"><a href="javascript:;;">Generate
                By Table</a></li>
            <li onclick="ftQR(this);" class="query-objects"><a href="javascript:;;">Generate By
                SQL Script</a> </li>
            <li onclick="ftSP(this);" class="store-procedure-objects"><a href="javascript:;;">Generate
                By Store Procedure</a></li>
				
        </ul>
        <div class="line-sub"></div>
    </div>
    <div id="edit-content">
        <div id="dv-table-objects" class="tab">
            <div style="float: left; width: 25%;">
                <div id="dv-tables" style="min-height: 200px;">
                    <div id="dv-tables-default">
                    </div>
                </div>
            </div>
            <div style="width: 75%; float: right;">
                <div style="margin: 0px 0px 0px 5px;">
                    <div id="dv-table-do-value">
                        <div style="min-height: 1px;">
                        </div>
                    </div>
                    <div id="dv-table-bo-value" style="margin-top:5px;">
                        <div style="min-height: 1px;">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id="dv-query-objects" style="display: none;" class="tab">
            <div style="margin: 0px 0px 0px 0px; width: 100%; float: left;">
                <div class="box-option" style="padding-left: 2px;">
                    Query&nbsp;(Double click on the textarea to enlarge)
                </div>
                <div id="dv-query-parameter" class="box">
                    <table style="width: 100%; margin-top: 5px;" cellpadding="1px" cellspacing="1px">
                        <tr>
                            <td>
                                Object Name
                            </td>
                            <td>
                                <input type="text" id="QR_Name" required="1" class="txt" style="width: 100%;" value="SysObjectsFields" />
                            </td>
                            <td style="text-align: right;">
                                Primary Key(s)
                            </td>
                            <td>
                                <input type="text" id="QR_PrimaryKeys" required="1" class="txt" style="width: 50%;"
                                    value="column_name" />&nbsp;Comma separated value
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                Query SQL
                            </td>
                            <td colspan="3">
                                <textarea id="QR_Sql" cols="10" rows="10" style="height: 100px; width: 100%;" class="txt">select column_name,column_default,is_nullable,data_type,character_maximum_length as max_length from INFORMATION_SCHEMA.COLUMNS where table_name='sysobjects'</textarea>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: right; padding: 5px;">
                        <input type="button" class="btn5" onclick="GenCodeByQuery();" value="Generate" />
                    </div>
                </div>
                <div id="dv-query-do-value" style="margin-top:5px;">
                    <div style="min-height: 1px;">
                    </div>
                </div>
                <div id="dv-query-bo-value" style="margin-top:5px;">
                    <div style="min-height: 1px;">
                    </div>
                </div>
            </div>
        </div>
        <div id="dv-store-procedure-objects" style="display: none;" class="tab">
            <div style="float: left; width: 25%;">
                <div id="dv-store-procedures" style="min-height: 50px;">
                </div>
            </div>
            <div style="float: left; width: 75%;">
                <div style="margin: 0px 0px 0px 5px;">
                    <div id="dv-store-procedure-parameters">
                        <div class="box-option" style="padding-left: 2px;">
                            Store Procedure&nbsp;(Double click on the textarea to enlarge)
                        </div>
                        <div class="box">
                            <table style="width: 100%; margin-top: 5px;" cellpadding="1px" cellspacing="1px">
                                <tr>
                                    <td style="width: 90px;">
                                        Object Name
                                    </td>
                                    <td colspan="3">
                                        <input type="text" id="SP_ObjectName" style="width: 250px;" required="1" class="txt"
                                            value="<%=Parameter.DatabaseTypeForCodeEngineer== GetTogether.Data.DatabaseType.MySQL?"":"ObjectName" %>" />
                                        Prodecure Name
                                        <input type="text" id="SP_StoreProcedureName" class="txt" required="1" style="width: 250px;"
                                            value="<%=Parameter.DatabaseTypeForCodeEngineer== GetTogether.Data.DatabaseType.MySQL?"":"sp_who" %>" />
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                        Execute
                                    </td>
                                    <td colspan="3">
                                        <div id="dv-store-procedure-simple">
                                            <textarea rows='10' cols="10" id="SP_Sql" style="width: 100%;" class="txt"><%=GetDefaultStoreProcedure() %></textarea>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Result Mapping
                                    </td>
                                    <td colspan="2">
                                        <input class="txt" value="" id="SP_RetObjMapping" type="text" style="width: 70%;" />&nbsp;For
                                        Example: Main,Detail
                                    </td>
                                    <td style="text-align:right;"><input type="button" class="btn5" onclick="GenAllCodeByStoreProcedure();" value="All-Generate" />&nbsp;&nbsp;<input type="button" class="btn5" onclick="    GenCodeByStoreProcedure();" value="Generate" /></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                        <div id="dv-store-procedure-do-value" style="margin-top:5px;">
                            <div style="min-height: 1px;">
                            </div>
                        </div>
                        <div id="dv-store-procedure-bo-value" style="margin-top:5px;">
                            <div style="min-height: 1px;">
                            </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptPlaceHolder" Runat="Server">
    <script language="javascript" type="text/javascript">
        var ProjectName = '<%=Request["pn"] %>';
        $(document).ready(function () {
            $('#dv-tables-default').css('height', $(window).height() - 78 + 'px');
            $('#dv-store-procedures').css('min-height', $(window).height() - 78 + 'px');
            CommonCall('Database/Callback/Edit.aspx', 0, 'dv-tables', 'dv-tables', 'dv-tables', 'EP_', '&pn=' + ProjectName, 'text', function () {
                var d = $('a[onclick^=GenTableCode]');
                if (d.length > 0) { d[0].click(); }
                $('#dv-table-list').css('max-height', $(window).height() - 106 + 'px');
            });
            EnhanceTextarea('QR_Sql');
            EnhanceTextarea('SP_Sql');
        });
        function GenTableCode(table) {
            $("#dv-tables").find('a[onclick^="GenTableCode"]').each(function () {
                if ($(this).html().trim() == table) {
                    $(this).parent().parent().attr('class', 'focus');
                }
                else
                    $(this).parent().parent().attr('class', '');
            });
            document.title = table + " - " + ProjectName;
            GenDoTableCode(table);
        }
        function GenDoTableCode(table) {
            var primaryKeyOverwrite = $('#primary-key-overwrite').val();
            if (primaryKeyOverwrite == null) primaryKeyOverwrite = '';
            CommonCall('Database/Callback/Edit.aspx', 1, 'dv-table-do-value', 'dv-table-do-value', 'dv-table-do-value', 'EP_',
            '&pn=' + ProjectName +
            '&primary-key-overwrite=' + primaryKeyOverwrite +
            '&tn=' + table,
            'text', function () {
                EnhanceTextarea('dv-table-do-value');
                GenBoTableCode(table, primaryKeyOverwrite);
            });
        }
        function GenDoAllTableCode() {
            var primaryKeyOverwrite = $('#primary-key-overwrite').val();
            if (primaryKeyOverwrite == null) primaryKeyOverwrite = '';

            CommonALLCall('Database/Callback/Edit.aspx', 10, 'dv-table-do-value', 'dv-table-do-value', 'dv-table-do-value', 'EP_',
            '&pn=' + ProjectName +
            '&primary-key-overwrite=' + primaryKeyOverwrite +
            '&tn=',
            'text', function () {});
        }
        function CommonALLCall(Url, type, divId, divBgId, divParId, inputPrefix, parAppend, dType, jsFun, funComplete) {
            var params = "";
            params = getParams(divParId, inputPrefix);
            if (IsEmpty(params)) params = "";
            if (!IsEmpty(parAppend)) { params += parAppend; }
            params = "type=" + type + "&parms=" + params;
            CallALLGetList(SerUrlValue + Url, params, divId, divBgId, dType, jsFun, funComplete);
        }
        function CallALLGetList(url, params, divId, divBgId, dType, jsFun, funComplete) {
            if (dType == null) dType = "text";
            $.ajax({
                url: url + (url.indexOf('?') > -1 ? '&' : '?') + '_r=' + Math.random(),
                type: 'post',
                cache: false,
                dataType: dType,
                data: params,
                success: function (data, textStatus) { alert('this ok!'); }
            })
        }
        function GenBoTableCode(table, primaryKeyOverwrite) {
            CommonCall('Database/Callback/Edit.aspx', 2, 'dv-table-bo-value', 'dv-table-bo-value', 'dv-table-bo-value', 'EP_',
            '&pn=' + ProjectName +
            '&primary-key-overwrite=' + primaryKeyOverwrite +
            '&tn=' + table,
             'text', function () {
                 EnhanceTextarea('dv-table-bo-value');
             });
        }
        function ftQR(obj) {
            ft(obj);
        }
        function GenCodeByQuery() {
            if (!ValidateTxt('dv-query-parameter') || oa('QR_Sql') == '') { MsgBox('Invalid Parameters', 'System Information', true, 'dv-query-parameter'); return false; }
            GenDoQueryCode();
        }
        function GenDoQueryCode() {
            var parameters = '&tn=' + oa('QR_Name') + '&sql=' + oa('QR_Sql') + '&pk=' + oa('QR_PrimaryKeys');
            CommonCall('Database/Callback/Edit.aspx', 3, 'dv-query-do-value', 'dv-query-do-value', 'dv-query-do-value', 'QR_', '&pn=' + ProjectName + parameters, 'text', function () {
                EnhanceTextarea('dv-query-do-value');
                GenBoQueryCode();
            });
        }
        function GenBoQueryCode() {
            var parameters = '&tn=' + oa('QR_Name') + '&sql=' + oa('QR_Sql') + '&pk=' + oa('QR_PrimaryKeys');
            CommonCall('Database/Callback/Edit.aspx', 4, 'dv-query-bo-value', 'dv-query-bo-value', 'dv-query-bo-value', 'QR_', '&pn=' + ProjectName + parameters, 'text', function () {
                EnhanceTextarea('dv-query-bo-value');
            });
        }
        function ftSP(obj) {
            ft(obj);
            if ($('#dv-store-procedures').html().trim() == '') {
                CommonCall('Database/Callback/Edit.aspx', 5, 'dv-store-procedures', 'dv-store-procedures', 'dv-store-procedures', 'EP_', '&pn=' + ProjectName, 'text', function () {
                    $('#dv-store-procedure-list').css('max-height', $(window).height() - 106 + 'px');
                });
            }
        }
        function GenStoreProcSimple(spn) {
            document.title = spn + " - " + ProjectName;
            $("#dv-store-procedure-list").find('a[onclick^="GenStoreProcSimple"]').each(function () {
                if ($(this).html().trim() == spn) {
                    $(this).parent().parent().attr('class', 'focus');
                }
                else
                    $(this).parent().parent().attr('class', '');
            });
            o('SP_ObjectName').value = spn;
            o('SP_StoreProcedureName').value = spn;
            CommonCall('Database/Callback/Edit.aspx', 6, 'dv-store-procedure-simple', 'dv-store-procedure-parameters', 'dv-store-procedure-simple', 'EP_', '&pn=' + ProjectName + '&spn=' + spn, 'text', function () {
                EnhanceTextarea('SP_Sql');
            });
        }
        function GenAllCodeByStoreProcedure() {
            CommonALLProCall('Database/Callback/Edit.aspx', 11, 'dv-store-procedure-simple', 'dv-store-procedure-parameters', 'dv-store-procedure-simple', 'EP_', '&pn=' + ProjectName + '&spn=', 'text', function () { });
        }
        function CommonALLProCall(Url, type, divId, divBgId, divParId, inputPrefix, parAppend, dType, jsFun, funComplete) {
            var params = "";
            params = getParams(divParId, inputPrefix);
            if (IsEmpty(params)) params = "";
            if (!IsEmpty(parAppend)) { params += parAppend; }
            params = "type=" + type + "&parms=" + params;
            CallALLProGetList(SerUrlValue + Url, params, divId, divBgId, dType, jsFun, funComplete);
        }
        function CallALLProGetList(url, params, divId, divBgId, dType, jsFun, funComplete) {
            if (dType == null) dType = "text";
            $.ajax({
                url: url + (url.indexOf('?') > -1 ? '&' : '?') + '_r=' + Math.random(),
                type: 'post',
                cache: false,
                dataType: dType,
                data: params,
                success: function (data, textStatus) { alert('this ok!'); }
            })
        }
        function GenCodeByStoreProcedure() {
            if (!ValidateTxt('dv-store-procedure-parameters') || oa('SP_Sql') == '') { MsgBox('Invalid Parameters', 'System Information', true, 'dv-store-procedure-parameters'); return false; }
            GenDoStoreProcedure();
        }
        function GenDoStoreProcedure() {
            if ($('#SP_StoreProcedureName').val() == '') return;
            var parameters = '&on=' + oa('SP_ObjectName') + '&sql=' + oa('SP_Sql') + '&spn=' + oa('SP_StoreProcedureName') + '&ret-obj-mapping=' + oa('SP_RetObjMapping');
            CommonCall('Database/Callback/Edit.aspx', 7, 'dv-store-procedure-do-value', 'dv-store-procedure-do-value', 'dv-store-procedure-do-value', 'QR_', '&pn=' + ProjectName + parameters, 'text', function () {
                EnhanceTextarea('dv-store-procedure-do-value');
                GenBoStoreProcedure();
            });
        }
        function GenBoStoreProcedure() {
            var parameters = '&on=' + oa('SP_ObjectName') + '&sql=' + oa('SP_Sql') + '&spn=' + oa('SP_StoreProcedureName');
            CommonCall('Database/Callback/Edit.aspx', 8, 'dv-store-procedure-bo-value', 'dv-store-procedure-bo-value', 'dv-store-procedure-bo-value', 'QR_', '&pn=' + ProjectName + parameters, 'text', function () {
                EnhanceTextarea('dv-store-procedure-bo-value');
            });
        }
        function GenerateManagePage(tableName, isDownload) {
            var parameters = '&tn=' + tableName
                + '&pn=' + ProjectName
                + "&primary-key-overwrite=" + $('#primary-key-overwrite').val();
            if (isDownload) parameters += '&download=1';
            sld();
            CommonCall('Database/Callback/GenerateManage.aspx', 1, '', '', '', 'GenerateManagePage_', parameters, 'json', function (data) {
                CM();
                if (!data.success) {
                    MsgBox(data.message);
                }
                else {
                    if (isDownload)
                        window.open('Manage/<%=CurrentSession.UserCode %>/' + tableName + '-Management.zip');
                    else
                        window.open('Manage/<%=CurrentSession.UserCode %>/' + tableName + '/' + tableName + '.aspx');
                }
            });
        }
        function DownloadTablesCode() {
            var $talbeKey = $('#table-key');
            var parameters = '&pn=' + ProjectName + '&TableKey=' + $talbeKey.val();
            sld();
            CommonCall('Database/Callback/Edit.aspx', 9, '', '', '', '', parameters, 'json', function (data) {
                CM();
                if (!data.success) {
                    MsgBox(data.message);
                }
                else {
                    var fileName = ProjectName + '-Tables' + (IsEmpty($talbeKey.val()) ? '' : '-') + $talbeKey.val().toUpperCase() + '.zip';
                    window.open('DownloadTablesCode/<%=CurrentSession.UserCode %>'+'-' + fileName);
                }
            });
        }
    </script>
</asp:Content>