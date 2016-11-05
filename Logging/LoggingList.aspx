<%@ page title="" language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="logging_LoggingList, App_Web_vgzer5r6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MP1" runat="Server">
    <div style="margin-bottom: 5px;">
        <link href="<%=ResolveClientUrl("~") %>/themes/skin-<%=GetTogether.Studio.Config.Original.Skin %>/dtree.css?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
            rel="stylesheet" type="text/css" />

    </div>
    <div class="box" style="margin-bottom: 100px;">
        <div class="header" style="padding-left: 5px;background-image:none;background-color:transparent;" id="dvAllPanel">


            <a href="javascript: d.openAll();">Expand All Nodes</a> <span class="mm-split">|</span>
            <a href="javascript: d.closeAll();">Close All Nodes</a>
            <input type="checkbox" id="greater-than-zero" onclick="SizeOption(this);" /><label
                for="greater-than-zero">Size greater than zero</label>
             <span class="mm-split">|</span> <a href="javascript:;;" onclick="MsgBox($('#share-url').html());">Share</a>
        </div>
        <div class="line-sub"></div>
        <div id="logging-trees"></div>
    </div>
    <div id="share-url" style="display:none;">
<textarea style="width:500px;height:80px;margin:5px;" rows="2" cols="100" class="txt"><%=GetShareInfo() %></textarea>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptPlaceHolder" runat="Server">
    <script src="<%=ResolveClientUrl("~") %>js/dtree.js?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        var FVersion = '';
        var d;
        $().ready(function () {
            var sizeGreaterThanZero = getCK('size-option');
            $('#greater-than-zero')[0].checked = sizeGreaterThanZero == "1";
            d = new dTree('d', 'logging-trees', true, SerUrl + "Logging/Callback/LoggingList.aspx?type=1&pn=<%=Request["pn"]%>&path=<%=Request["path"]%>" + "&size-no-zero=" + sizeGreaterThanZero, SerUrl + "Logging/Callback/LoggingList.aspx?type=2&pn=<%=Request["pn"]%>&size-no-zero=" + sizeGreaterThanZero, 'dvAllPanel', 0);
        });
        function GetPage(url,vt) {
            window.open('ViewLog.aspx?file=' + url+"&view-type="+vt);
        }
        function SizeOption(sender) {
            setCK('size-option', (sender.checked ? "1" : "0"));
            window.location.replace(window.location.href);
        }
    </script>
</asp:Content>

