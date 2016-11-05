<%@ page language="C#" autoeventwireup="true" masterpagefile="~/MP.master" validaterequest="false" inherits="WebService_Viewer, App_Web_3v1dlpyk" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MP1" runat="Server">
    <div class="box">
    <link href="<%=ResolveClientUrl("~") %>/themes/skin-<%=GetTogether.Studio.Config.Original.Skin %>/dtree.css?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        rel="stylesheet" type="text/css" />
    <div id="xml-form" style="">
        <form method="post" target="_self" action="Viewer.aspx?type=<%=ViewType==ViewerType.XML?"text":"xml" %>">
        <textarea id="result-text-xml" name="result-text-xml" style="margin:0px;width: 100%; border:none; background-image: none;" cols="5" rows="5"><%=Content %></textarea>
        <div class="line-sub"></div>
        <div style="text-align: center; padding: 3px 0px 5px 0px;">
            <%if(ViewType== ViewerType.XML){ %>
            <input type="button" class="btn6" onclick="ShowXml();" value="Show XML As Tree" />
            <input type="button" class="btn6" onclick="FormatXml('result-text-xml');" value="Format XML" />
            <%} %>
            <%if(ViewType== ViewerType.XML){ %>
            <input type="submit" class="btn6" value="Text Viewer" />
            <%}else{ %>
            <input type="submit" class="btn6" value="XML Viewer" />
            <%} %>
             <input type="button" class="btn6" onclick="ShareXml();" value="Share" />
        </div>
            </form>
    </div>
    <%if(ViewType== ViewerType.XML){ %>
    <div id="xml-viewer">
        <div class="comment-box">XML viewer loading,please wait...</div>
    </div>
    <%} %>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="Server">
    <script type="text/javascript">var SerUrl = "<%=ResolveUrl("~") %>";</script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery.js?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/jquery-ext.js?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/ws.js?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/dtree.js?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        SerUrlValueStyle = SerUrl + 'themes/skin-<%=GetTogether.Studio.Config.Original.Skin %>/';
        SetupInit();
        var FVersion = '';
        var d = null;
        $().ready(function () {
            //$('body').css('background', 'none');
            EnhanceTextarea('result-text-xml');
            <%if(ViewType== ViewerType.XML){ %>
            ShowXml();<%}else{%>
            $('#result-text-xml').css('height', $(window).height() - 100);;
            <%}%>
        });
        function ShareXml() {
            sld('xml-form');
            $.post(SerUrl + 'Callback/Viewer.aspx', { type: 1, xml: encodeURIComponent($('#result-text-xml').val()),'ViewType':'<%=ViewType.ToString()%>' }, function (d) {
                MsgBox(d);
            });
        }
        function ShowXml() {
            $('#xml-viewer').html('');
            d = null;
            ShowAsObject($('#result-text-xml').val());
        }
        function ShowAsObject(xml) {
            if (IsEmpty(xml)) return;
            d = new dTree('d');
            d.add(0, -1, 'XML Viewer', null);
            var dParser = new DOMParser().parseFromString(xml, 'text/xml');
            if (dParser.childNodes[0].nodeName == "parsererror") dParser = new DOMParser().parseFromString(HtmlEncode(xml), 'text/xml');
            var node = dParser.childNodes[0];

            SetNode(node, 0, d);
            $('#xml-viewer').html('<div style="padding-bottom:5px;"><a href="javascript:d.openAll();" class="a-btn">Expand All Nodes</a>&nbsp;<span class="mm-split">|</span>&nbsp;<a href="javascript: d.closeAll();" class="a-btn" style="">Close All Nodes</a></div>').append(d.toString());
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
                displayName += HtmlEncode(node.textContent).replace(/\r\n|\r|\n/g, '<br />') + '<span style="color:#0000FD;">' + HtmlEncode("</") + '</span>' + nodeNameDisplay + '<span style="color:#0000FD;">' + HtmlEncode(">") + '</span>';
            }
            ddtree.add(ddtree.aNodes.length, parentId, displayName);
            if (node.hasChildNodes()) {
                for (var i = 0; i < node.childNodes.length; i++) {
                    if (node.childNodes[i].nodeType != 1) continue;
                    SetNode(node.childNodes[i], currentId, ddtree);
                }
            }
        }
    </script>
</asp:Content>
