function InitInvokeMethod() {
    var methodName = $('#init-method').val();
    var historyName = $('#init-history').val();
    if (!IsEmpty(historyName) && !IsEmpty(methodName)) {
        LoadRecent(methodName, historyName);
    }
}
function GetWebMethod(isRefresh) {
    //$('#dv-web-methods-default').css('height', $(window).height() - 62-100 + 'px');
    var refreshParam = isRefresh ? '&refresh=1' : '';
    CommonCall('WebService/Callback/Edit.aspx', 0, 'dv-web-methods', 'dv-web-methods', 'dv-web-methods', '', '&pn=' + ProjectName + refreshParam, 'text', function () {
        //$('#dv-web-method-list').css('height', $(window).height() - 90 -100+ 'px');
        InitInvokeMethod();
    });
}
function GetWebMethodInfo(methodName, actionType, historyName) {
    document.title = methodName + ' - ' + ProjectName;
    if (actionType == null) actionType = 1;
    var methodDiv = $('#dv-method-' + methodName);
    $('body').css('overflow', 'hidden');
    $("#dv-web-methods").find('a[onclick^="GetWebMethodInfo"]').each(function () {
        if ($(this).html().trim() == methodName) {
            $(this).parent().parent().attr('class', 'focus');
        }
        else {
            $(this).parent().parent().attr('class', '');
        }
    });
    if (methodDiv.length > 0) {
        if ($('#invoke-' + methodName).length > 0) {
            $('#dv-web-method-info').find('div[id^="dv-method-"]').hide();
            methodDiv.fadeIn();
            $('div[id^="dv-result-"]').hide();
            $('#dv-result-' + methodName).fadeIn();
            $('body').css('overflow', '');
            return;
        }
        else {
            $('#dv-method-' + methodName).remove();
            $('#dv-result-' + methodName).remove();
        }
    }
    CommonCall('WebService/Callback/Edit.aspx', actionType, '', 'dv-web-service-content', '', '', '&pn=' + ProjectName + '&mn=' + methodName + '&history=' + historyName, 'text', function (data) {
        var methodDivs = $('#dv-web-method-info').find('div[id^="dv-method-"]');
        var isFirst = methodDivs.length == 0;
        if (isFirst) {
            $('#dv-web-method-info').html(data);
        }
        else {
            methodDivs.hide();
            $('#dv-web-method-info').append(data);
        }
        EnhanceTextarea('dv-method-' + methodName);
        if ($('#dv-web-method-result').find('div[id^="dv-result-"]').length == 0) {
            $('#dv-web-method-result').html('<div id="dv-result-' + methodName + '" style="min-height: 50px;"></div>');
        }
        else {
            $('#dv-web-method-result').find('div[id^="dv-result-"]').hide();
            if ($('#dv-result-' + methodName).length == 0) {
                $('#dv-web-method-result').append('<div id="dv-result-' + methodName + '" style="min-height: 50px;"></div>');
            }
        }
        $('body').css('overflow', '');
        if (actionType == 3 && !IsEmpty($('#init-method').val())) {
            window.setTimeout(function () {
                $('#init-method').val('');
                $('#init-history').val('');
                InvokeWebMethod(methodName);
            }, 500);
        }
        if (actionType == 1) {
            LoadRecent(methodName, 'Recent');
        }
    });
}
function LoadRecent(methodName, historyName) {
    if (historyName == null || historyName == '')
        historyName = $('#invoke-history-' + methodName).val();
    $('#dv-method-' + methodName).remove();
    $('#dv-result-' + methodName).remove();
    GetWebMethodInfo(methodName, 3, historyName);
}
function InvokeWebMethod(methodName) {
    var paramDvId = 'dv-method-' + methodName;
    var params = 'type=2&pn=' + ProjectName + '&mn=' + methodName + '&history=' + $('#invoke-history-' + methodName).val() + '&file-type=' + $('#file-type-' + methodName).val();
    params += getParams(paramDvId, 'WMP_', 'input,textarea');
    $('#dv-result-' + methodName).html('<span style="padding-left:2px;">Invoking,Please Wait...</span>');
    CommonCall('WebService/Callback/Edit.aspx', 2, '', paramDvId, '', '', params, 'text', function (data) {
        $('#dv-result-' + methodName).html(data);
        EnhanceTextarea('dv-result-' + methodName);
        $('#btn-forward-' + methodName).show();
        var xml = $('textarea[name="result-' + methodName + '"]').val();
        //ShowAsObject(methodName, xml.replace(/&/g, '&amp;'));
        var resultText = $('textarea[name="result-' + methodName + '"]');
        if (resultText.length>0 && resultText.val().length < 500000) {
            if (typeof (DOMParser) != 'undefined') {
                $('#view-as-object-' + methodName).css('padding', '3px 0px 5px 0px');
                $('#view-as-object-' + methodName).html('<div><div class="comment-box" style="padding: 2px;margin:0px 3px;">XML viewer loading,please wait...</div><div>');
                window.setTimeout(function () { ShowAsObject(methodName, xml); }, 1000);
            }
        }
    });
}
function ShowAsObject(methodName, xml) {
    eval("d" + methodName + "= new dTree('d" + methodName + "');");
    eval("d" + methodName + ".add(0, -1, 'Result Viewer', null);");
    var dParser = new DOMParser().parseFromString(xml, 'text/xml');
    var node = dParser.childNodes[0];
    eval("SetNode(node, 0, d" + methodName + ");");
    $('#view-as-object-' + methodName).html('<div style="padding-bottom:3px;"><a href="javascript:d' + methodName + '.openAll();" class="a-btn">Expand All Nodes</a>&nbsp;<span class="mm-split">|</span>&nbsp;<a href="javascript: d' + methodName + '.closeAll();" class="a-btn">Close All Nodes</a></div>');

    eval("$('#view-as-object-' + '" + methodName + "').append(d" + methodName + ".toString());");
}
function GetNodeAttributes(node) {
    if (node.attributes == null) return "";
    if (node.attributes.length == 0) return "";
    var attributesDisplay = '';
    for (var i = 0; i < node.attributes.length; i++) {
        if (node.attributes[i].name.indexOf('xmlns') >= 0 || node.attributes[i].name.indexOf('xsi:') >= 0) continue;
        attributesDisplay += ' <span style="color:#FD0034;">' + node.attributes[i].name + '</span><span style="color:#0000FD;">=</span>"<span style="color:#0000FD;">' + node.attributes[i].value + '</span>"';
    }
    return attributesDisplay;
}
function SetNode(node, parentId, ddtree) {
    GetNodeAttributes(node);
    var currentId = ddtree.aNodes.length;
    var nodeNameDisplay = '<span style="color:#A31515;">' + node.nodeName + '</span>';
    var displayName = '<span style="color:#0000FD;">' + HtmlEncode("<") + '</span>' + nodeNameDisplay + GetNodeAttributes(node) + '<span style="color:#0000FD;">' + HtmlEncode(">") + '</span>';
    if (node.hasChildNodes() && node.childElementCount > 0) {
        displayName += " (" + node.childElementCount + ")";
    }
    else {
        displayName += HtmlEncode(node.textContent).replace(/\r\n|\n|\r/g, '<br />') + '<span style="color:#0000FD;">' + HtmlEncode("</") + '</span>' + nodeNameDisplay + '<span style="color:#0000FD;">' + HtmlEncode(">") + '</span>';
    }
    ddtree.add(ddtree.aNodes.length, parentId, displayName);
    if (node.hasChildNodes()) {
        for (var i = 0; i < node.childNodes.length; i++) {
            if (node.childNodes[i].nodeType != 1) continue;
            SetNode(node.childNodes[i], currentId, ddtree);
        }
    }
}
function ClearMethod(methodName) {
    $('#dv-method-' + methodName).remove();
    $('#dv-result-' + methodName).remove();
    GetWebMethodInfo(methodName);
}
function ShareInvoke(methodName) {
    MsgBox($('#dv-forward-' + methodName).html(), 'Share Invoking Information : "' + methodName + '"', false); //,'dv-result-'+methodName);
    $('#alert_div_MSGBOX').find('textarea')[0].select();
}
function DeleteInvokeHistory(methodName, historyName) {
    Confirm('Are you sure you want to delete "' + historyName + '"?', 'Delete Invoke History', false, '', 'DeleteInvokeHistoryExec(\'' + methodName + '\',\'' + historyName + '\');', '', '', '');
}
function DeleteInvokeHistoryExec(methodName, historyName) {
    CommonCall('WebService/Callback/Edit.aspx?pn=' + ProjectName + '&mn=' + methodName + '&history=' + historyName, 4, '', 'dv-table-web-service', '', '', '', 'json', function (data) {
        if (data.success) {
            CM();
            LoadRecent(methodName, 'Recent');
        }
        else {
            MsgBox(data.message);
        }
    });
}
function ChangeRequestMode(methodName, mode) {
    if (mode == 'soap') {
        $('#dv-parameter-' + methodName).hide();
        $('#dv-parameter-soap-' + methodName).show();
        $('#WMP_Object_' + methodName).val('0');
        $('#WMP_SOAP_' + methodName).val('1');
    }
    else {
        $('#dv-parameter-' + methodName).show();
        $('#dv-parameter-soap-' + methodName).hide();
        $('#WMP_Object_' + methodName).val('1');
        $('#WMP_SOAP_' + methodName).val('0');
    }
}

function ViewBy(methodName, viewType) {
    if (viewType == "text/xml") {
        $('#form-' + methodName).find('textarea').val(encodeURIComponent($('#form-' + methodName).find('textarea').val()));
    }
    $('#type-' + methodName).val(viewType); $('#form-' + methodName)[0].submit();
    $('#form-' + methodName).find('textarea').val(decodeURIComponent($('#form-' + methodName).find('textarea').val()));
}
function ShowReturnInfo(sender) {
    var methodName = $(sender).attr('method-name');
    if ($(this).attr('show') != 1) {
        $(this).html('Hide').attr('show', 1);
        $('[class="return-info-' + methodName + '"]').show();
    }
    else {
        $(this).html('Show').attr('show', 0);
        $('[class="return-info-' + methodName + '"]').hide();
    }
}