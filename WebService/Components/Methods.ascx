<%@ control language="C#" autoeventwireup="true" inherits="WebService_Components_Methods, App_Web_mo93y8pd" %>
<div class="box-option">
    Method(s)</div>
<div class="box">
    <%if (string.IsNullOrEmpty(Error))
      { %>
    <div id="dv-web-method-list" style="padding: 0px; text-align: left; overflow-x: scroll;
        margin: 1px;">
        <table width="100%" cellspacing="0" cellpadding="0" border="0" style="line-height: 1.5em;">
            <asp:Repeater ID="rptResult" runat="server">
                <ItemTemplate>
                    <tr valign="top">
                        <td style="width:5px;"><span class="comment">»</span></td>
                        <td>
                            <a href="javascript:;;" onclick="GetWebMethodInfo('<%#((System.Reflection.MethodInfo)Container.DataItem).Name %>');">
                                <%#((System.Reflection.MethodInfo)Container.DataItem).Name %>
                            </a>
                            <%--                                            <a style="float:left;" href="javascript:;;" onclick="LoadRecent('<%#((System.Reflection.MethodInfo)Container.DataItem).Name %>','Recent');">
                                               <%#((System.Reflection.MethodInfo)Container.DataItem).Name %>
                                            </a>--%></td><td style="text-align:right;">
                            <a target="_blank" href="<%=Parameter.Address %>?op=<%#((System.Reflection.MethodInfo)Container.DataItem).Name %>">
                                Intro</a>
                        </td>

                    </tr>
                    <tr>
                        <td colspan="3">
                            <div class="line-sub">
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <%}
      else
      { %>
    <%=Error %>
    <%} %>
</div>
