<%@ control language="C#" autoeventwireup="true" inherits="logging_Components_SoapList, App_Web_sl3hx5ty" %>
<div class="box">
    <div style="padding-left: 2px;" class="header">
        <a href="<%=Url %>" target="_blank" style="padding-left: 5px;">
            <%=Url %>      </a> - Total <%=SoapLoggings.Count %> Request(s)
    </div>
    <div class="line-sub"></div>
    <table style="width: 100%; padding-left: 2px; padding: 2px;" cellpadding="0px" cellspacing="0px">
        <tr class="header-2">
            <td style="width: 25px; white-space: nowrap; padding: 0px 5px;">Request Time
            </td>
            <td style="width: 25px; white-space: nowrap; padding: 0px 5px;">Response Time
            </td>
            <td style="width: 10px; white-space: nowrap; padding: 0px 5px;">Time</td>
            <td style="padding: 0px 5px;">Request</td>
            <td style="padding: 0px 5px; padding-left: 0px;">Response</td>
        </tr>
        <tr>
            <td colspan="5">
                <div class="line-sub"></div>
            </td>
        </tr>
        <asp:Repeater ID="rptResult" runat="server">
            <ItemTemplate>
                <tr style="vertical-align: top;">
                    <td style="white-space: nowrap; padding: 5px;"><%#((DateTime)Eval("RequestDateTime")).ToString("HH:mm:ss") %></td>
                    <td style="white-space: nowrap; padding: 5px;"><%#((DateTime)Eval("ResponseDateTime")).ToString("HH:mm:ss") %>
                    </td>
                    <td style="padding: 5px;"><%#Eval("ElaspedSeconds") %>s</td>
                    <td style="padding: 5px;">
                        <div class="box">
                            <form method="post" target="_blank">
                                <textarea name="result-Soap" style="width: 100%; height: 100px; border-bottom: solid 1px #ddd;"><%#System.Web.HttpUtility.HtmlEncode((string)Eval("Request")) %></textarea>
                                <input type="hidden" name="Address" value="<%#Eval("Url") %>" />
                                <div style="text-align: right;padding:5px;">
                                    <a href="javascript:;;" onclick="$(this).parent().parent().attr('action','../WebService/Edit.aspx?pn=Soap Logging <%=ServiceName %>&method=<%=MethodName %>&history=Soap Logging')[0].submit();" class="a-btn">Invoke</a>
                                    <a href="javascript:;;" onclick="$(this).parent().parent().attr('action','../Viewer.aspx')[0].submit();" class="a-btn">XML</a>
                                </div>
                            </form>
                        </div>
                    </td>
                    <td style="padding: 5px; padding-left: 0px;">
                        <div class="box">
                            <form action="../Viewer.aspx" method="post" target="_blank">
                                <textarea name="result-" style="width: 100%; height: 100px; border-bottom: solid 1px #ddd;"><%#System.Web.HttpUtility.HtmlEncode((string)Eval("Response")) %></textarea>
                                <input name="type-" type="hidden" value="text/xml">
                                <div style="text-align: right;padding:5px;">
                                    <a href="javascript:;;" onclick="$(this).parent().parent().attr('action','../Viewer.aspx')[0].submit();" class="a-btn">XML</a></div>
                            </form>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <div class="line-sub"></div>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
