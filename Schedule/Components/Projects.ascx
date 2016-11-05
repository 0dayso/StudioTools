<%@ control language="C#" autoeventwireup="true" inherits="Schedule_Components_Projects, App_Web_2d0x74v5" %>
<%if (Projects != null && Projects.Count > 0)
  { %>
<div style="margin-top: 5px;" class="box">
    <div style="padding-left: 2px; cursor: pointer;" class="header" onclick="ShowHideProjects(this);">
        <%if (Projects != null && Projects.Count > 0)
          {%>
        <%=Projects[0].Parameter.Category %>
        <span style="<%=IsShow?"": "display:none;"%>" class="hide">
            <img style="height: 17px; position: relative; top: 5px; border: none;" src="../themes/skin-<%=GetTogether.Studio.Config.Original.Skin %>/images/up.png" /></span><span
                style="<%=IsShow?"display:none;": ""%>"
                class="show"><img style="height: 17px; position: relative; top: 5px; border: none;"
                    src="../themes/skin-<%=GetTogether.Studio.Config.Original.Skin %>/images/down.png" /></span>

        <%} %>
    </div>
    <div style="<%=IsShow?"": "display:none;"%>">
        <div class="line-sub"></div>
         <table style="width: 100%; line-height: 1.5em;" class="" cellpadding="0px" cellspacing="0px">
            <tr class="header-2">
                <td style="white-space: nowrap;width:20%;">Project Name
                </td>
                <td style="white-space: nowrap;width:10%;"></td>
                <td style="width:20%;">Week / Date / Time</td>
                <td style="white-space: nowrap;">Last Action On / By
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <div class="line-sub">
                    </div>
                </td>
            </tr>
            <asp:Repeater ID="rptResult" runat="server">
                <ItemTemplate>
                    <tr style="<%#Container.ItemIndex==0?"display:none;": ""%>">
                        <td colspan="4">
                            <div class="line-sub">
                            </div>
                        </td>
                    </tr>
                    <tr title=" <%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Url%>" style="<%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Status==GetTogether.Studio.Schedule.ScheduleStatus.Disabled?"background-color:#fff;":""%>">
                        <td style="vertical-align: top; white-space: nowrap;"><span class="comment">»</span>
                            <%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Name%><%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.IsInvoking?"<span style='margin-left:5px;color:blue;font-weight:bold;'>(Invoking)</span>":"" %>
                            <%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Status==GetTogether.Studio.Schedule.ScheduleStatus.Disabled?" (<span style='font-weight:bold;'>Disabled<span>)":""%>
                        </td>
                        <td style="white-space: nowrap; vertical-align: top; padding-left: 2px;">
                            <span class="comment" style="cursor: pointer;" onclick="AjaxMsg('Edit / Create project',null,null,SerUrl,'Schedule/Callback/Projects.aspx?type=2&pn=<%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Name %>&get=1','',null,23);">
                                [Edit]</span>
                            &nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;
                        <span class="comment" style="cursor: pointer;" onclick="DeleteProject('<%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Name %>');">
                            [Delete]</span>&nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;
                        <span class="comment" style="cursor: pointer;" onclick="ScheduleHistory('<%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Name%>','<%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Name.Replace(" ","_")%>');">[History]</span>
                        </td>

                        <td class="comment" style="vertical-align: top; white-space: nowrap;">
                            <%#GetTogether.Utility.DateHelper.GetWeekdayString(((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Week) %> / <%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.ScheduleDateTime.ToString("dd/MM/yyyy HH:mm:ss").Replace("01/01/0001 ","").Replace("/0001","") %>
                            <%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.RepeatForTime?"<span style='font-weight:bold;'>(Repeat)</span>":"" %>
                        </td>
                        <td class="comment" style="vertical-align: top; <%#(DateTime.Now.Date==((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.ActionOn.Date && DateTime.Now.Subtract(((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.ActionOn).Hours<24)?"background-color:#E9F2FA;": ""%>">
                            <%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.ActionOn==DateTime.MinValue?"-":((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.ActionOn.ToString("MM/dd HH:mm:ss") %>
                             / <%#string.IsNullOrEmpty(((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.ActionBy)?"-":((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.ActionBy %>
                            
                        </td>
                    </tr>
                    <tr class="history" style="display: none; vertical-align: top;">
                        <td style="text-align: right;">History</td>
                        <td colspan="3" id='history-<%#((GetTogether.Studio.Project<GetTogether.Studio.Schedule.ScheduleTask>)Container.DataItem).Parameter.Name.Replace(" ","_")%>' style="color:#656565;border:solid 1px #fff;background-color:#eeeeee;"></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</div>
<%} %>