<%@ control language="C#" autoeventwireup="true" inherits="WebService_Components_Projects, App_Web_mo93y8pd" %>
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
                <td style="white-space: nowrap; width: 20%;">Project Name
                </td>
                <td style="white-space: nowrap; width: 15%;"></td>
                <td style="white-space: nowrap; width: 15%;">Recent Used
                </td>
                <td style="white-space: nowrap;<%=CurrentSession.IsFromSchedule?"display:none;":""%>">Web Service Address
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
                    <tr title="<%#((GetTogether.Studio.Project<GetTogether.Studio.WebService.ProjectParameter>)Container.DataItem).Parameter.Address%>">
                        <td style="vertical-align: top; white-space: nowrap;"><span class="comment">»</span>
                            <a href="Edit.aspx?pn=<%#((GetTogether.Studio.Project<GetTogether.Studio.WebService.ProjectParameter>)Container.DataItem).Parameter.ProjectName %>" onclick="sld('dv-projects');">
                                <%#((GetTogether.Studio.Project<GetTogether.Studio.WebService.ProjectParameter>)Container.DataItem).Parameter.ProjectName %></a>
                        </td>
                        <td style="white-space: nowrap; vertical-align: top; padding-left: 2px;">
                            <a href="javascript:;;" style="cursor: pointer;" onclick="AjaxMsg('Edit / Create project',null,null,SerUrl,'WebService/Callback/Projects.aspx?type=2&pn=<%#((GetTogether.Studio.Project<GetTogether.Studio.WebService.ProjectParameter>)Container.DataItem).Parameter.ProjectName %>&get=1','',null,23);">
                                [Edit]</a>
                            &nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;
                        <a href="javascript:;;" style="cursor: pointer;" onclick="DeleteProject('<%#((GetTogether.Studio.Project<GetTogether.Studio.WebService.ProjectParameter>)Container.DataItem).Parameter.ProjectName %>');">
                            [Delete]</a>
                        </td>
                        <td class="comment">
                            <%--<%#GetTogether.Utility.DateHelper.FormatDateTimeToString((DateTime)Eval("RecentUsed"), GetTogether.Utility.DateHelper.DateFormat.ddMMMyyyyHHmm) %>--%>
                            <%#(DateTime)Eval("RecentUsed")==DateTime.MinValue?"-":((DateTime)Eval("RecentUsed")).ToString("yyyy/MM/dd HH:mm:ss") %>
                        </td>
                        <td style="vertical-align: top;<%=CurrentSession.IsFromSchedule?"display:none;":""%>" class="comment">
                            <a target="_blank" href="<%#((GetTogether.Studio.Project<GetTogether.Studio.WebService.ProjectParameter>)Container.DataItem).Parameter.Address %>">
                                <%#((GetTogether.Studio.Project<GetTogether.Studio.WebService.ProjectParameter>)Container.DataItem).Parameter.Address%></a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</div>
<%} %>