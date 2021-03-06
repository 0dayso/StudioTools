﻿<%@ control language="C#" autoeventwireup="true" inherits="Components_MSSQL_Projects, App_Web_projects.ascx.2acb5a70" %>
<%if(Projects!=null&&Projects.Count>0){ %>
<div style="margin-bottom: 5px;" class="box">
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
                <td style="white-space: nowrap;">Project Name
                </td>
                <td></td>
                <td>Recent Used
                </td>
                <td style="white-space: nowrap;">Database Type
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <div class="line-sub">
                    </div>
                </td>
            </tr>
            <asp:Repeater ID="rptResult" runat="server">
                <ItemTemplate>
                    <tr style="<%#Container.ItemIndex==0?"display:none;": ""%>">
                        <td colspan="5">
                            <div class="line-sub">
                            </div>
                        </td>
                    </tr>
                    <tr style="vertical-align:top;">
                        <td style="vertical-align: top; white-space: nowrap;"><span class="comment">»</span>
                            <a href="javascript:;;" onclick="sld('dv-projects');window.location='Edit.aspx?pn=<%#((GetTogether.Studio.Project<GetTogether.Studio.Database.ProjectParameter>)Container.DataItem).Parameter.ProjectName %>';">
                                <%#((GetTogether.Studio.Project<GetTogether.Studio.Database.ProjectParameter>)Container.DataItem).Parameter.ProjectName %></a>
                        </td>
                        <td style="white-space: nowrap; vertical-align: top; padding-left: 2px;">
                            <span class="comment" style="cursor: pointer;" onclick="AjaxMsg('Edit / Create project',null,null,SerUrl,'Database/Callback/Projects.aspx?type=2&pn=<%#((GetTogether.Studio.Project<GetTogether.Studio.Database.ProjectParameter>)Container.DataItem).Parameter.ProjectName %>&get=1','',null,23);">
                                [Edit]</span>
                            &nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;
                        <span class="comment" style="cursor: pointer;" onclick="DeleteProject('<%#((GetTogether.Studio.Project<GetTogether.Studio.Database.ProjectParameter>)Container.DataItem).Parameter.ProjectName %>')">
                            [Delete]</span>
                        </td>
                        <td class="comment" style="vertical-align: top;white-space:nowrap;">
                            <%#(DateTime)Eval("RecentUsed")==DateTime.MinValue?"-":((DateTime)Eval("RecentUsed")).ToString("yyyy/MM/dd HH:mm:ss") %>
                        </td>
                        <td style="vertical-align: top;" class="comment">
                            <%#((GetTogether.Studio.Project<GetTogether.Studio.Database.ProjectParameter>)Container.DataItem).Parameter.DatabaseTypeForCodeEngineer.ToString().Replace("SQLServer","SQL Server").Replace("MySQL","My SQL") %>
                        </td>
                        <td class="comment">
                            
                        </td>
                    </tr>
                    <tr><td></td><td class="comment" colspan="4"><%#((GetTogether.Studio.Project<GetTogether.Studio.Database.ProjectParameter>)Container.DataItem).Parameter.ConnectionString%></td></tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

    </div>
</div>
<%} %>