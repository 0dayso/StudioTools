<%@ page title="" language="C#" masterpagefile="~/MP.master" autoeventwireup="true" validaterequest="false" inherits="WebService_Edit, App_Web_bephs8vn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MP1" runat="Server">
    <%if (string.IsNullOrEmpty(Codes))
      { %>
    <link href="<%=ResolveClientUrl("~") %>/themes/skin-<%=GetTogether.Studio.Config.Original.Skin %>/dtree.css?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        rel="stylesheet" type="text/css" />
    <div id="dv-table-web-service">
        <div style="float: left; width: <%=CurrentSession.IsFromSchedule?"35":"25"%>%;">
            <div class="box-option">

                <%=Parameter.Category %>
            </div>
            <div class="box">
                <div>
                    <div style="line-height:1.5em;padding:0px 2px;" class="header-2"><%=Parameter.ProjectName%></div>
                    <div class="line-sub"></div>
                    <div style="padding:0px 2px;">
                    <div style="line-height:1.5em;">
                        <a
                            href="javascript:;;" onclick="GetWebMethod(true);">Refresh</a>
                        &nbsp;&nbsp;<span
                            class="mm-split">|</span>&nbsp;&nbsp;<a
                                href="<%=Parameter.Address %>?WSDL" target="_blank">WSDL</a>
                        &nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;<a href="Edit.aspx?pn=<%=Request["pn"] %>&gc=1"
                            target="_blank">Code</a>
                    </div>
                        </div>
                    <div class="line-sub"></div>
                </div>
                <div style="padding: 0px 2px 2px 2px;">
                    <a href="<%=Parameter.Address %>" target="_blank"
                        style="font-style: italic;"><%=Parameter.Address.Replace("/"," / ").Replace("/  /","//")%></a>
                </div>
            </div>
            <div id="dv-web-methods" style="min-height: 100px; margin-top: 5px;">
                <div id="dv-web-methods-default">
                </div>
            </div>
        </div>
        <div style="width: <%=CurrentSession.IsFromSchedule?"65":"75"%>%; float: right;">
            <div style="margin: 0px 0px 5px 5px;" id="dv-web-service-content">
                <div class="box-option">
                    Request&nbsp;(Double click on the textarea to enlarge)
                </div>
                <div class="box">
                    <div id="dv-web-method-info">
                        <div style="min-height: 100px;">
                        </div>
                    </div>
                </div>
                <div class="box-option" style="margin-top: 5px;">
                    Response&nbsp;(Double click on the textarea to enlarge)
                </div>
                <div class="box">
                    <div id="dv-web-method-result">
                        <div style="min-height: 100px;">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <input type="hidden" id="init-history" />
    <input type="hidden" id="init-method" />
    <%}
      else
      { %>
    <div class="box">
        <textarea id="txt-codes" rows="50" style="width: 100%;"><%=Codes %></textarea>
    </div>
    <%} %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptPlaceHolder" runat="Server">
    <%if (string.IsNullOrEmpty(Codes))
      { %>
    <script src="<%=ResolveClientUrl("~") %>js/dtree.js?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~") %>js/web-service.js?v=<%=GetTogether.Studio.Config.Original.ScriptStyleVersion %>"
        type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        var FVersion = '';
        var ProjectName = '<%=Request["pn"] %>';
        $(document).ready(function () {
            $('#init-history').val(getUrlParam('history'));
            $('#init-method').val(getUrlParam('method'));
            GetWebMethod(false);
        });
    </script>
    <%}
      else
      { %>
    <script language="javascript" type="text/javascript">
        EnhanceTextarea('txt-codes');
        $('#txt-codes').css('height', $(window).height() - 45 + 'px');
    </script>
    <%} %>
</asp:Content>
