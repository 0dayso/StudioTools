<%@ page title="" language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="Schedule_Projects, App_Web_vtpbdn4q" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MP1" runat="Server">
    <div id="dv-content" style="width: 100%; min-height: 300px;">
        <div style="margin-bottom: 5px;">
            Schedule Task
            <%if (GetTogether.Utility.NumberHelper.ToInt(Request["show"], 0) == 0)
              { %>
            &nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;<a
                style="" href="?show=1">Show All</a>
            <%}
              else
              { %>
            &nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;<a
                style="" href="?show=0">By Group</a><%} %>
        </div>
        <div id="dv-projects" style="text-align: left; min-height: 1px;*margin-top:-3px;">
        </div>
        <div style="text-align: right; margin-top:5px;">
            <input type="button" class="btn6" value="Refresh" onclick="window.location.reload();" />
            <input type="button" class="btn6" value="Create New Schedule"
                onclick="AjaxMsg('Create New Project', null, null, SerUrl, '<%=GetTogether.Studio.ProjectParameter.ProjectCategory.Schedule%>/Callback/Projects.aspx?type=1&get=1', '', null,23);" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptPlaceHolder" Runat="Server">
        <script language="javascript" type="text/javascript">
            var ProjectCategory = '<%=GetTogether.Studio.ProjectParameter.ProjectCategory.Schedule%>';
            $(document).ready(function () {
                LoadProjects();
            });
            function ScheduleHistory(schName, schName2) {
                $('tr[class="history"]').hide();
                $('#history-' + schName2).html('Please wait,loading...').parent().show();
                $.get(SerUrl + 'Schedule/Callback/Edit.aspx', { type: 4, ScheduleName: schName }, function (d) {
                    $('#history-' + schName2).html(d).parent().show();
                    window.setTimeout(function () { EnhanceTextarea('history-' + schName2); }, 1000);
                });
            }
    </script>
    </asp:Content>
