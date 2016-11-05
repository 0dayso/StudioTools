<%@ control language="C#" autoeventwireup="true" inherits="Schedule_Components_ScheduleHistory, App_Web_2d0x74v5" %>
<div>
        <table style="line-height: 1.5em;width:100%;" cellpadding="0px" cellspacing="0px">
            <tr class="header-2" style="line-height:20px;color:#000;">
                <td style="white-space: nowrap;">Action On
                </td>
                <td style="padding-left:20px;">Action By</td>
                <td>Invoke Information</td>
                <td style="<%=CurrentSession.IsFromSchedule?"display:none;":""%>">Request</td>
                <td style="<%=CurrentSession.IsFromSchedule?"display:none;":""%>">Result</td>
            </tr>
            <%if(Histories!=null && Histories.Count>0){ %>
        <asp:Repeater runat="server" ID="rpHistory">
            <ItemTemplate>
                <tr>
                    <td colspan="5">
                        <div class="line-sub"></div>
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align:top;white-space:nowrap;"><%#((DateTime)Eval("ActionOn")).ToString("dd/MM/yy HH:mm:ss") %></td>
                    <td style="padding-left:20px;vertical-align:top;"><%#Eval("ActionBy") %></td>
                    <td><%#Eval("Report") %></td>
                    <td style="<%=CurrentSession.IsFromSchedule?"display:none;":""%>"><textarea class="txt-2" style="width:100%;height:18px;margin-bottom:1px;"><%#Eval("RequestInfo") %></textarea></td>
                    <td style="<%=CurrentSession.IsFromSchedule?"display:none;":""%>"><textarea class="txt-2" style="width:100%;height:18px;margin-bottom:1px;"><%#Eval("ResultInfo") %></textarea></td>
                </tr>
                <%#GetError((string)Eval("Error")) %>
            </ItemTemplate>
        </asp:Repeater>
            <%}else{ %>
                            <tr>
                    <td colspan="5">
                        <div class="line-sub"></div>
                    </td>
                </tr>
                            <tr>
                    <td colspan="5">
                       No history found
                    </td>
                </tr>
            <%} %>
    </table>
</div>
