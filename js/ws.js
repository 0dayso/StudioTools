var loading = "<img src='" + SerUrl + "images/loading.gif' />";
var sloading = "<img src='" + SerUrl + "images/s_loading.gif' />";
var hloading = "<img src='" + SerUrl + "images/hbload.gif' />";
var errorImg = "<img src='" + SerUrl + "images/problem.gif' style='padding:0px 05px 0px 5px;' />";
function IsTimeout(ret_text) {
    return ret_text == "Timeout";
}
function RedirectLogin() {
    window.location = SerUrl + 'login.aspx' + '?to=1' + GetPara("lang");
}
function EndRequestAndValidate(str, objId) {
    if (IsTimeout(str)) RedirectLogin();
    else o(objId).innerHTML = str;
}
function ValidateSession(ret_text) {
    if (IsTimeout(ret_text)) { RedirectLogin(); return false; }
    else
        return true;
}
function GetPara(lang) {
    if (GetUrlParaValue(lang))
    { return "&lang=" + GetUrlParaValue("lang"); }
    return "";
}
function GetUrlParaValue(argname) {
    var str = location.href;
    var submatch;
    if (submatch = str.match(/\?([^#]*)#?/)) {
        var argstr = '&' + submatch[1];
        var returnPattern = function (str) {
            return str.replace(/&([^=]+)=([^&]*)/, 'o1:"o2",');
        };
        argstr = argstr.replace(/&([^=]+)=([^&]*)/g, returnPattern);
        eval('var retvalue = {' + argstr.substr(0, argstr.length - 1) + '};');
        return retvalue[argname];
    }
    return null;
}
//ft(this,'nav-container','edit-content','tab')
//fucus the ul>li tab
function ft(selObj, dvNavigatorId, dvEditId, tabCssName, dvPrefix)//focus this
{
    if (selObj.id == 'active') return;
    tabCssName = IsEmpty(tabCssName) ? 'tab' : tabCssName;
    dvPrefix = (dvPrefix == null || dvPrefix == undefined) ? 'dv-' : dvPrefix;
    dvNavigatorId = IsEmpty(dvNavigatorId) ? 'nav-container' : dvNavigatorId;
    dvEditId = IsEmpty(dvEditId) ? 'edit-content' : dvEditId;
    $('li', '#' + dvNavigatorId).each(function (i) { this.id = ''; });
    $('div.' + tabCssName, '#' + dvEditId).css('display', 'none');
    selObj.id = 'active';
    $('#' + dvPrefix + selObj.className, '#' + dvEditId).fadeIn(); //.css('display','');
}
function EnhanceTextarea(containerId,obj) {
    var textarea = null;
    if (obj == null) {
        obj = $('#' + containerId);
    }
    if (obj.is('textarea')) {
        textarea = obj;
    }
    else {
        $('#' + containerId).find('textarea').each(function () {
            EnhanceTextarea('', $(this));
        });
        return;
    }
    textarea.dblclick(function () {
        var currentSrollTop = $(window).scrollTop();
        if (IsEmpty($(this).attr('id'))) {
            $(this).attr('id', Math.random().toString().replace(".", ""));
        }
        $('body').css('overflow', 'hidden');
        var textareaId = $(this).attr('id');
        var toolbar = '<div style="text-align:right;" class="title-bar"><span style="float:left;margin:3px 0px 0px 5px;">Double click to close</span><span onclick="$(\'body\').css(\'overflow\', \'\');CloseMsgBox();" style="float:right;margin:3px 5px 0px 0px;" class="msg-cs"/></span></div>';
        ShowDiv(toolbar + '<div class="box" id="dv-textarea"><textarea id="txt-view-code" style="margin:0px;width:100%;height:' + ($(window).height() - 30-28) + 'px;">' + '</textarea>', $(window).width(), $(window).height() - 20, '', '', 0.1, 28, 'dv-content');
        $('#txt-view-code').val($(this).val());
        window.setTimeout(function () { $(window).scrollTop(0); }, 1);
        $('#txt-view-code').dblclick(function () {
            $('#' + textareaId).val($(this).val());
            CM();
            $('body').css('overflow', '');
            $(window).scrollTop(currentSrollTop);
        }).focus();
        ShowBackgroup(null, 0.7);
        $('#dv-textarea'); //.hide().fadeIn('fast');
    });  //.focus(function () { $(this).select(); });
}
function ShowHideProjects(sender) {
    var targetElement = $(sender).next();
    if ($(targetElement).css('display') == 'none') {
        $(targetElement).fadeIn();
        $(sender).find('span[class="hide"]').show();
        $(sender).find('span[class="show"]').hide();
    }
    else {
        $(targetElement).fadeOut();
        $(sender).find('span[class="hide"]').hide();
        $(sender).find('span[class="show"]').show();
    }
}
function FormatXml(objId) {
    var paramDvId = '';
    sld(objId);
    var params = 'type=2&xml=' + encodeURIComponent($('#' + objId).val());
    CommonCall('Callback/Viewer.aspx', 2, '', paramDvId, '', '', params, 'text', function (data) {
        $('#' + objId).val(data);
        CM();
    });
}

//region project
function LoadProjects() {
    CommonCall(ProjectCategory+'/Callback/Projects.aspx?show=' + getUrlParam('show'), 0, 'dv-projects', 'dv-projects', 'dv-projects', 'TP_', '', 'text', null);
}
function ProjectExec(txtId, type) {
    var errLabel = o('dv-error');
    errLabel.innerHTML = '';
    if (IsEmpty(oa(txtId))) {
        errLabel.innerHTML = 'Please input the project.';
    }
    else {
        $.ajax({
            url: SerUrl + ProjectCategory + '/Callback/Projects.aspx?type=' + type + '&content=' + encodeURIComponent(oa(txtId)),
            type: 'post',
            cache: false,
            dataType: 'text',
            data: '',
            error: function () { },
            success: function (data, textStatus) {
                if (data != "OK") { errLabel.innerHTML = data; }
                else {
                    CloseMsgBox();
                    LoadProjects();
                }
            }
        });
    }
}
function DeleteProject(projName) {
    Confirm('Are you sure you want to delete "' + projName + '"?', 'Delete Project', false, '', 'DeleteProjectExec(\'' + projName + '\');', '', '', '');
}
function DeleteProjectExec(projName) {
    CommonCall(ProjectCategory + '/Callback/Projects.aspx?pn=' + projName, 3, 'dv-projects', '', 'dv-projects', 'TP_', '', 'json', function (data) {
        if (data.success) {
            CM();
            LoadProjects();
        }
        else {
            MsgBox(data.message);
        }
    });
}
//end region project